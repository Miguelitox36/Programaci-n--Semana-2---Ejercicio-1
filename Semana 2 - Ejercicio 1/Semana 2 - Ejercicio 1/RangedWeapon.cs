using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___Ejercicio_1
{
    public class RangedWeapon : IWeapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public float AttackSpeed { get; set; }
        public Projectile Projectile { get; set; }

        public float DPS()
        {
            return (Damage + Projectile.Damage) * AttackSpeed;
        }
    }
}
