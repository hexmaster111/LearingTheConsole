using LearningTheConsoleUi.WindowManagement;
using Terminal.Gui;

namespace LearningTheConsoleUi.SystemWindows;

public class SettingsWindow : WindowBase
{
    private Window _window
    {
        get
        {
            var win = new Window("Settings")
            {
                X = 0,
                Y = 1,
                Width = 25,
                Height = 8
            };
            
            
            win.Add(new Label("Some Label"));

            return win;
        }
    }

    public SettingsWindow()
    {
        this.Window = _window;
    }
}