using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    class Program
    {
        int lvl = 1;
        Player p = new Player();
        World world;
        bool alive;

        static void Main(string[] args)
        { 
            MainMenu();
            alive = Update(p);

        }

        bool Update(Player p)
        {

            if (p.HP > 0) return true;
            if (p.HP <= 0) return false;
            else return false;
        }

        void GenereateWorld()
        {
            world = new World(lvl);
        }


        
    }
}
