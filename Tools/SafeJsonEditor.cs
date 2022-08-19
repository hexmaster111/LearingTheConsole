using LearningTheConsoleUi.WindowManagement;
using Terminal.Gui;

namespace LearningTheConsoleUi.Tools;

public class SafeJsonEditor : WindowBase
{

    private Window _window
    {
        get
        {
            var win = new Window("JSON Editor")
            {
                Width = 25,
                Height = 25 / 2
            };


            var menu = new MenuBar(new []
            {
                new MenuBarItem("_File", new []
                {
                    new MenuItem("_Open", "Open", () => { }),
                    new MenuItem("_Save", "Save", () => { }),
                    new MenuItem("_Save As", "Save As", () => { }),
                    new MenuItem("_Exit", "Exit", () => { })
                }),
            });
            
            
            win.Add(menu);
            
            return win;
        }
    }
    
    
    public SafeJsonEditor()
    {
        this.Window = _window;
    }
}