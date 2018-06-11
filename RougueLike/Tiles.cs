using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    class Tiles
    {
        public int damage = 0;
        public int maxDamage = 99;
        string Name { get; set; } = "";
        bool visible = false;
        public Bag bag = new Bag();
        public int idTile = 0;

        public List<IAlive> stuffs;
        public Tiles(int id)
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
    }
}
