using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Semana_2___Ejercicio_1
{
    public class Bow : RangedWeapon
    {
        public Bow()
        {
            Name = "Bow";
            Damage = 15;
            AttackSpeed = 2.0f;
            Projectile = new Arrow(); 
            Price = 80; 
        }
    }
}
