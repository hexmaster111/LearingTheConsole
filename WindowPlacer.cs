namespace LearningTheConsoleUi;

public static class WindowPlacer
{
    public struct WindowPlacement
    {
        public int X;
        public int Y;
    }

    private static WindowPlacement LastPos = new()
    {
        X = 0,
        Y = 0
    };
    
    public static WindowPlacement NewLocation()
    {
        LastPos.X += 2;
        LastPos.Y += 2;
        
        if(LastPos.X > Console.WindowWidth - 5)
        {
            LastPos.X = 0;
        }
        
        if(LastPos.Y > Console.WindowHeight - 5)
        {
            LastPos.Y = 0;
        }
        
        return LastPos;
    }
}