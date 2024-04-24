using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___Ejercicio_1
{
    public class Pistol : RangedWeapon
    {
        public Pistol()
        {
            Name = "Pistol";
            Damage = 25;
            AttackSpeed = 3.0f;
            Projectile = new Bullet(); 
            Price = 100;
        }
    }
}
