using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RougueLikeRPG
{
    class Drawer
    {

        public Drawer()
        {

        }

        public void DrawWorld(World world)
        {
            ClearGameWindow();
            int xpos = 8, ypos = 8;
            for (int x = 0; x < xpos; x++)
            {
                for (int y = 0; y < ypos; y++)
                {
                    if ((world.Tworld)[x, y].Visible)
                    { //caso o tile seja visível

                        char[] c = new char[11] { '.', '.', '.', '.', '.',
                                                  '.', '.', '.', '.', '.','.' };

                        if ((world.Tworld)[x, y].IdTile == 1) //caso o tile seja a saída
                        {
                            c = new char[10]  { 'E', 'X', 'I', 'T', '!',
                                                'E', 'X', 'I', 'T', '!' };
                        }

                        if (world.Tworld[x, y].IdTile != 1)
                        { //caso o tile não seja a saída
                            int i = 0;

                            foreach (ISortable s in world.Tworld[x, y].Stuffs)
                            {
                                if (s is Player && i < 10) //se exixtir o player no tile
                                {
                                    world.Tworld[x, y].Visible = true;
                                    c[i] = ((Player)s).GetC();
                                    i++;
                                }
                                if (s is Mob && i < 10) //se exixtir um mob no tile
                                {

                                    c[i] = ((Mob)s).GetC();
                                    i++;
                                }
                                if (s is Trap && i < 10)  //se exixtir uma trap no tile
                                {

                                    c[i] = ((Trap)s).GetC();
                                    i++;
                                }
                                if (s is Bag && i < 10)  //se exixtir uma bag no tile
                                {

                                    c[i] = ((Mob)s).GetC();
                                    i++;
                                }

                                if (s is Map && i < 10) // se exixtir um mapa no tile
                                {

                                    c[i] = ((Map)s).GetC();
                                    i++;
                                }
                            }
                        }
                        PrintTile(c, y, x);
                    }

                    if ((world.Tworld)[x, y].IdTile == 1) //caso o tile seja a saída
                    {
                        char[] c = new char[10]  { 'E', 'X', 'I', 'T', '!',
                                                   'E', 'X', 'I', 'T', '!' };
                    }
                    if (!world.Tworld[x, y].Visible) // caso o tile não seja visível
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

        public void MainMenu()
        {
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("Rouguelike Game");

            Console.SetCursorPosition(40, 13);
            Console.WriteLine("1.  New Game");
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("2.  High Score");
            Console.SetCursorPosition(40, 17);
            Console.WriteLine("3.  Game Credits");
            Console.SetCursorPosition(40, 19);
            Console.WriteLine("4.  Quit");


        }

        public void DrawHud(Player player, World world)
        {
            DrawHead(world.Lvl);
            DrawBody();
            DrawFoot();
            PlayerStatus(player);
        }

        private void DrawHead(int lvl)
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
            Console.SetCursorPosition(42, 2);
            Console.Write("LVL " + lvl);
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

        public void FightMenu()
        {

            Console.SetCursorPosition(52, 24);
            Console.WriteLine("Attack:");

            Console.SetCursorPosition(52, 25);
            Console.WriteLine("1.spot 1");
            Console.SetCursorPosition(52, 26);
            Console.WriteLine("2.spot 2");
            Console.SetCursorPosition(52, 27);
            Console.WriteLine("3.spot 3");
            Console.SetCursorPosition(70, 25);
            Console.WriteLine("4.spot 4");
            Console.SetCursorPosition(70, 26);
            Console.WriteLine("5.spot 5");
            Console.SetCursorPosition(70, 27);
            Console.WriteLine("6.RETURN");

        }

        public void Menu()
        {

            Console.SetCursorPosition(52, 24);
            Console.WriteLine("W->North     ");
            Console.SetCursorPosition(52, 25);
            Console.WriteLine("S->South     ");
            Console.SetCursorPosition(52, 26);
            Console.WriteLine("A->West      ");
            Console.SetCursorPosition(52, 27);
            Console.WriteLine("D->East      ");
            Console.SetCursorPosition(65, 24);
            Console.WriteLine("F->Attack        ");
            Console.SetCursorPosition(65, 25);
            Console.WriteLine("E->Loot          ");
            Console.SetCursorPosition(65, 26);
            Console.WriteLine("U->Use/Equip     ");
            Console.SetCursorPosition(65, 27);
            Console.WriteLine("V->Drop                            ");
            Console.SetCursorPosition(82, 24);
            Console.WriteLine("I->Info           ");
            Console.SetCursorPosition(82, 25);
            Console.WriteLine("Q->Quit           ");


        }

        public void MobStatus(Mob mob)
        {
            Console.SetCursorPosition(73, 17);
            Console.WriteLine("Enemy:" + mob.Name);

            if (mob.neutral)
            {
                Console.SetCursorPosition(73, 18);
                Console.WriteLine("Type: neutral");
            }

            if (!mob.neutral)
            {
                Console.SetCursorPosition(73, 18);
                Console.WriteLine("Type: Agressive");
            }

            Console.SetCursorPosition(73, 19);
            Console.WriteLine("HP:" + mob.HP);
            Console.SetCursorPosition(73, 20);
            Console.WriteLine("lst ATK:");

        }

        public void PlayerStatus(Player player)
        {
            Console.SetCursorPosition(52, 17);
            Console.WriteLine("You:");

            Console.SetCursorPosition(52, 19);
            Console.WriteLine("HP:" + player.HP + "/100   ");
            Console.SetCursorPosition(52, 20);
            Console.WriteLine("Cap:" + player.bag.Weight + "/100   ");

        }

        public void SetVisible(World world)
        {
            Tile[,] tiles = world.Tworld;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    foreach (ISortable p in tiles[i, j].Stuffs)
                    {
                        if (p is Player)
                        {
                            foreach (ISortable m in tiles[i, j].Stuffs)
                                if (m is Map)
                                    ShowWorld(tiles);

                            if (i == 0)
                            {
                                if (j != 0 && j < 7)
                                {
                                    tiles[i, j].Visible = true;
                                    tiles[i, j + 1].Visible = true;
                                    tiles[i, j - 1].Visible = true;
                                    tiles[i + 1, j].Visible = true;
                                }

                                if (j == 0)
                                {
                                    tiles[i, j].Visible = true;
                                    tiles[i, j + 1].Visible = true;
                                    tiles[i + 1, j].Visible = true;
                                }
                                if (j == 7)
                                {
                                    tiles[i, j].Visible = true;
                                    tiles[i, j - 1].Visible = true;
                                    tiles[i + 1, j].Visible = true;
                                }
                            }

                            if (i > 0 && i < 7)
                            {
                                if (j != 0 && j < 7)
                                {
                                    tiles[i, j].Visible = true;
                                    tiles[i, j + 1].Visible = true;
                                    tiles[i, j - 1].Visible = true;

                                    tiles[i + 1, j].Visible = true;
                                    tiles[i - 1, j].Visible = true;
                                }

                                if (j == 0)
                                {
                                    tiles[i, j].Visible = true;
                                    tiles[i, j + 1].Visible = true;

                                    tiles[i + 1, j].Visible = true;
                                    tiles[i - 1, j].Visible = true;
                                }
                                if (j == 7)
                                {
                                    tiles[i, j].Visible = true;
                                    tiles[i, j - 1].Visible = true;

                                    tiles[i + 1, j].Visible = true;
                                    tiles[i - 1, j].Visible = true;
                                }
                            }

                            if (i == 7)
                            {
                                if (j != 0 && j < 7)
                                {
                                    tiles[i, j].Visible = true;
                                    tiles[i, j + 1].Visible = true;
                                    tiles[i, j - 1].Visible = true;

                                    tiles[i - 1, j].Visible = true;
                                }

                                if (j == 0)
                                {
                                    tiles[i, j].Visible = true;
                                    tiles[i, j + 1].Visible = true;

                                    tiles[i - 1, j].Visible = true;
                                }
                                if (j == 7)
                                {
                                    tiles[i, j].Visible = true;
                                    tiles[i, j - 1].Visible = true;

                                    tiles[i - 1, j].Visible = true;
                                }
                            }
                        }
                    }
                }
            }

        }

        private void ShowWorld(Tile[,] tiles)
        {
            foreach (Tile t in tiles)
            {
                t.Visible = true;
            }
        }

        public void DrawCredits()
        {
            Console.SetCursorPosition(46, 10);
            Console.WriteLine("Credits");

            Console.SetCursorPosition(43, 13);
            Console.WriteLine("Pedro Oliverira");
            Console.SetCursorPosition(44, 15);
            Console.WriteLine("Hugo Martins");


            Console.SetCursorPosition(38, 19);
            Console.WriteLine("press any key to go back");

        }

        public void Info(Player player)
        {
            ClearGameWindow();

            PrintConsumable();
            PrintWeapon();
        }
        public void ClearGameWindow()
        {
            for(int i = 3; i < 28; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("                         " +
                              "                        ");
            }
        }
        public void PrintConsumable()
        {
            Console.SetCursorPosition(2, 4);
            Console.Write("Info:");
            Console.SetCursorPosition(2, 6);
            Console.Write("consumable:");
            Console.SetCursorPosition(2, 6);
            Console.Write("consumable:");
            Console.SetCursorPosition(2, 7);
            Console.Write("cherry           +05 HP           01 WGT ");
            Console.SetCursorPosition(2, 8);
            Console.Write("Tomato           +09 HP           02 WGT ");
            Console.SetCursorPosition(2, 9);
            Console.Write("Bread            +10 HP           04 WGT");
            Console.SetCursorPosition(2, 10);
            Console.Write("Cheese           +14 HP           03 WGT");
            Console.SetCursorPosition(2, 11);
            Console.Write("Meat             +15 HP           10 WGT");
            Console.SetCursorPosition(2, 12);
            Console.Write("Fish             +20 HP           08 WGT");
            Console.SetCursorPosition(2, 13);
            Console.Write("Health Pot       +50 HP           13 WGT");
            Console.SetCursorPosition(2, 14);
            Console.Write("Strong Health Pot+80 HP           50 WGT");
        }
        public void PrintWeapon()
        {
            Console.SetCursorPosition(2, 17);
            Console.Write("Weapons:");
            Console.SetCursorPosition(2, 19);
            Console.Write("Club          08 DMG   0.3 DUR    34 WGT ");
            Console.SetCursorPosition(2, 20);
            Console.Write("Staff         10 DMG   0.4 DUR    20 WGT ");
            Console.SetCursorPosition(2, 21);
            Console.Write("Dagger        15 DMG   0.7 DUR    12 WGT ");
            Console.SetCursorPosition(2, 22);
            Console.Write("Sword         20 DMG   0.5 DUR    36 WGT ");
            Console.SetCursorPosition(2, 23);
            Console.Write("Katana        30 DMG   0.8 DUR    28 WGT ");
            Console.SetCursorPosition(2, 24);
            Console.Write("Broad sword   38 DMG   0.6 DUR    40 WGT ");
            Console.SetCursorPosition(2, 25);
            Console.Write("Excalibur     60 DMG   1.0 DUR    50 WGT ");
            Console.SetCursorPosition(3, 26);
            Console.Write("ANY KEY TO RETURN  ");

        }
    }
}
