using Gen4RNGLib.Chatot;
using Gen5RNGLib.Chatot;
using System.Text;

namespace PerapuSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Calculate(object sender, EventArgs e)
        {
            string[] seeds = SeedList.Text.Split('\n');
            if (seeds.Length == 0)
            {
                ResultBox.Text = "seedを1つ以上入力してください。";
                return;
            }

            string tones = ToneBox.Text;
            if (tones.Length <= 2)
            {
                ResultBox.Text = "音程を3つ以上入力してください。";
                return;
            }

            StringBuilder resultStringBuilder = new StringBuilder();

            int[] toneMasks = tones.Select(GetInputToneMask).ToArray();

            // TODO
            bool isGen4 = true;
            int maxCount = 100;

            foreach (var seedString in seeds)
            {
                int[] answerTones = new int[maxCount];
                // 第4世代版
                if (isGen4)
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
                for (int a = 0; a <= answerTones.Length - toneMasks.Length; ++a)
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

            ResultBox.Text = resultStringBuilder.ToString();
        }

        static int GetInputToneMask(char letter) => letter switch {
            '1' => 0b00011,
            '2' => 0b01110,
            '3' => 0b11000,
            _   => 0b11111,
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
