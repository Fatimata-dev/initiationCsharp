
using ProjetDLL;
using System;
using System.Runtime.InteropServices;

namespace projetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test en c#");
            Tools.MaMethode();

            #region Variables

            // Variable: zone memoire qui contient une valeur typée
            //Types simples (types valeur): entiers, réels, bool char
            //Types complèxes (types réferences): tableau, string, dates, classes (objets)

            //entiers: byte(1 octet), short(2 o), int(4 o), long(8 o)
            //réels: float(4 o), double(8 o), decimal(16 o)

            //déclaration d'une variable: type nom_variable = valeur

            int myInt = 10;
            Console.WriteLine("Contenu de myInt: " + myInt);

            double myDouble = 10.5;
            char myChar = 'b';
            bool myBool = true;
            string maChaine = "b";

            var myVariable = 10.5;

            //Types nullables : .net propose une syntase qui permet de définir des types simples null
            int?x = null;
            //Avant utilisation de x on doit vérifier qu'elle contient un valeur
            if (x.HasValue)
            {
                Console.WriteLine("X est null");
            }
            else
            {
                Console.WriteLine("X est null");
            }

            string str = null;

            int age = 0;
            Console.WriteLine("Quel est votre age : ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Votre age est :" + age);

            #endregion
            #region Opérateurs
            //Opération mathématique: +, -, *, / %(modulo)
            Console.WriteLine("Reste de la division 10 par 3 : " + (10 % 3));

            //opérateur combinés: +=, -=, *=, /=
            myInt += 5; // myInt + 5
            //Opérateurs d'incrémentation et de décrémentation
            int val = 0;
            Console.WriteLine("pré incrementation: " + (++val)); //incrémente val ensuite utilise sa valeur
            Console.WriteLine("post incrémentation: " + (val++)); //utilise val ensuite l'incrémente de 1
            Console.WriteLine(++val + val++); //6
            Console.WriteLine(6 + "5" + 2); //652
            Console.WriteLine(6 + 2 + "5");//85
            Console.WriteLine("6" + 5 + 2); //652

            //Opération de comparaison: ==, <, > <=, >=, !=
            //Opération logique: &&, ||, ! ^(exclusif)



            #endregion

            #region Coversion
            //Conversion implicite : concerne le passage d'un tupe inférieur à un type supérieur
            byte myByte = 10;
            int myInt3 = myByte;

            // Conversion explicite: passage d'un type sup à un tupe inf
            //Pour les conversion explicites on peut utiliser:
            //CAST: (int), (byte), (double)
            int myInt4 = 20;
            byte myByte2 = (byte)myInt4;
            byte myByte3 = Convert.ToByte(myInt4);

            string chaine = "25";
            int myInt5 = Convert.ToInt32(chaine);int myUInt6 = int.Parse(chaine);
            #endregion;

            #region Conditions

            //Exprimer un test conditionnel: if(condition == vaire){instuction}else{insturction}

            int nb = 5;
            if (nb > 0)
            {
                Console.WriteLine("nb est positif");
            }
            else if(nb == 0)
            {
                Console.WriteLine("nb est null");
            }
            else
            {
                Console.WriteLine("nb est négatif");
            }

            //Switch: est une variante de la fondition if

            int note = 10;
                switch (note)
            {
                case 0: Console.WriteLine("recalé");
                    break;
                case 10:
                case 11:
                case 12:
                default:
                    break;
            }

            #endregion

            #region Boucles

            //Boucles conditionnelles : while , do while
            //Boucle  itératives: for foreach

            //for
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine("Passage n°: "+i);
                if (i == 6 )
                {
                    break;
                }
            }
            //foreach
            int[] tab = { 1, 2, 3, };
            foreach (int item in tab)
            {
                Console.WriteLine( item);
            }
            int valeur = 1;

            //while
            while (valeur < 5) //tant que
            {
                Console.WriteLine("Passage n° : "+valeur);
                valeur++;
            }
            //Do while
            do
            {
                Console.WriteLine("Passage n° :"+valeur);
            } while (valeur < 1);
            #endregion
            #region Tableau
            //Tableau : un ensemble d'élement typés

            //1dimension

            //Déclaration d'un tableau
            int[] tableau = new int[3]; //tableau de cases
            tableau[0] = 10;
            tableau[1] = 20;
            tableau[2] = 30;
            Console.WriteLine("Taille du tableau :"+tableau.Length);

            //Parcours du tableau avec la boucle foreach

            foreach (int item in tableau)
            {
                Console.WriteLine(item);
            }
            //Parcours du tableau avec la boucle for
            for (int i = 0; i < tableau.Length ; i++)
            {
                Console.WriteLine(tableau[i]);
            }

            //2éme façon de déclarer un tableau
            int[] tableau2 = { 10, 20, 30 }; 

            //2 dimesions
            int[,] martrice = new int[2, 3];
            martrice[0, 0] = 10;
            martrice[0, 1] = 20;
            martrice[0, 2] = 30;
            martrice[1, 0] = 40;
            martrice[1, 2] = 50;
           

            int[,] martrice2 = { { 10, 15, 18 }, { 12, 25, 32 } }; // une autre façon de déclarer un tableau à 2 dimensions

            Console.WriteLine("nombre de lignes de la matrice2: "+ martrice2.GetLength(0));//2
            Console.WriteLine("nombre de colones de la matrice2: "+ martrice2.GetLength(1));//3
            Console.WriteLine("nombre de d'élements de la matrice2: "+ martrice2.Length);//6
            Console.WriteLine("nombre de dimensioins de la matrice2: "+ martrice2.Rank);//2

            #endregion

            Console.WriteLine("***************************Méthodes*********************************");
            #region Méthhodes

            //Méthodes: un ensemble d'instructions réutilisables
            //Dans la programation ibjet on a 2 types de méthodes:
            //Procédures: méthode qui ne renvoie aucune valeur (void)
            //Fonctions: méthode qui renvoie un résultats -on doit préciser le type du résultat renvoyé
            //Déclaration d'une méthode: Visibilté [mot-clé-static] type_retour nom_Methode(paramétres){instructions;}

            int resultats = MesMethodes.Somme(10, 15);
            Console.WriteLine(resultats);

            MesMethodes.Afficher();

            int[] monTableau = { 10, 0, 25, 15 };

            MesMethodes.Afficher(monTableau);

            Console.WriteLine("Somme:  "+MesMethodes.Somme(monTableau));
            Console.WriteLine("moyenne:  " + MesMethodes.moy(monTableau));
            Console.WriteLine("Le plus petit:  " + MesMethodes.Minimum(monTableau));

            //Appel de la méthode avec des params optionnels
            MesMethodes.Sommeoptional(10 , 25); //valeur de z qui est prise en compte
            MesMethodes.Sommeoptional(15 , 25, 65);

            int val1 = 10, val2 = 30;
            //Interpollation
            Console.WriteLine($"Avant permutation: val1 = {val1} -val2 = {val2}");

            MesMethodes.permute(ref val2, ref val1);

            Console.WriteLine($"Aprés permutaion: val1 = {val1} -val2 = {val2}");

            //Appel de méthode avec des paramétres en sortie

            double sum = 0, moy = 0;
            double produit = MesMethodes.Calculer(10, 25 ,out sum, out moy);
            Console.WriteLine($"Produit: {produit}");
            Console.WriteLine($"somme: {sum}");
            Console.WriteLine($"moenne: {moy}");

            //Appel de la méthode avec nombre de variable d'arguments
            MesMethodes.Produit(10, 10);
            MesMethodes.Produit(20, 5, 25);
            MesMethodes.Produit(3, 10, 9, 12);


            #endregion


            //Maintenir la console active
            Console.ReadLine();
        }
    }
}
