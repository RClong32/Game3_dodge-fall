using System;

namespace TheCave
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Cave())
                game.Run();
        }
    }
}