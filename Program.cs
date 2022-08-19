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
                                                 "    Ctrl+W: Close the current Window\n"+
                                                 "    Ctrl+Q: Quit the Application"));
            

            WindowList.Add(new SettingsWindow());

            
            //TODO: an uncaught exception console
            Application.Run();
            Application.Shutdown();
        }
    }
}