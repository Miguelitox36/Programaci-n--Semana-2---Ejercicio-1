using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___Ejercicio_1
{
    public interface IWeapon
    {
        string Name { get; }
        int Damage { get; }
        float AttackSpeed { get; }
        float DPS();
    }
}
