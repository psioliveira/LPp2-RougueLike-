using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    class Menu
    {
        int selection = 0;
        public Menu()
        {
            selection = Convert.ToInt32(Console.ReadLine());

            if (selection == 1) { NewGame(); }
            if (selection == 2) { HighScores(); }
            if (selection == 3) { Credits(); }
            if (selection == 4) { QuitGame(); }


        }

        public void NewGame()
        {

        }
        public void HighScores()
        {

        }
        public void Credits()
        {

        }
        public void QuitGame()
        {

        }


    }
}
