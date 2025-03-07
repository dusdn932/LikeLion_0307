using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Field
    {
        Player player = null;
        Monster monster = null;
        public void SetPlayer(ref Player player) { this.player = player; }
        public void Progress()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                player.Render();
                DrawMap();
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 4)
                    break;
                if (iInput <= 3)
                {
                    CreateMonster(iInput);
                    Fight();
                }
            }
        }
        public void Create(string _strName, int _iHealth, int _iAttack, out Monster monster)
        {
            monster = new Monster();
            INFO monster2 = new INFO();
            monster2.strName = _strName;
            monster2.iHealth = _iHealth;
            monster2.iAttack = _iAttack;
            monster.SetMonster(monster2);
        }
        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초보몹", 30, 3, out monster);
                    break;
                case 2:
                    Create("중급몹", 60, 6, out monster);
                    break;
                case 3:
                    Create("고급몹", 90, 9, out monster);
                    break;
            }
        }
        public void Fight()
        {
            int iInput = 0;
            while (true)
            {
                Console.Clear();
                player.Render();
                monster.Render();
                Console.WriteLine("1. 공격 2. 도망");
                iInput = int.Parse(Console.ReadLine());
                if(iInput == 1)
                {
                    player.SetDamage(monster.GetMonster().iAttack);
                    monster.SetDamage(player.GetInfo().iAttack);
                    if(player.GetInfo().iHealth <= 0)
                    {
                        player.SetUp(100);
                        break;
                    }
                }
                if(iInput ==2 || monster.GetMonster().iHealth <= 0)
                {
                    monster = null;
                    break;
                }
            }
        }
        public void DrawMap()
        {
            Console.Clear();
            player.Render();
            Console.WriteLine("1. 초보맵\n2. 중수맵\n3. 고수맵\n4. 전단계");
            Console.WriteLine("==========================");
            Console.WriteLine("맵을 선택하세요.");
        }
        public Field() { }
        ~Field() { }
    }
}
