using System;
using System.Collections.Generic;
using System.Text;

namespace RougueLikeRPG
{
    public class Mob : IAlive, ISortable
    {
        public string Name { get; set; }
        public int HP { get; set; } = 100;
        public int Damage { get; set; } = 0;
        public bool neutral = true;
        public int Id { get; set; } = 0;
        private int Multiplier;
        public int lvl;
        private char c ;

        public Mob(int lvl,int id)
        {
            this.lvl = lvl;
            MobType(id);
        }

        public int MAttack()
        {
            Random rnd = new Random();
            Multiplier = (int) (3 * (Math.Pow(lvl - 1, 0.5f))) ;
            int attack = rnd.Next(0, Damage + Multiplier);
            return attack;
            
        }

        public void MobType(int id)
        {
            
            Id = id;
            switch (id)
            {
                case 0:
                    Name = "empty";
                    HP = 0;
                    break;

                case 1:
                    Name = "Rabbit";
                    HP = 2;
                    Damage = 0;
                    neutral = true;
                    c = 'a';
                    break;

                case 2:
                    Name = "Goblin";
                    HP = 15;
                    Damage = 5;
                    neutral = true;
                    c = 'b';
                    break;

                case 3:
                    Name = "Troll";
                    HP = 45;
                    Damage = 10;
                    neutral = false;
                    c = 'c';
                    break;

                case 4:
                    Name = "Orc";
                    HP = 60;
                    Damage = 20;
                    neutral = false;
                    c = 'd';
                    break;

                case 5:
                    Name = "Minotaur";
                    HP = 80;
                    Damage = 40;
                    neutral = false;
                    c = 'e';
                    break;
            }
        }


        public char GetC()
        {
            return c;
        }

    }
}
