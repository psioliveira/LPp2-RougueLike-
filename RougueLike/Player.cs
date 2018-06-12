using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    class Player : IAlive
    {
        public string Name { get; set; }
        public int HP { get; set; } = 100;
        public Weapon EqWpn { get; set; } = null;
        public Bag bag = new Bag();
        private int MaxWeight { get; set; } = 300;

        public int[] posInMap;
        public Player()
        {

        }
        public int Attack(Weapon Wpn)
        {
            Random rnd = new Random();
            int damage = rnd.Next(0, Wpn.Damage);
            return damage;

        }

       
    }
}
