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
                new StatusItem(Key.F12, "Menu", ()=> Application.Top.Add(WindowMenu.Create())),
                new StatusItem(Key.F1, "~F1~ Help", null),
                new StatusItem(Key.F2, "~F2~ Load", () => new SettingsWindow().Show()),
                new StatusItem(Key.F3, "~F3~ Save", () => MessageBox.Query(50, 7, "Save", "Saving", "Ok")),
                new StatusItem(Key.Null, Application.Driver.GetType().Name, null)
            });
        }
    }
}
           