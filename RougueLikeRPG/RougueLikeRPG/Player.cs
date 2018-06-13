using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    class Player : IAlive, ISortable
    {
        public string Name { get; set; }
        public int HP { get; set; } = 100;
        public Weapon EqWpn { get; set; } = null;
        public Bag bag = new Bag();
        private int MaxWeight { get; } = 300;
        private char c = 'ߐ';

        public int[] posInMap = new int[2] { 0, 0 };
        public Player()
        {

        }
        public int Attack(Weapon Wpn)
        {
            Random rnd = new Random();
            int damage = rnd.Next(0, Wpn.Damage);
            return damage;

        }
        public char GetC()
        {
            return c;
        }



    }
}
