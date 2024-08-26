using Gen4RNGLib.Chatot;
using Gen5RNGLib.Chatot;
using PerapuSearch.Config;
using PerapuSearch.Infrastructure;
using System.Reactive.Disposables;
using System.Text;

namespace PerapuSearch.Main
{
    internal sealed class MainFormPresenter : IDisposable
    {
        readonly MainForm m_Form;
        readonly ConfigData m_Config;
        readonly CompositeDisposable m_Disposables = new CompositeDisposable();

        public MainFormPresenter()
        {
            m_Config = Serializer.Deserialize<ConfigData>("config.json");
            m_Form = new MainForm(m_Config);

            m_Disposables.Add(m_Form.ConfigChanged.Subscribe(_ => SaveConfig()));
            m_Disposables.Add(m_Form.InputChanged.Subscribe(args => Calculate(args.Seeds, args.Tones)));
            m_Disposables.Add(m_Form.Gen4SeedInputSupportButton.Clicked.Subscribe(_ => OpenGen4SeedInputSupportForm()));
        }

        public void Run()
        {
            Application.Run(m_Form);
        }

        public void Dispose()
        {
            m_Disposables.Dispose();
        }

        void SaveConfig()
        {
            if (!Serializer.Serialize("config.json", m_Config, out string errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
        }

        void OpenGen4SeedInputSupportForm()
        {
            var stream = Gen4SeedInputSupport.Gen4SeedInputSupportFormFactory.OpenOrFocusForm();
            if (stream != null)
            {
                m_Disposables.Add(stream.Subscribe(m_Form.SetSeedsText));
            }
        }

        void Calculate(string[] seeds, string tones)
        {
            StringBuilder resultStringBuilder = new StringBuilder();

            int minCount, maxCount;
            if (m_Config.Generation == (int)MainForm.GenerationType.Gen4)
            {
                minCount = m_Config.Gen4MinCount;
                maxCount = m_Config.Gen4MaxCount + tones.Length;
            }
            else
            {
                minCount = m_Config.Gen5MinCount;
                maxCount = m_Config.Gen5MaxCount + tones.Length;
            }
            int fuzziness = m_Config.Fuzziness;
            int sampleCount = m_Config.SampleCount;

            int[] inputTones = tones.Select(letter => ConvertInputToneLetter(letter, sampleCount)).ToArray();

            foreach (var seedString in seeds)
            {
                int[] answerTones = new int[maxCount];
                // 第4世代版
                if (m_Config.Generation == (int)MainForm.GenerationType.Gen4)
                {
                    if (uint.TryParse(seedString, System.Globalization.NumberStyles.HexNumber, null, out uint initialSeed))
                    {
                        var rng = Gen4RngLib.Rng.RngFactory.CreateLcgRng(initialSeed);

                        for (int i = 0; i < maxCount; ++i)
                        {
                            answerTones[i] = (int)rng.Chatter();
                        }
                    }
                    else
                    {
                        resultStringBuilder.AppendLine($"不正なseed: {seedString}");
                    }
                }
                // 第5世代版
                else
                {
                    if (ulong.TryParse(seedString, System.Globalization.NumberStyles.HexNumber, null, out ulong initialSeed))
                    {
                        var rng = Gen5RNGLib.Rng.RngFactory.CreateLcgRng(initialSeed);

                        for (int i = 0; i < maxCount; ++i)
                        {
                            answerTones[i] = (int)rng.Chatter();
                        }
                    }
                    else
                    {
                        resultStringBuilder.AppendLine($"不正なseed: {seedString}");
                    }
                }

                // answerTonesからinputTonesにマッチする箇所を検索
                for (int a = minCount; a <= answerTones.Length - inputTones.Length; ++a)
                {
                    bool isMatched = true;
                    for (int b = 0; b < inputTones.Length; ++b)
                    {
                        int k = inputTones[b];
                        int answer = answerTones[a + b];

                        if (k == c_InputToneWild) // ワイルドカードは全てにマッチ
                        {
                            continue;
                        }
                        else if (k == c_InputTonePlus)
                        {
                            if (b == 0)
                            {
                                continue;
                            }
                            if (answer <= answerTones[a + b - 1])
                            {
                                isMatched = false;
                                break;
                            }
                        }
                        else if (k == c_InputToneMinus)
                        {
                            if (b == 0)
                            {
                                continue;
                            }
                            if (answer >= answerTones[a + b - 1])
                            {
                                isMatched = false;
                                break;
                            }
                        }
                        else if (k == c_InputToneEqual)
                        {
                            // 前の音からの差分があいまいさの幅内だったらマッチ
                            int diff = answer - answerTones[a + b - 1];
                            if (diff * 200 < -(8191 * fuzziness) || diff * 200 > 8191 * fuzziness)
                            {
                                isMatched = false;
                                break;
                            }
                        }
                        else
                        {
                            // F=Fuzziness
                            // M=SampleCount
                            // inputToneがkの時、マッチするのは((100-F)*k/M)%～((100-F)*(k+1)/M + F)%

                            // (100-F)*k/M <= answer * 100 / 8191
                            // answer * 100 / 8191 <= (100-F)*(k+1)/M + F かどうかを確かめたい

                            if ((100 - fuzziness) * k * 8191 > answer * 100 * sampleCount
                                || answer * 100 * sampleCount > ((100 - fuzziness) * (k + 1) + fuzziness * sampleCount) * 8191)
                            {
                                isMatched = false;
                                break;
                            }
                        }
                    }
                    if (isMatched)
                    {
                        resultStringBuilder.AppendLine($"0x{seedString}: 消費{a}～{a + inputTones.Length}");
                    }
                }
            }

            m_Form.SetResultText(resultStringBuilder.ToString());
        }

        const int c_InputToneWild = -1;
        const int c_InputTonePlus = -2;
        const int c_InputToneMinus = -3;
        const int c_InputToneEqual = -4;
        static int ConvertInputToneLetter(char letter, int sampleCount)
        {
            if (letter >= '1' && letter < '1' + sampleCount)
            {
                return letter - '1';
            }
            else if (letter == '+')
            {
                return c_InputTonePlus;
            }
            else if (letter == '-')
            {
                return c_InputToneMinus;
            }
            else if (letter == '=')
            {
                return c_InputToneEqual;
            }
            return c_InputToneWild;
        }
    }
}
