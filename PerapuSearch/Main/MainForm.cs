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

        public GenerationType Generation => m_Gen4Check.Checked ? GenerationType.Gen4 : GenerationType.Gen5;

        public MainForm()
        {
            InitializeComponent();
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
                m_ResultBox.Text = "seed��1�ȏ���͂��Ă��������B";
                return;
            }

            string tones = m_ToneBox.Text;
            if (tones.Length <= 2)
            {
                m_ResultBox.Text = "������3�ȏ���͂��Ă��������B";
                return;
            }

            // �L���ȓ��͂�������C�x���g�𔭍s
            m_InputChanged.OnNext((seeds, tones));
        }
    }
}
