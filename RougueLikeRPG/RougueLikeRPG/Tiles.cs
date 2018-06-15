using System;
using System.Collections;
using System.Collections.Generic;

namespace RougueLike
{
    class Tile
    {
        public int damage = 0;
        private int maxDamage = 99;
        private bool visible = false;
        private Bag bag = new Bag();
        private int idTile = 0;
        private int lvl;
        private ArrayList stuffs = new ArrayList(5);
        Random rnd = new Random(DateTime.Now.Millisecond);

        public ArrayList Stuffs { get => stuffs; set => stuffs = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public int IdTile { get => idTile; set => idTile = value; }
        public Bag Bag { get => bag; set => bag = value; }
        public bool Visible { get => visible; set => visible = value; }


        public Tile(int id, int lvl)
        {
            Lvl = lvl;
            TileType(id);
            IdTile = id;

        }

        public void TileType(int id)
        {

            Lvl = lvl;
            switch (id)
            {
                case 1: // exit

                    Visible = true;
                    stuffs = new ArrayList(1);
                    break;

                case 2: //grass

                    Lvl = lvl;
                    break;

                case 3: //trap

                    Lvl = lvl;
                    rnd = new Random(DateTime.Now.Millisecond);
                    damage = rnd.Next(0, maxDamage);
                    stuffs = new ArrayList(1);
                    break;

                case 4: //player spawn

                    Visible = true;
                    break;

                default:
                    break;
            }
        }

        public int SortMobs()
        {
            int flag = 0;
            int mobQnt = 0;
            while (flag < 5)
            {
                flag++;
                int chance = rnd.Next();
                if ((chance % 100) <= (20 + (lvl / 4)))
                {

                    rnd = new Random(DateTime.Now.Millisecond);
                    int id = rnd.Next(1, 6);
                    Mob mb = new Mob(lvl, id);
                    stuffs.Add(mb as Mob);
                    mobQnt++;
                }
                
            }

            return mobQnt;
        }
    }
}
