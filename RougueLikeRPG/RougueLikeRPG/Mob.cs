﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RougueLike
{
    public class Mob : IAlive, ISortable
    {
        public string Name { get; set; }
        public int HP { get; set; } = 100;
        public int Damage { get; set; } = 0;
        public bool neutral = true;
        public int Id { get; set; } = 0;
        public Bag bag = new Bag();
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
                    bag.AddThing(new Consumable(6));
                    c = 'r';
                    break;

                case 2:
                    Name = "Goblin";
                    HP = 15;
                    Damage = 5;
                    neutral = true;
                    bag.AddThing(new Consumable(4));
                    c = 'G';
                    break;

                case 3:
                    Name = "Troll";
                    HP = 45;
                    Damage = 10;
                    neutral = false;
                    bag.AddThing(new Consumable(7));
                    c = 'T';
                    break;

                case 4:
                    Name = "Orc";
                    HP = 60;
                    Damage = 20;
                    neutral = false;
                    bag.AddThing(new Consumable(7));
                    bag.AddThing(new Weapon(0));
                    c = '$';
                    break;

                case 5:
                    Name = "Minotaur";
                    HP = 80;
                    Damage = 40;
                    neutral = false;
                    bag.AddThing(new Consumable(8));
                    bag.AddThing(new Weapon(6));
                    c = 'Y';
                    break;

                case 6:
                    Name = "Bunny of Doom";
                    HP = 120;
                    Damage = 45;
                    neutral = false;
                    bag.AddThing(new Consumable(8));
                    bag.AddThing(new Consumable(8));
                    bag.AddThing(new Weapon(4));
                    c = 'B';
                    break;
            }
        }


        public char GetC()
        {
            return c;
        }

    }
}
