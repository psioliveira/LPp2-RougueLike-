using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    class Drawer
    {

        public Drawer()
        {

        }

        public void DrawWorld(World world)
        {

            int xpos = 8, ypos = 8;
            for (int x = 0; x < xpos; x++)
            {
                for (int y = 0; y < ypos; y++)
                {
                    if ((world.GetWorld())[x, y].Visible)
                    {
                        char[] c = new char[10] { '.', '.', '.', '.', '.',
                                                  '.', '.', '.', '.', '.' };
                        if ((world.GetWorld())[x, y].IdTile == 1)
                        {
                            c = new char[10] { 'E', 'X', 'I', 'T', '!',
                                               'E', 'X', 'I', 'T', '!' };
                        }
                        else
                        {
                            int i = 0;

                            foreach (ISortable s in (world.GetWorld())[x, y].Stuffs)
                            {
                                if (s is Player)
                                {

                                    c[i] = ((Player)s).GetC();
                                    i++;
                                }
                                if (s is Mob)
                                {

                                    c[i] = ((Mob)s).GetC();
                                    i++;
                                }
                                if (s is Bag)
                                {

                                    c[i] = ((Mob)s).GetC();
                                    i++;
                                }
                            }
                        }
                        PrintTile(c, y, x);
                    }
                    if (!(world.GetWorld())[x, y].Visible)
                    {
                        char[] c = new char[10] { '*', '*', '*', '*', '*',
                                                  '*', '*', '*', '*', '*' };
                        PrintTile(c, y, x);
                    }

                }
            }
        }

        void PrintTile(char[] c, int x, int y)
        {
            int xOfset = 2 + (x * 5);
            int yOfset = 4 + (y * 2);
            string s1 = new string(c, 0, 5);
            string s2 = new string(c, 5, 5);

            Console.SetCursorPosition(x + xOfset, y + yOfset);
            Console.Write(s1);
            Console.SetCursorPosition(x + xOfset, y + yOfset + 1);
            Console.Write(s2);
        }

        public void DrawMenu()
        {

            int x = 102, y = 35;
            Console.SetWindowSize(x, y);
            
            Console.SetCursorPosition(40,10);
            Console.WriteLine("Rouguelike Game");

            Console.SetCursorPosition(42,13);
            Console.WriteLine("1.New Game");
            Console.SetCursorPosition(41, 15);
            Console.WriteLine("2.High Score");
            Console.SetCursorPosition(40, 17);
            Console.WriteLine("3.Game Credits");
            Console.SetCursorPosition(44, 19);
            Console.WriteLine("4.Quit");
            

        }

        public void DrawHud()
        {
            DrawHead();
            DrawBody();
            DrawFoot();
        }

        private void DrawHead()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("|*******************************************");
            Console.Write(" Rougue Like ");
            Console.Write("*******************************************|");
            Console.SetCursorPosition(0, 1);
            Console.Write("|*******************************************");
            Console.Write("**** RPG ****");
            Console.Write("*******************************************|");
            Console.SetCursorPosition(0, 2);
            Console.Write("+-GAME--------------------------------------------+" +
                           "+-STATUS---------------------++-WORLD------------+");
        }
        private void DrawFoot()
        {
            Console.SetCursorPosition(0, 29);
            Console.Write("+--------------------------------------------------" +
                           "-------------------------------------------------+");
        }
        private void DrawBody()
        {
            int x = 0;
            int y = 3;

            //verticais maiores
            for (int j = y; j < 29; j++)
            {
                Console.SetCursorPosition(0, j);
                Console.Write("|");
                Console.SetCursorPosition(50, j);
                Console.Write("|");
                Console.SetCursorPosition(51, j);
                Console.Write("|");
                Console.SetCursorPosition(100, j);
                Console.Write("|");

            }

            x = 71;
            y = 17;

            //vertical menor
            for (int i = x; i < 73; i++)
            {
                for (int j = y; j < 22; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write("|");

                }
            }

            x = 80;
            y = 3;


            //vertical media
            for (int i = x; i < 82; i++)
            {
                for (int j = y; j < 15; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write("|");
                }
            }

            Chart();

            //horizontal menor1
            Console.SetCursorPosition(52, 15);
            Console.Write("----------------------------++------------------");
            Console.SetCursorPosition(52, 16);
            Console.Write("-MENU--------------++---------------------------");

            //horizontal menor2
            Console.SetCursorPosition(51, 22);
            Console.Write("----------------------------++------------------+");
            Console.SetCursorPosition(51, 23);
            Console.Write("-SELECTION--------------------------------------+");

        }
        private void Chart()
        {
            Console.SetCursorPosition(82, 4);
            Console.Write("P-PLAYER");
            Console.SetCursorPosition(82, 5);
            Console.Write("r-RABBIT");
            Console.SetCursorPosition(82, 6);
            Console.Write("G-GOBLIN");
            Console.SetCursorPosition(82, 7);
            Console.Write("T-TROLL");
            Console.SetCursorPosition(82, 8);
            Console.Write("O-ORC");
            Console.SetCursorPosition(82, 9);
            Console.Write("Y-MINOTAUR");
            Console.SetCursorPosition(82, 10);
            Console.Write("B-BUNNY OF DOOM");
            Console.SetCursorPosition(82, 11);
            Console.Write("&-LOOT");
            Console.SetCursorPosition(82, 12);
            Console.Write("M-MAP");
            Console.SetCursorPosition(82, 13);
            Console.Write(".-GRASS");
            Console.SetCursorPosition(82, 14);
            Console.Write("^-TRAP");

        }




    }
}
