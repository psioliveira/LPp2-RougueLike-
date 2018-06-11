using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    class Mob : IAlive
    {
        public string Name { get; set; }
        public int HP { get; set; } = 100;
        public int damage { get; set; } = 0;
        public Bag bag = new Bag();
        private int MaxWeight { get; set; } = 300;
        public int[] posInMap;


    }
}
