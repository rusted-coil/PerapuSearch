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

        public Gen4SeedInputSupportForm()
        {
            InitializeComponent();
        }

        private void Gen4SeedInputSupportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_FormClosing.OnNext(default);
            m_FormClosing.OnCompleted();
            m_FormClosing.Dispose();
            m_InputTextDecided.Dispose();
        }

        private void m_InputButton_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(m_InitialSeedBox.Text, System.Globalization.NumberStyles.HexNumber, null, out uint initialSeed))
            {
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
