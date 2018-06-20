using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLikeRPG
{/// <summary>
 /// Classe que representa as traps
 /// </summary>
 /// 
    class Trap : ISortable
    {
        public string Name { get; set; }
        public bool fallInto = false;
        public int Damage { get; set; } = 0;
        public int Id { get; set; } = 0;
        private int Multiplier;
        public int lvl;
        private char c;
        Random rnd = new Random(DateTime.Now.Millisecond);

        public Trap(int lvl, int id)
        {
            this.lvl = lvl;
            TrapType(id);
        }

        public int TAttack()
        {
            int attack = 0;

            if (!fallInto)
            {
                Multiplier = (int)(3 * (Math.Pow(lvl - 1, 0.5f)));
                attack = rnd.Next(0, Damage + Multiplier);
                if (attack > 100) attack = 100;
            }

            return attack;

        }

        public void TrapType(int id)
        {

            Id = id;
            switch (id)
            {

                case 1:
                    Name = "banana peel";

                    Damage = 5;
                    c = '^';
                    break;

                case 2:
                    Name = "spikes";
                    Damage = 10;
                    c = '^';
                    break;

                case 3:
                    Name = "poisoned spikes";

                    Damage = 20;
                    c = '^';
                    break;

                case 4:
                    Name = "Hellpit";

                    Damage = 50;
                    c = '^';
                    break;
            }
        }


        public char GetC()
        {
            return c;
        }

    }
}
