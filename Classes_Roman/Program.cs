using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Roman
{
    class Program
    {
        static void Main()
        {
            Player player1 = new Player(name: "Simon", hp: 1000000, lvl: 9999);
            Player player2 = new Player(name: "Michael Tweedale", hp: 1, lvl: 0);

            player2.TakeDamage(100);

        }
    }

    class Player
    {
        string _name;
        int _health;
        int _level;

        public Player(string name, int hp, int lvl)
        {
            _name = name;
            _health = hp;
            _level = lvl;
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
            if (_health < 0)
            {
                _health = 0;
            }
        }

        public void LevelUp()
        {
            _level++;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void PrintStats()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_health);
            Console.WriteLine(_level);
        }
    }
}
