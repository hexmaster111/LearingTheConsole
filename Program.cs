using LearningTheConsoleUi.SystemWindows;
using LearningTheConsoleUi.Tools;
using LearningTheConsoleUi.WindowManagement;
using Terminal.Gui;

namespace LearningTheConsoleUi
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Application.Init();
            Application.Top.Add(MainStatusBar.StatusBar, MainMenuBar.MainMenu);

            Application.Top.Add(Logo.Get());

            Application.Top.Add(new Label(0, 20, "Global Shortcuts:\n" +
                                                 "    Ctrl+W: Close the current Window\n" +
                                                 "    Ctrl+Q: Quit the Application"));


            var a = new ProgressBar()
            {
                X = 0,
                Y = 1,
                Width = Dim.Fill(),
                Height = 1,
            };


            Application.MainLoop.AddIdle(() =>
            {
                a.Pulse();
                return true;
            });
            
            Application.Top.Add(a);

            WindowList.Add(new SettingsWindow());
            WindowList.Add(new SafeJsonEditor());

            //TODO: an uncaught exception console
            Application.Run();
            Application.Shutdown();
        }
    }
}