using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    class Tiles
    {
        string Name { get; set; } = "";
        bool visible = false;
        public Bag bag = new Bag();
        public int idTile = 0;

        public List<IStuffs> stuffs;
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
                    break;

                default:
                    break;
            }
        }
    }
}
