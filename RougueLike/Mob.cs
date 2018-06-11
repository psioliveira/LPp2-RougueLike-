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
        public int Damage { get; set; } = 0;
        public bool neutral = true;
        public int Id {get;set;}= 0;
        public Bag bag = new Bag();

        public Mob()
        {
            

        }

        int MobType()
        {
            Random rnd = new Random();
            int id = rnd.Next(1, 100);
            return id;
        }


    }
}
