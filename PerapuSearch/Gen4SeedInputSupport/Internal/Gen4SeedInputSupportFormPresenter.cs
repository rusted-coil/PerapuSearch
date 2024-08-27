using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Subjects;

namespace PerapuSearch.Gen4SeedInputSupport.Internal
{
    internal sealed class Gen4SeedInputSupportFormPresenter
    {
        public IObservable<string> InputTextDecided => m_Form.InputTextDecided;

        AsyncSubject<Unit> m_FormClosing = new AsyncSubject<Unit>();
        public IObservable<Unit> FormClosing => m_FormClosing;

        readonly Gen4SeedInputSupportForm m_Form;

        public void Show() => m_Form.Show();
        public void Focus() => m_Form.Focus();

        readonly CompositeDisposable m_Disposables = new CompositeDisposable();

        public Gen4SeedInputSupportFormPresenter(Gen4SeedInputSupportFormConfig config)
        {
            m_Form = new Gen4SeedInputSupportForm(config);
            m_Disposables.Add(m_FormClosing);
            m_Disposables.Add(m_Form.FormClosingEvent.Subscribe(_ => OnFormClosing()));
        }

        void OnFormClosing()
        {
            m_FormClosing.OnNext(default);
            m_FormClosing.OnCompleted();

            m_Disposables.Dispose();
        }
    }
}
