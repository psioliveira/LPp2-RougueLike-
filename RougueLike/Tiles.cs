using System;
using System.Collections.Generic;

namespace RougueLike
{
    class Tile  
    {
        public int damage = 0;
        public int maxDamage = 99;
        string Name { get; set; } = "";
        bool visible = false;
        public Bag bag = new Bag();
        public int idTile = 0;

        public List<IamItem> stuffs;
        public Tile(int id)
        {
            TileType(id);
            idTile = id;
        }

        public void TileType(int id)
        {
            switch (id)
            {
                case 1:
                    Name = "Exit";
                    visible = true;
                    break;

                case 2:
                    Name = "Grass";
                    SortMobs();
                    break;

                case 3:
                    Name = "Trap";
                    Random rnd = new Random();
                    damage = rnd.Next(0, this.maxDamage);
                    break;

                default:
                    break;
            }
        }

        void SortMobs()
        {
            int MaxMobs = 5;
            for(int i =0; i < MaxMobs; i++)
            {

            }
        }
    }
}
