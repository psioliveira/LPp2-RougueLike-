﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    class Mob : IAlive, IStuffs
    {
        public string Name { get; set; }
        public int HP { get; set; } = 100;
        public int Damage { get; set; } = 0;
        public Bag bag = new Bag();
        private int MaxWeight { get; set; } = 300;
        public float Weight { get; set; } = 0;
        public bool neutral = true;

        public int[] posInMap;


    }
}
