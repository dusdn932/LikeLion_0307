using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class MainGame
    {
        public Player player = null;
        public Field field = null;
        public void Initalize()
        {
            player = new Player();
            player.SelectJob();
        }
        public void Progress()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                player.Render();
                Console.WriteLine("1. 사냥터 2. 종료");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 2)
                    break;
                if(iInput == 1)
                {
                    if(field == null)
                    {
                        field = new Field();
                        field.SetPlayer(ref player);
                    }
                    field.Progress();
                }
            }
        }
        public MainGame() { }
        ~MainGame() { }
    }
}
