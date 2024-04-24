using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___Ejercicio_1
{
    public class Bullet : Projectile
    {
        public Bullet() 
        {
            Damage = 15; 
            Price = 3;
        }

        public int Price { get; set; }
    }
}
