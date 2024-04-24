using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___Ejercicio_1
{
    public class InventorySystem
    {
        private List<IWeapon> weapons = new List<IWeapon>();

        public void AddWeapon(IWeapon weapon)
        {
            weapons.Add(weapon);
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventary:");
            foreach (var weapon in weapons)
            {
                Console.WriteLine($"Name: {weapon.Name}, DPS: {weapon.DPS()}");
            }
        }

        public void RemoveWeapon(int index)
        {
            if (index >= 0 && index < weapons.Count)
            {
                weapons.RemoveAt(index);
                Console.WriteLine("Weapon removed from inventory.");
            }
            else
            {
                Console.WriteLine("Invalid weapon index.");
            }
        }
    }
}
