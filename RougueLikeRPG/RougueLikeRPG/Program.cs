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
        bool alive = true;
        private Drawer drw = new Drawer();



        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Program prog = new Program();
            prog.GenereateWorld();
            prog.drw.DrawMenu();

            while (prog.alive == true)
            {

                prog.alive = prog.Update(prog.p);

            }

        }

        bool Update(Player p)
        {
            drw.DrawWorld(world);

            char c = Convert.ToChar(Console.ReadKey());

            Selections(c);

            if (p.HP > 0) return true;
            if (p.HP <= 0) return false;
            else return false;


        }

        void GenereateWorld()
        {
            world = new World(lvl);
        }

        void Selections(char sel)
        {

        }


    }
}
