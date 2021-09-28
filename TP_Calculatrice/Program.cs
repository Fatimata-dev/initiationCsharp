using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string choix = "";
            double valeur1 = 0, valeur2 = 0;
            Console.WriteLine("************************Calculatrice console***************************");
            Console.WriteLine("-Choisir une operation:");
            Console.WriteLine("-Addition : tapez a");
            Console.WriteLine("-Soustraction: tapez s");
            Console.WriteLine("-Multiplication: tapez m");
            Console.WriteLine("-Division: tapez d ");

            do
            {
                Console.WriteLine("faites votre choix : ");
                choix = Console.ReadLine();
            } while (!(choix == "a" || choix == "s" || choix == "m" || choix == "d"));

            Console.WriteLine("choisisez une valeur 1:");
            valeur1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("choisisez une valeur 2:");
            valeur2 = Convert.ToDouble(Console.ReadLine());
            switch (choix)
            {
                case "a":
                    Console.WriteLine("Addition "+ (valeur1 + valeur2));
                    break;
                case "s":
                    Console.WriteLine("Soustraction " + (valeur1 - valeur2));
                    break;
                case "m":
                    Console.WriteLine("multiplication " + (valeur1 * valeur2));
                    break;
                case "d":
                    Console.WriteLine("Division " + (valeur1 / valeur2));
                    break;
                default:
                    break;
            }

            do
            {
                Console.WriteLine("Quel est votre age:");
                int ageUser = Convert.ToInt32(Console.ReadLine());
                if (ageUser >= 18 && ageUser <= 60) 
                {
                    break;
                }
            } while (true);

            Console.ReadLine();
        }
    }
}
