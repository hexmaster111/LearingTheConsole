using Terminal.Gui;

namespace LearningTheConsoleUi;

public class SettingsWindow : IWindow
{
    private bool _opened = false;
    private Window window
    {
        get
        {
            if (_opened)
                throw new("This window is already open");
            
            
            var win = new Window("Settings")
            {
                X = 0,
                Y = 1,
                Width = 25,
                Height = 8
            };
            
            var btn = new Button("Close");
            btn.Clicked += Close;
            
            
            win.Add(new Label("Some Label"), btn);

            _window = win;
            
            _opened = true;
            
            return _window;
        }
    }

    private Window _window;
    
    public void Close()
    {
        Application.Top.Remove(_window);
        _opened = false;
    }
    
    public void Show()
    {
        Application.Top.Add(window);
    }
}