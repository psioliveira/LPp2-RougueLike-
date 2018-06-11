using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    interface IAlive
    {
        string name { get; set; }
        int HP { get; set; }
        void Die();
        void Attack();

    }
}
