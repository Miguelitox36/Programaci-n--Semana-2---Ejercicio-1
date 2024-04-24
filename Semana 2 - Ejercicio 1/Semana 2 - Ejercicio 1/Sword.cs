using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___Ejercicio_1
{
    public class Sword : MeleeWeapon
    {
        public Sword()
        {
            Name = "Sword";
            Damage = 20;
            AttackSpeed = 1.5f;
            Price = 50;
        }
    }
}
