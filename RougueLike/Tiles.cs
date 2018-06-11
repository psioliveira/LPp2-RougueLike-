using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

<<<<<<< HEAD
        public List<IAlive> stuffs;
        public Tiles(int id)
=======
        public List<IStuffs> stuffs;
        public Tile(int id)
>>>>>>> 0e405b0b6c2f7afa32614d235373ac9d90235ae2
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
