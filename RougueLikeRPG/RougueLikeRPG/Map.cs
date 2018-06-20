using System;
using System.Collections.Generic;
using System.Text;

namespace RougueLikeRPG
{
    /// <summary>
    /// Classe que representa o mapa 
    /// </summary>
    class Map : ISortable
    {
        private char c = 'M';

        public Map() { }

        public char GetC()
        {
            return c;
        }

    }
}
