using System.Reactive.Subjects;
using System.Reactive;
using System.Text;

namespace PerapuSearch.Gen4SeedInputSupport.Internal
{
    internal partial class Gen4SeedInputSupportForm : Form
    {
        AsyncSubject<Unit> m_FormClosing = new AsyncSubject<Unit>();
        public IObservable<Unit> FormClosingEvent => m_FormClosing;

        Subject<string> m_InputTextDecided = new Subject<string>();
        public IObservable<string> InputTextDecided => m_InputTextDecided;

        readonly Gen4SeedInputSupportFormConfig m_Config;

        public Gen4SeedInputSupportForm(Gen4SeedInputSupportFormConfig config)
        {
            m_Config = config;
            InitializeComponent();

            // 設定を反映
            m_InitialSeedBox.Text = m_Config.InitialSeed;
            m_SecondsDiffCheck.Checked = m_Config.AccountsSecondsDiff;
            m_FrameDiffRangeBox.Value = m_Config.FrameDiffRange;
            m_OnlyEvenDiffCheck.Checked = m_Config.OnlyEvenDiff;
        }

        void ReflectConfig()
        {
            m_Config.InitialSeed = m_InitialSeedBox.Text;
            m_Config.AccountsSecondsDiff = m_SecondsDiffCheck.Checked;
            m_Config.FrameDiffRange = (int)m_FrameDiffRangeBox.Value;
            m_Config.OnlyEvenDiff = m_OnlyEvenDiffCheck.Checked;
        }

        private void Gen4SeedInputSupportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReflectConfig();

            m_FormClosing.OnNext(default);
            m_FormClosing.OnCompleted();
            m_FormClosing.Dispose();
            m_InputTextDecided.Dispose();
        }

        private void m_InputButton_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(m_InitialSeedBox.Text, System.Globalization.NumberStyles.HexNumber, null, out uint initialSeed))
            {
                ReflectConfig();

                var sb = new StringBuilder();
                uint secondsOffsetMin = m_SecondsDiffCheck.Checked ? 0u : 1u; // +1の底上げ
                uint secondsOffsetMax = m_SecondsDiffCheck.Checked ? 2u : 1u; // +1の底上げ
                uint frameDiffRange = (uint)m_FrameDiffRangeBox.Value;
                for (uint secondsOffset = secondsOffsetMin; secondsOffset <= secondsOffsetMax; ++secondsOffset)
                {
                    for (uint frameOffset = 0; frameOffset <= frameDiffRange * 2; ++frameOffset)
                    {
                        if (m_OnlyEvenDiffCheck.Checked && (frameOffset % 2) == 1)
                        {
                            continue;
                        }

                        uint seed = initialSeed + (secondsOffset << 24) - (1 << 24);
                        seed = seed + frameOffset - frameDiffRange;
                        sb.AppendLine($"{seed:X8}");
                    }
                }
                m_InputTextDecided.OnNext(sb.ToString());
                Close();
            }
            else
            {
                MessageBox.Show($"不正なseed: {m_InitialSeedBox.Text}");
            }
        }
    }
}
