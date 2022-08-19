using Terminal.Gui;

namespace LearningTheConsoleUi;

public static class WindowMenu
{
    public static Window Create()
    {
        var menu = new Window("QuickStar");

        menu.X = 0;
        menu.Y = 0;


        var longestName = 0;
        var windowCount = 0;

        foreach (var window in WindowList.Windows)
        {
            //check for the longest window name
            if (window.Window.Title.Length > longestName)
            {
                longestName = window.Window.Title.Length;
            }

            var windowButton = new Button(0, windowCount, window.Window.Title);
            windowButton.Clicked += () =>
            {
                window.Show();
            };
            
            menu.Add(windowButton);

            windowCount++;
        }

        menu.Width = longestName + 6;
        menu.Height = windowCount + 2;

        return menu;
    }
}

public static class WindowList
{
    private static List<WindowBase> _windows = new();

    public static List<WindowBase> Windows => _windows;

    /// <summary>
    /// Adds a window to the window list
    /// </summary>
    public static void Add(WindowBase win)
    {
        if (win == null)
            throw new NullReferenceException(nameof(win));

        _windows.Add(win);
    }
}