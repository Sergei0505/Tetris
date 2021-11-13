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

            int x1 = 2;
            int y1 = 3;
            char c1 = '*';

            Draw(x1, y1, c1);

            Console.ReadLine();
        }
        
        static void Draw(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
