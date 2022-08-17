using Terminal.Gui;

namespace LearningTheConsoleUi
{
    public static class Program
    {
       public static readonly SettingsWindow SettingsWindow = new();


        static void Main(string[] args)
        {
            Application.Init();
            Application.Top.Add(MainStatusBar.StatusBar, MainMenuBar.MainMenu);

            SettingsWindow.Show();

            
            //TODO: an uncaught exception console
            Application.Run();
            Application.Shutdown();
        }
    }
}