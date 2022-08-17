using Terminal.Gui;

namespace LearningTheConsoleUi;

public static class MainStatusBar
{
    public static StatusBar StatusBar
    {
        get
        {
            return new StatusBar(new StatusItem[]
            {
                new StatusItem(Key.F1, "~F1~ Help", () => Program.SettingsWindow.Show()),
                new StatusItem(Key.F2, "~F2~ Load", () => MessageBox.Query(50, 7, "Load", "Loading", "Ok")),
                new StatusItem(Key.F3, "~F3~ Save", () => MessageBox.Query(50, 7, "Save", "Saving", "Ok")),
                new StatusItem(Key.Null, Application.Driver.GetType().Name, null)
            });
        }
    }
}