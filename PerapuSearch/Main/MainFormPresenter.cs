﻿using Gen4RNGLib.Chatot;
using Gen5RNGLib.Chatot;
using System.Reactive.Disposables;
using System.Text;
using PerapuSearch.Config;
using PerapuSearch.Infrastructure;

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

        void Calculate(string[] seeds, string tones)
        {
            StringBuilder resultStringBuilder = new StringBuilder();

            int[] toneMasks = tones.Select(GetInputToneMask).ToArray();

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
                            answerTones[i] = GetAnswerTone(rng.Chatter());
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
                            answerTones[i] = GetAnswerTone(rng.Chatter());
                        }
                    }
                    else
                    {
                        resultStringBuilder.AppendLine($"不正なseed: {seedString}");
                    }
                }

                // answerTonesからtoneMasksにマッチする箇所を検索
                for (int a = minCount; a <= answerTones.Length - toneMasks.Length; ++a)
                {
                    bool isMatched = true;
                    for (int b = 0; b < toneMasks.Length; ++b)
                    {
                        if ((answerTones[a + b] & toneMasks[b]) == 0)
                        {
                            isMatched = false;
                            break;
                        }
                    }
                    if (isMatched)
                    {
                        resultStringBuilder.AppendLine($"0x{seedString}: 消費{a}～{a + toneMasks.Length}");
                    }
                }
            }

            m_Form.SetResultText(resultStringBuilder.ToString());
        }

        static int GetInputToneMask(char letter) => letter switch
        {
            '1' => 0b00011,
            '2' => 0b01110,
            '3' => 0b11000,
            _ => 0b11111,
        };

        static int GetAnswerTone(uint toneValue) // 0～8191の値を与え、音程の処理用正解データに変換する
        {
            uint value = (toneValue + 1) * 5;
            if (value < 8192)
            {
                return 0b00001;
            }
            else if (value < 8192 * 2)
            {
                return 0b00010;
            }
            else if (value < 8192 * 3)
            {
                return 0b00100;
            }
            else if (value < 8192 * 4)
            {
                return 0b01000;
            }
            else
            {
                return 0b10000;
            }
        }
    }
}
