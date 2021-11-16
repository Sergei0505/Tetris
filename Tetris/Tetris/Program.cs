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

            Point p1 = new Point(2, 3,'*');
            p1.Draw();

            Point p2 = new Point()
            {
                x = 4,
                y = 6,
                c = '+'
            };
            p2.Draw();


            Console.ReadLine();
        }
    }
}
