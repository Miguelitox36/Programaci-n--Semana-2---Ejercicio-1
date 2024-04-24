using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Semana_2___Ejercicio_1
{
    public class Arrow : Projectile
    {
        public Arrow()
        {
            Damage = 10; 
            Price = 5; 
        }

        public int Price { get; set; }
    }
}
