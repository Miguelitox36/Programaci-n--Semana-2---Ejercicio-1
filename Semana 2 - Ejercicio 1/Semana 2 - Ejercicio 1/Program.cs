using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            InventorySystem inventory = new InventorySystem();

            while (true)
            {
                Console.WriteLine("1. Add weapon");
                Console.WriteLine("2. Show inventory");
                Console.WriteLine("3. Remove weapon from inventory");
                Console.WriteLine("4. Exit");

                Console.Write("Select an option: ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    if (int.TryParse(input, out int option))
                    {
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Add weapon:");
                                Console.Write("Weapon Type (Melee/Ranged): ");
                                string weaponType = Console.ReadLine();

                                switch (weaponType.ToLower())
                                {
                                    case "melee":
                                        Console.Write("Name: ");
                                        string meleeName = Console.ReadLine();
                                        Console.Write("Damage: ");
                                        int meleeDamage;
                                        if (int.TryParse(Console.ReadLine(), out meleeDamage))
                                        {
                                            Console.Write("Attack speed: ");
                                            float meleeAttackSpeed;
                                            if (float.TryParse(Console.ReadLine(), out meleeAttackSpeed))
                                            {
                                                MeleeWeapon meleeWeapon = new MeleeWeapon
                                                {
                                                    Name = meleeName,
                                                    Damage = meleeDamage,
                                                    AttackSpeed = meleeAttackSpeed
                                                };
                                                inventory.AddWeapon(meleeWeapon);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid attack speed. Please enter a valid number.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid damage. Please enter a valid number.");
                                        }
                                        break;
                                    case "ranged":
                                        Console.Write("Name: ");
                                        string rangedName = Console.ReadLine();
                                        Console.Write("Damage: ");
                                        int rangedDamage;
                                        if (int.TryParse(Console.ReadLine(), out rangedDamage))
                                        {
                                            Console.Write("Attack speed: ");
                                            float rangedAttackSpeed;
                                            if (float.TryParse(Console.ReadLine(), out rangedAttackSpeed))
                                            {
                                                Console.Write("Proje|ctile damage: ");
                                                int projectileDamage;
                                                if (int.TryParse(Console.ReadLine(), out projectileDamage))
                                                {
                                                    RangedWeapon rangedWeapon = new RangedWeapon
                                                    {
                                                        Name = rangedName,
                                                        Damage = rangedDamage,
                                                        AttackSpeed = rangedAttackSpeed,
                                                        Projectile = new Bullet { Damage = projectileDamage }
                                                    };
                                                    inventory.AddWeapon(rangedWeapon);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid projectile damage. Please enter a valid number.");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid attack speed. Please enter a valid number.");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid damage. Please enter a valid number.");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Invalid weapon type.");
                                        break;
                                }
                                break;
                            case 2:
                                inventory.ShowInventory();
                                break;
                            case 3:
                                Console.Write("Enter the index of the weapon you want to delete: ");
                                int index;
                                if (int.TryParse(Console.ReadLine(), out index))
                                {
                                    inventory.RemoveWeapon(index);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid index. Please enter a valid number.");
                                }
                                break;
                            case 4:
                                Console.WriteLine("Exiting the program.");
                                return;
                            default:
                                Console.WriteLine("Invalid option.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please enter a valid number.");
                    }
                }
                else
                {
                    Console.WriteLine("Input is null or empty. Please enter a valid option.");
                }
            }
        }
    }
}