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

            foreach (var seedString in seeds)
            {
                if (UInt64.TryParse(seedString, System.Globalization.NumberStyles.HexNumber, null, out UInt64 initialSeed))
                {
                    UInt64 seed = GetNextSeed(initialSeed);
                    int[] answerTones = new int[100];
                    for (int i = 0; i < 100; ++i)
                    {
                        answerTones[i] = GetAnswerTone(seed);
                        seed = GetNextSeed(seed);
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
                else
                {
                    resultStringBuilder.AppendLine($"不正なseed: {seedString}");
                }
            }

            ResultBox.Text = resultStringBuilder.ToString();
        }

        static UInt64 GetNextSeed(UInt64 seed) => seed * 0x5D588B656C078965ul + 0x269EC3;

        static int GetInputToneMask(char letter) => letter switch {
            '1' => 0b00011,
            '2' => 0b01110,
            '3' => 0b11000,
            _   => 0b11111,
        };

        static int GetAnswerTone(UInt64 seed)
        { 
            uint rand = (uint)(seed >> 51); // 0～8191
            uint value = (rand + 1) * 5;
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
