using PerapuSearch.Main;
using System.Runtime.Versioning;

namespace PerapuSearch
{
    [SupportedOSPlatform("windows")]
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            using (var presenter = new MainFormPresenter())
            {
                presenter.Run();
            }
        }
    }
}