using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    public class Mob : IAlive
    {
        public string Name { get; set; }
        public int HP { get; set; } = 100;
        public int Damage { get; set; } = 0;
        public bool neutral = true;
        public int Id { get; set; } = 0;
        public Bag bag = new Bag();

        public Mob()
        {
            MobType();
        }

        public void MobType()
        {
            int id = MobID();
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
                    bag.AddThing(new Consumable(6));
                    break;

                case 2:
                    Name = "Goblin";
                    HP = 15;
                    Damage = 5;
                    neutral = true;
                    bag.AddThing(new Consumable(4));
                    break;

                case 3:
                    Name = "Troll";
                    HP = 45;
                    Damage = 10;
                    neutral = false;
                    bag.AddThing(new Consumable(7));
                    break;

                case 4:
                    Name = "Orc";
                    HP = 60;
                    Damage = 20;
                    neutral = false;
                    bag.AddThing(new Consumable(7));
                    bag.AddThing(new Weapon(0));
                    break;

                case 5:
                    Name = "Minotaur";
                    HP = 80;
                    Damage = 40;
                    neutral = false;
                    bag.AddThing(new Consumable(8));
                    bag.AddThing(new Weapon(6));
                    break;

                case 6:
                    Name = "Bunny of Doom";
                    HP = 120;
                    Damage = 45;
                    neutral = false;
                    bag.AddThing(new Consumable(8));
                    bag.AddThing(new Consumable(8));
                    bag.AddThing(new Weapon(4));
                    break;
            }
        }

        public int MobID()
        {
            Random rnd = new Random();
            int id = rnd.Next(1, 5);
            return id;
        }


    }
}
