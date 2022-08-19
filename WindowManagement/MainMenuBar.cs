using Terminal.Gui;

namespace LearningTheConsoleUi.WindowManagement;

public static class MainMenuBar
{
    public static MenuBar MainMenu
    {
        get
        {
            return new MenuBar(new MenuBarItem[]
            {
                new MenuBarItem("_File", new MenuItem[]
                {
                    new MenuItem("_New", "Creates new file", null),
                    new MenuItem("_Open", "", null),
                    new MenuItem("_Close", "", null),
                })
            });
        }
    }
}