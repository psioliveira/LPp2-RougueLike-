﻿using System;
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
                    if ((world.GetWorld())[x, y].visible)
                    {
                        char[] c = new char[10] { '.', '.', '.', '.', '.',
                                                  '.', '.', '.', '.', '.' };
                        int i = 0;

                        foreach (ISortable s in (world.GetWorld())[x, y].stuffs)
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

                        PrintTile(c, y, x);
                    }
                    if (!(world.GetWorld())[x, y].visible)
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
            int xOfset = x * 6;
            int yOfset = 2 + (y * 3);
            string s1 = new string(c, 0, 5);
            string s2 = new string(c, 5, 5);

            Console.SetCursorPosition(x + xOfset, y + yOfset);
            Console.WriteLine(s1 + ' ');
            Console.SetCursorPosition(x + xOfset, y + yOfset + 1);
            Console.WriteLine(s2 + ' ');
        }

        public void DrawMenu()
        {

            int x = 102, y = 35;
            Console.SetWindowSize(x, y);
            /**
            
            Console.SetCursorPosition(40,10);
            Console.WriteLine("Rouguelike Game");
            Console.SetCursorPosition(44,13);
            Console.WriteLine("New Game");
            Console.SetCursorPosition(43, 15);
            Console.WriteLine("High Score");
            Console.SetCursorPosition(42, 17);
            Console.WriteLine("Game Credits");
            Console.SetCursorPosition(46, 19);
            Console.WriteLine("Quit");
            **/
            DrawHead();
            DrawBody();

        }

        public void DrawHead()
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
        public void DrawBody()
        {
            int x = 0;
            int y = 3;

            //verticais maiores
            for (int j = y; j < 28; j++)
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

            Console.SetCursorPosition(52, 15);
            Console.Write("----------------------------++------------------");
            Console.SetCursorPosition(52, 16);
            Console.Write("-MENU--------------++---------------------------");

            /*
            Console.SetCursorPosition(51, 15);
            Console.Write("----------------------------++------------------+");
            Console.SetCursorPosition(51, 16);
            Console.Write("------------------------------------------------+");
            */
        }

        public void Chart()
        {
            Console.SetCursorPosition(82, 4);
            Console.Write("☿-PLAYER");
            Console.SetCursorPosition(82, 5);
            Console.Write("Ѡ-RABBIT");
            Console.SetCursorPosition(82, 6);
            Console.Write("ສ-GOBLIN");
            Console.SetCursorPosition(82, 7);
            Console.Write("ߧ-TROLL");
            Console.SetCursorPosition(82, 8);
            Console.Write("४-ORC");
            Console.SetCursorPosition(82, 9);
            Console.Write("Փ-MINOTAUR");
            Console.SetCursorPosition(82, 10);
            Console.Write("Ѱ-BUNNY OF DOOM");
            Console.SetCursorPosition(82, 11);
            Console.Write("ტ-LOOT");
            Console.SetCursorPosition(82, 12);
            Console.Write("ם-MAP");
            Console.SetCursorPosition(82, 13);
            Console.Write(".-GRASS");
            Console.SetCursorPosition(82, 14);
            Console.Write("^-TRAP");

        }




    }
}