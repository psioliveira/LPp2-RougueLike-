using System;
using System.Collections;
using System.Collections.Generic;

namespace RougueLikeRPG
{
    class Tile
    {
        private bool visible = false;
        private int idTile = 0;
        private int lvl;
        private ArrayList stuffs = new ArrayList(5);
        Random rnd = new Random(DateTime.Now.Millisecond);

        public ArrayList Stuffs { get => stuffs; set => stuffs = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public int IdTile { get => idTile; set => idTile = value; }
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

                case 4: //player spawn

                    Visible = true;
                    break;

                default:
                    break;
            }
        }

        public int SortMobs()
        {

            int mobQnt = 0;
            int ofset = (20 + (lvl / 4));
            int chance = rnd.Next();
            int mobNumb = 0;
            foreach (ISortable s in Stuffs)
            {
                if (s is Mob) { mobNumb++; }
            }
            if ((chance % 100) <= ofset && mobNumb < 5)
            {
                
                int id = rnd.Next(1, 6);
                Mob mb = new Mob(lvl, id);
                stuffs.Add(mb as Mob);
                mobQnt++;
            }
            return mobQnt;
        }


        public int SortTraps()
        {

            int trapQnt = 0;
            int ofset = (20 + (lvl / 4));
            int chance = rnd.Next();
            int trapNumb = 0;

            foreach (Trap t in Stuffs) { trapNumb++; }
            if ((chance % 100) <= ofset && trapNumb < 2)
            {
                
                int id = rnd.Next(1, 4);
                Trap tp = new Trap(lvl, id);
                stuffs.Add(tp as Trap);
                trapQnt++;
            }
            return trapQnt;
        }
    }
}
