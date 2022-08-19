using Terminal.Gui;

namespace LearningTheConsoleUi;

public class WindowBase
{
    
    private Window _window;
    public Window Window
    {
        get => _window;
        protected init
        {
            var statusBar = new StatusBar(new StatusItem[]
            {
                new (Key.CtrlMask | Key.W, "Close", Close),
            });
            value.Add(statusBar);
            _window = value;
        }
    }

    private bool _isVisible = false;
    public bool IsVisible => _isVisible;
    
    public void Show()
    {
        //We cant show a window that is already visible, so we will send it to the front of the view
        if (_isVisible)
        {
            Application.Top.BringSubviewToFront(Window);
            return;
        }

        if (Window == null)
            throw new Exception($"Window was not set {this.GetType().Name}");

        var windowLocation = WindowPlacer.NewLocation();
        
        Window.X = windowLocation.X;
        Window.Y = windowLocation.Y;
        
        Application.Top.Add(Window);
        _isVisible = true;
        
    }

    public void Close()
    {
        if(_isVisible)
            Application.Top.Remove(Window);
        _isVisible = false;
    }
}