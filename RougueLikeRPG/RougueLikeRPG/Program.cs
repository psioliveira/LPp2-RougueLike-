using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;


namespace RougueLikeRPG
{
    /// <summary>Classe na qual se encontra o corpo principal do jogo </summary>
    class Program
    {
        int lvl = 1;
        Player p = new Player();
        World world;
        bool alive = true;
        private Drawer drw = new Drawer();
        int mapTaken = 0;


        static void Main(string[] args)
        {
            Console.SetWindowSize(102, 35);
            Console.OutputEncoding = Encoding.UTF8;
            Program prog = new Program();
            prog.GenereateWorld();
            prog.MainMenu();


        }

        /// <summary>update do mundo </summary>
        bool Update(Player p)
        {
            drw.SetVisible(world);
            drw.DrawWorld(world);
            drw.DrawHud(p, world);

            drw.Menu(); //ingame menu
            Console.SetCursorPosition(82, 28);
            ConsoleKeyInfo key = Console.ReadKey();
            Selections(key, mapTaken);
            foreach (Tile t in world.Tworld)
            {
                if (t.IdTile == 1 && t.Stuffs.Contains(p as Player))
                {
                    lvl++;
                    GenereateWorld();
                }
            }
            p.HP -= DmgToPlayer();
            if (p.HP > 0) return true;
            if (p.HP <= 0) return false;
            else return false;
        }

        /// <summary>criação do mundo </summary>
        void GenereateWorld()
        {
            world = new World(lvl, p);
            mapTaken = 0;
            p.HP = 100;
        }

        /// <summary>possíveis seleções do player </summary>
        void Selections(ConsoleKeyInfo key, int map)
        {

            char sel = key.KeyChar;
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

                    break;

                case 'e':
                case 'E':

                    if (map == 0)
                    {
                        map = PickMap(world, map);
                    }
                    break;

                case 'u':
                case 'U':
                    break;

                case 'v':
                case 'V':
                    break;

                case 'i':
                case 'I':
                    Information(p);
                    break;

                case 'q':
                case 'Q':
                    Environment.Exit(0);
                    break;
            }
        }

        /// <summary>menu  inicial </summary>
        void MainMenu()
        {
            int sel;
            int flag = 1;
            do
            {
                Console.Clear();
                drw.MainMenu();
                sel = Convert.ToChar(Console.Read());

                switch (sel)
                {
                    case '1':
                        Console.Clear();
                        alive = true;
                        p.HP = 100;
                        world = new World(1, p);
                        while (alive == true)
                        {
                            alive = Update(p);
                        }
                        break;

                    case '2':
                        break;

                    case '3':
                        Console.Clear();
                        Credits();
                        break;

                    case '4':
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            } while (flag == 0 || sel != 4);


        }

        /// <summary>movimentações do player no mundo </summary>
        void MovWest(Player player)
        {
            int flag = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    foreach (ISortable a in world.Tworld[i, j].Stuffs)
                    {
                        if (a is Player && j > 0)
                        {
                            Player pl = (Player)a;
                            pl.HP -= 1;
                            world.Tworld[i, j].Stuffs.Remove(a);
                            world.Tworld[i, j - 1].Stuffs.Add(pl);
                            Console.SetCursorPosition(2, 27);
                            Console.Write("You moved WEST           " +
                                          "                       ");

                            flag = 1;
                        }

                        if (j <= 0)
                        {
                            Console.SetCursorPosition(2, 27);
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
                    foreach (ISortable a in world.Tworld[i, j].Stuffs)
                    {
                        if (a is Player && i < 7)
                        {
                            Player pl = (Player)a;
                            pl.HP -= 1;
                            world.Tworld[i, j].Stuffs.Remove(a);
                            world.Tworld[i + 1, j].Stuffs.Add(pl);
                            Console.SetCursorPosition(2, 27);
                            Console.Write("You moved SOUTH   ");
                            flag = 1;
                        }

                        if (i >= 7)
                        {
                            Console.SetCursorPosition(2, 27);
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
                    foreach (ISortable a in world.Tworld[i, j].Stuffs)
                    {
                        if (a is Player && j < 7)
                        {
                            Player pl = (Player)a;
                            pl.HP -= 1;
                            world.Tworld[i, j].Stuffs.Remove(a);
                            world.Tworld[i, j + 1].Stuffs.Add(pl);
                            Console.SetCursorPosition(2, 27);
                            Console.Write("You moved EAST   ");
                            flag = 1;
                        }

                        if (j >= 7)
                        {
                            Console.SetCursorPosition(2, 27);
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
                    foreach (ISortable a in world.Tworld[i, j].Stuffs)
                    {
                        if (a is Player && i > 0)
                        {
                            Player pl = (Player)a;
                            pl.HP -= 1;
                            world.Tworld[i, j].Stuffs.Remove(a);
                            world.Tworld[i - 1, j].Stuffs.Add(pl);
                            Console.SetCursorPosition(2, 27);
                            Console.Write("You moved NORTH   ");
                            flag = 1;
                        }

                        if (i <= 0)
                        {
                            Console.SetCursorPosition(2, 27);
                            Console.Write("invalid moviment   ");
                        }

                        if (flag == 1) break;
                    }
                    if (flag == 1) break;
                }
                if (flag == 1) break;

            }

        }

        /// <summary>Chama as informações do jogo </summary>
        void Information(Player player)
        {
            drw.Info(player);
            Console.ReadKey();

            drw.SetVisible(world);
            drw.DrawWorld(world);
            drw.DrawHud(p, world);
            Console.SetCursorPosition(82, 28);
            ConsoleKeyInfo key = Console.ReadKey();
            Selections(key, mapTaken);

        }
        /// <summary>Pegar o mapa do cenário </summary>
        int PickMap(World world, int map)
        {
            map = 1;
            foreach (Tile t in world.Tworld)
            {
                foreach (ISortable s in t.Stuffs)
                {
                    if (s is Player)
                    {
                        foreach (ISortable m in t.Stuffs)
                        {
                            if (m is Map)
                            {
                                drw.ShowWorld(world.Tworld);
                                Console.SetCursorPosition(2, 27);
                                Console.Write("you got a Map!");
                                map = 2;
                                t.Stuffs.Remove(m);
                                return map;
                            }
                        }
                    }
                }
            }
            return map;
        }
        /// <summary>Chama a tela de créditos </summary>
        void Credits()
        {
            drw.DrawCredits();

            Console.ReadKey();
            Console.Clear();
            MainMenu();

        }

        /// <summary>flag para retornar ao jogo </summary>
        void PlayGame(int flag)
        {
            flag = 1;
            Console.Clear();
        }

        /// <summary>ataque dos mobs e dano das traps ao jogador </summary>
        public int DmgToPlayer()
        {
            int TotalAtk = 0;
            foreach (Tile t in world.Tworld)
            {
                foreach (ISortable s in t.Stuffs)
                {
                    if (s is Player)
                    {
                        if (t.IdTile == 2)
                        {
                            foreach (ISortable m in t.Stuffs)
                            {
                                if (m is Mob)
                                {
                                    if (!(m as Mob).neutral)
                                    { TotalAtk += ((Mob)m).MAttack(); }

                                }

                                if (m is Trap)
                                {
                                    {
                                        TotalAtk += ((Trap)m).TAttack();
                                        ((Trap)m).fallInto = true;
                                    }

                                }
                            }
                        }
                    }
                }
            }

            return TotalAtk;

        }
    }
}
