using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetConsole
{
   public class MesMethodes
    {
        //une classe peut contenir 2 types de méthodes
        //Méthodes de classe -méthode static accéssible via la classe directement
        //méthode d'instance: pas de mot clé static -accéssibles via une instatnce de la classe (donc via un objet de la classe)

        /// <summary>
        /// Méthode calcule la somme de 2 entiers
        /// </summary>
        /// <param name="x">est un entier</param>
        /// <param name="y">est un entier</param>
        /// <returns>est un entier. somme de x + y</returns>
        public static int Somme(int x, int y)
        {
            return x + y;
        }
        //Surcharge (overlonad): le fait de pouvoir définir la meme méthode dans la meme classe avec uniquement la liste des paramétres qui change

        public static double Somme(double x, double y)
        {
            return x + y;
        }
        public static void Afficher()
        {
            Console.WriteLine("Méthode void sans type de retour.");
        }

        //méthode pour lister le contenu d'un tableau d'entiers

        public static void Afficher(int[] tab)
        {
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }
        //méthode qui renvoie la somme des elements d'un tableau d'entiers
        public static int Somme(int[] tab)
        {
            int som = 0;
            foreach (var item in tab)
            {
                som += item;
            }
            return som;
        }
        //méthode qui renvoie la moyenne des elements d'un tableau d'entiers

        public static double moy(int[] tab)
        {
            int som = 0;
            foreach (var item in tab)
            {
                som += item;
            }
            return som / tab.Length;
        }
        //méthode qui renvoie  l'elements le plus petit d'un tableau d'entiers
        public static int Minimum(int[] tab)
        {
            int min = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] <min)
                {
                    min = tab[i];
                }
            }
            return min;
        }
        //Paramétres optionnels d'une méthode
        //Se sont des paramétres qui possédent des valeurs par defaut

        public static int Sommeoptional(int x , int y , int z = 10)
        {
            return x + y + z;
        }
        //Méthode qui permute 2 entiers
        //ref: concerne que les types simples (types valeurs)
        public static void permute(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        //paramétres en sortie

        public static double Calculer(double x, double y , out double somme, out double moyenne)
        {
            moyenne = (x + y) / 2;
            somme = x + y;
            return x * y;

        }
        //nombre variable de paramétres d'une méthode
        //public static int Produit(int x, int y, int z)
        //{
        //    return x * y * z;
        //}

        //public static int Produit(int x, int y, int z , int a)
        //{
        //    return x * y * z * a;
        //}
        public static int Produit(params int[] tab)
        {
            int prod = 1;
            foreach (var item in tab)
            {
                prod  *= item;
            }
            return prod;
        }
    }
}
