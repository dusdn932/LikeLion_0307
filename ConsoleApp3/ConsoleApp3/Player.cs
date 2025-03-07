using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Player
    {
        public INFO p_info;
        public void SetDamage(int iAttack) { p_info.iHealth -= iAttack; }
        public INFO GetInfo() { return p_info; }
        public void SetUp(int iHealth) { p_info.iHealth = iHealth; }

        public void SelectJob()
        {
            p_info = new INFO();
            Console.WriteLine("직업을 선택하세요 (1. 전사 2. 마법사 3. 도적)");
            int iInput = 0;
            iInput = int.Parse(Console.ReadLine());
            switch (iInput)
            {
                case 1:
                    p_info.strName = "전사";
                    p_info.iHealth = 100;
                    p_info.iAttack = 10;
                    break;
                case 2:
                    p_info.strName = "마법사";
                    p_info.iHealth = 80;
                    p_info.iAttack = 15;
                    break;
                case 3:
                    p_info.strName = "도적";
                    p_info.iHealth = 90;
                    p_info.iAttack = 13;
                    break;
            }
        }
        public void Render()
        {
            Console.WriteLine("======================");
            Console.WriteLine($"직업 이름 :  {p_info.strName}");
            Console.WriteLine($"체력 : {p_info.iHealth}\t공격력 : {p_info.iAttack}");
        }
        public Player() { }
        ~Player() { }
    }
}

