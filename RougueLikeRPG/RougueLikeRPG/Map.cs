using System;
using System.Collections.Generic;
using System.Text;

namespace RougueLike
{
    class Map : IAmItem,ISortable
    {
        public float Weight { get; set; }
        private char c = 'M';
    }
}
