using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    class Map : IAmItem,ISortable
    {
        public float Weight { get; set; }
        private char c = 'M';
    }
}
