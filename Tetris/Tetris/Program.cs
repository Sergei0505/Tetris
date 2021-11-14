using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            const int widthConsole = 40;
            const int heightConsole = 30;
            Console.SetWindowSize(widthConsole, heightConsole);
            Console.SetBufferSize(widthConsole, heightConsole);

            Point p1 = new Point();
            p1.x = 2;
            p1.y = 3;
            p1.c = '*';
            p1.Draw();

            Console.ReadLine();
        }
    }
}
