using Numbers.Presenters;
using Numbers.Views;

namespace Numbers;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        var mainView = new MainView();
        var presenter = new NumberPresenter(mainView);
        Application.Run(mainView);
        
        presenter.Dispose();
    }
}