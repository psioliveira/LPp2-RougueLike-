using System;
using System.Collections.Generic;
using System.Text;

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
            
            Console.SetWindowSize(102, 35);
            Console.OutputEncoding = Encoding.UTF8;
            Program prog = new Program();
            prog.GenereateWorld();
            //prog.drw.MainMenu();

            while (prog.alive == true)
            {

                prog.alive = prog.Update(prog.p);

            }

        }

        bool Update(Player p)
        {
            drw.SetVisible(world.Tworld);
            drw.DrawWorld(world);
            drw.DrawHud();
            drw.Menu(); //ingame menu
            Console.SetCursorPosition(82, 28);
            char c = Convert.ToChar(Console.Read());

            Selections(c);

            if (p.HP > 0) return true;
            if (p.HP <= 0) return false;
            else return false;


        }

        void GenereateWorld()
        {
            world = new World(lvl,p);
        }

        void Selections(char sel)
        {
            switch (sel)
            {
                case 'a':
                case 'A':
                    MovWest(p);
                    break;

                case 's':
                case 'S':
                    MovSouth(p);
                    break;

                case 'd':
                case 'D':
                    MovEast(p);
                    break;

                case 'w':
                case 'W':
                    MovNorth(p);
                    break;

                case 'f':
                case 'F':
                 //   Fight(world);
                    break;

                case 'e':
                case 'E':
                    //PickLoot(world);
                    break;

                case 'u':
                case 'U':
                   // UseItem(p);
                    break;

                case 'v':
                case 'V':
                   // DropItem(p, world);
                    break;

                case 'i':
                case 'I':
                   // Information(p);
                    break;

                case 'q':
                case 'Q':
                  //  QuitGame();
                    break;

            }
        }

        void MovWest(Player player)
        {
            int flag = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    foreach (IAlive a in world.Tworld[i, j].Stuffs)
                    {
                        if (a is Player && j > 0)
                        {
                            Player pl = (Player)a;
                            pl.HP -= 1;
                            world.Tworld[i, j].Stuffs.Remove(a);
                            world.Tworld[i, j - 1].Stuffs.Add(pl);
                            Console.SetCursorPosition(52, 3);
                            Console.Write("You moved WEST    ");

                            flag = 1;
                        }

                        if (j <= 0)
                        {
                            Console.SetCursorPosition(52, 3);
                            Console.Write("invalid moviment     ");
                        }

                        if (flag == 1) break;
                    }
                    if (flag == 1) break;
                }
                if (flag == 1) break;

            }
        }
        void MovSouth(Player player)
        {
            int flag = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    foreach (IAlive a in world.Tworld[i, j].Stuffs)
                    {
                        if (a is Player && i < 7)
                        {
                            Player pl = (Player)a;
                            pl.HP -= 1;
                            world.Tworld[i, j].Stuffs.Remove(a);
                            world.Tworld[i + 1, j].Stuffs.Add(pl);
                            Console.SetCursorPosition(52, 3);
                            Console.Write("You moved SOUTH   ");
                            flag = 1;
                        }

                        if (i >= 7)
                        {
                            Console.SetCursorPosition(52, 3);
                            Console.Write("invalid moviment   ");
                        }

                        if (flag == 1) break;
                    }
                    if (flag == 1) break;
                }
                if (flag == 1) break;

            }
        }
        void MovEast(Player player)
        {
            int flag = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    foreach (IAlive a in world.Tworld[i, j].Stuffs)
                    {
                        if (a is Player && j < 7)
                        {
                            Player pl = (Player)a;
                            pl.HP -= 1;
                            world.Tworld[i, j].Stuffs.Remove(a);
                            world.Tworld[i, j + 1].Stuffs.Add(pl);
                            Console.SetCursorPosition(52, 3);
                            Console.Write("You moved EAST   ");
                            flag = 1;
                        }

                        if (j >= 7)
                        {
                            Console.SetCursorPosition(52, 3);
                            Console.Write("invalid moviment   ");
                        }

                        if (flag == 1) break;
                    }
                    if (flag == 1) break;
                }
                if (flag == 1) break;

            }
        }
        void MovNorth(Player player)
        {
            int flag = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    foreach (IAlive a in world.Tworld[i, j].Stuffs)
                    {
                        if (a is Player && i > 0)
                        {
                            Player pl = (Player)a;
                            pl.HP -= 1;
                            world.Tworld[i, j].Stuffs.Remove(a);
                            world.Tworld[i - 1, j].Stuffs.Add(pl);
                            Console.SetCursorPosition(52, 3);
                            Console.Write("You moved NORTH   ");
                            flag = 1;
                        }

                        if (i <= 0)
                        {
                            Console.SetCursorPosition(52, 3);
                            Console.Write("invalid moviment   ");
                        }

                        if (flag == 1) break;
                    }
                    if (flag == 1) break;
                }
                if (flag == 1) break;

            }

        }

        void Fight(World world)
        {
            drw.FightMenu();
            int sel = Convert.ToInt32(Console.Read());
            foreach (Tile t in world.Tworld)
            {
                if (t.Stuffs.Contains(p))
                {
                    if(t.Stuffs[sel-1] is Mob)
                    {
                        drw.MobStatus(t.Stuffs[sel] as Mob);
                    }
                    else
                    {
                        Console.SetCursorPosition(52, 3);
                        Console.Write("Choose one valid number between 1-5");
                    }

                }
            }


        }

    }
}
