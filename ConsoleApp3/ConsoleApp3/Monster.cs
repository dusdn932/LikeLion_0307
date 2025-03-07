using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Monster
    {
        public INFO monster;
        public void SetDamage(int iAttack) { monster.iHealth -= iAttack; }
        public void SetMonster(INFO monster) { this.monster = monster; }
        public INFO GetMonster() { return monster; }
         
        public void Render()
        {
            Console.WriteLine("========================");
            Console.WriteLine($"몬스터 이름 : {monster.strName}");
            Console.WriteLine($"체력 : {monster.iHealth}\t 공격력 : {monster.iAttack}");

        }
        public Monster() { }
        ~Monster() { }
    }
}
