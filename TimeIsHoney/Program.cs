using System;

namespace TimeIsHoney
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new TIHGame())
                game.Run();
        }
    }
}
