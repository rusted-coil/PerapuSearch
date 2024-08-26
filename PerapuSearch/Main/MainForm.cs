using PerapuSearch.Config;
using System.Reactive;
using System.Reactive.Subjects;

namespace PerapuSearch
{
    public partial class MainForm : Form
    {
        public enum GenerationType
        {
            Gen4, Gen5,
        }

        Subject<(string[], string)> m_InputChanged = new Subject<(string[], string)>();
        public IObservable<(string[] Seeds, string Tones)> InputChanged => m_InputChanged;

        Subject<Unit> m_ConfigChanged = new Subject<Unit>();
        public IObservable<Unit> ConfigChanged => m_ConfigChanged;

        readonly ConfigData m_Config;

        public MainForm(ConfigData config)
        {
            m_Config = config;

            InitializeComponent();

            GenerationType generation = (GenerationType)config.Generation;
            m_Gen4Check.Checked = generation == GenerationType.Gen4;
            m_Gen5Check.Checked = generation == GenerationType.Gen5;
            SetCounts();
            m_FuzzinessBox.Text = config.Fuzziness.ToString();
            m_SampleCountBox.Text = config.SampleCount.ToString();
        }

        public void SetResultText(string resultText)
        {
            m_ResultBox.Text = resultText;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            string[] seeds = m_SeedList.Text.Split('\n');
            if (seeds.Length == 0)
            {
                m_ResultBox.Text = "seedを1つ以上入力してください。";
                return;
            }

            string tones = m_ToneBox.Text;
            if (tones.Length <= 2)
            {
                m_ResultBox.Text = "音程を3つ以上入力してください。";
                return;
            }

            // 有効な入力だったらイベントを発行
            m_InputChanged.OnNext((seeds, tones));
        }

        private void m_Gen4Check_CheckedChanged(object sender, EventArgs e)
        {
            if (m_Gen4Check.Checked)
            {
                m_Config.Generation = (int)GenerationType.Gen4;
                m_ConfigChanged.OnNext(default);
                SetCounts();
            }
        }

        private void m_Gen5Check_CheckedChanged(object sender, EventArgs e)
        {
            if (m_Gen5Check.Checked)
            {
                m_Config.Generation = (int)GenerationType.Gen5;
                m_ConfigChanged.OnNext(default);
                SetCounts();
            }
        }

        void SetCounts()
        {
            m_isCountChangeEventDisabled = true;

            if (m_Config.Generation == (int)GenerationType.Gen4)
            {
                m_MinCountBox.Text = m_Config.Gen4MinCount.ToString();
                m_MaxCountBox.Text = m_Config.Gen4MaxCount.ToString();
            }
            else
            {
                m_MinCountBox.Text = m_Config.Gen5MinCount.ToString();
                m_MaxCountBox.Text = m_Config.Gen5MaxCount.ToString();
            }

            m_isCountChangeEventDisabled = false;
        }

        bool m_isCountChangeEventDisabled = false;
        private void m_MinCountBox_TextChanged(object sender, EventArgs e)
        {
            if (m_isCountChangeEventDisabled)
            {
                return;
            }

            if (int.TryParse(m_MinCountBox.Text, out int result))
            {
                if (m_Config.Generation == (int)GenerationType.Gen4)
                {
                    m_Config.Gen4MinCount = result;
                }
                else
                {
                    m_Config.Gen5MinCount = result;
                }
                m_ConfigChanged.OnNext(default);
            }
            else
            {
                MessageBox.Show($"無効な入力: {m_MinCountBox.Text}");
            }
        }

        private void m_MaxCountBox_TextChanged(object sender, EventArgs e)
        {
            if (m_isCountChangeEventDisabled)
            {
                return;
            }

            if (int.TryParse(m_MaxCountBox.Text, out int result))
            {
                if (m_Config.Generation == (int)GenerationType.Gen4)
                {
                    m_Config.Gen4MaxCount = result;
                }
                else
                {
                    m_Config.Gen5MaxCount = result;
                }
                m_ConfigChanged.OnNext(default);
            }
            else
            {
                MessageBox.Show($"無効な入力: {m_MaxCountBox.Text}");
            }
        }

        private void m_FuzzinessBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(m_FuzzinessBox.Text, out int result))
            {
                m_Config.Fuzziness = result;
                m_ConfigChanged.OnNext(default);
            }
            else
            {
                MessageBox.Show($"無効な入力: {m_FuzzinessBox.Text}");
            }
        }

        private void m_SampleCountBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(m_SampleCountBox.Text, out int result))
            {
                m_Config.SampleCount = result;
                m_ConfigChanged.OnNext(default);
            }
            else
            {
                MessageBox.Show($"無効な入力: {m_SampleCountBox.Text}");
            }
        }
    }
}
