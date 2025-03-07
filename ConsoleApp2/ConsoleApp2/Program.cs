using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        [DllImport("msvcrt.dll")]
        public static extern int _getch();
        
        private static void SetCursorPosition(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        private static void ConfigureConsole()
        {
            const int WINDOW_WIDTH = 80;
            const int WINDOW_HEIGHT = 25;

            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);
        }

        static void Main(string[] args)
        {
            ConfigureConsole();

            var gameManager = new GameManager();
            gameManager.Initialize();

            const int FRAME_DELAY_MS = 50;
            var lastFrameTime = Environment.TickCount;

            while (true)
            {
                var currentTime = Environment.TickCount;
                if (currentTime - lastFrameTime >= FRAME_DELAY_MS)
                {
                    lastFrameTime = currentTime;
                    gameManager.Progress();
                    gameManager.Render();
                }
            }
        }
    }
}