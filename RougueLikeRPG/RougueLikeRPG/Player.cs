using System;
using System.Collections.Generic;
using System.Text;

namespace RougueLikeRPG
{
    /// <summary>Classe responsável por criar o player </summary>
    class Player : IAlive, ISortable
    {
        public string Name { get; set; }
        public int HP { get; set; } = 100;
        public Weapon EqWpn { get; set; } = null;
        public Bag bag = new Bag();
        public int MaxWeight { get; } = 200;
        private char c = 'P';
        public Player()
        {

        }
        /// <summary>metodo que retorna o dano do player </summary>
        public int Attack(Weapon Wpn)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int damage = rnd.Next(0, Wpn.Damage);
            return damage;

        }
        /// <summary>retorna caractere que representa o player </summary>
        public char GetC()
        {
            return c;
        }



    }
}
