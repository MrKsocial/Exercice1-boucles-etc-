using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int A; //int A,B;
            //int B;

            //Console.WriteLine("Entrez la valeur de A:");
            //A = Convert.ToInt32(Console.ReadLine()); //int.Parse()

            //B = 2 * A;

            //Console.WriteLine("Le double de la valeur de "+A+" est : "+B+".");





            /*int C; //creer variable  Variable C

            Console.WriteLine("Entrer un nombre entier :"); // ecrire ("Entrer un nombre entier :")
            C = int.Parse(Console.ReadLine());//lire(C)

            if (C % 3 == 0)//condition si variable C est divisible C %3
            {
                Console.WriteLine("Votre nombre " + C + " est divisible par 3.");// Ecrire ("Votre nombre " + C + " est divisible par 3.")
            }
            else
            {
                Console.WriteLine("Votre nombre " + C + " n'est pas divisible par 3.");

            }
            */




            /*
             Algorithme divisible_par_3

            variable 
                C : entier

            Début
            

            ecrire ("Entrer un nombre entier :")
            lire(C)

            si  C %3=0 alors
                écrire ("Votre nombre " + C + " est divisible par 3.")
            sinon 
                écrire("Votre nombre " + C + " n'est pas divisible par 3.")

            FinSi

            fin

             
             */

            /* 
              Algorithme choix_Uti_Pc

            variable

                entier choixUt

            Debut
            ecrire ("Tapez 1 pour redémarrer le pc. Tapez 2 pour l'arrêter ou Tapez 3 pour le démarrer")

            selon   choix égale 1
                        ecrire("PC redémarre")
                    choix égale 2
                        ecrire("PC s'arrête")
                    choix égale 3
                        ecrire("PC démarre")
                    choix par défaut("mauvais choix")
            fin selon

            Fin

            */

            int choixUt;

            Console.WriteLine("Tapez 1 pour redémarrer le pc. Tapez 2 pour l'arrêter ou Tapez 3 pour le démarrer");

            choixUt=int.Parse(Console.ReadLine());

            switch (choixUt)
            {
                case 1:
                    Console.WriteLine("Pc redémarre");
                    break;

                case 2:
                    Console.WriteLine("Pc s'arrête");
                    break;

                case 3:
                    Console.WriteLine("Pc mettre en veille.");
                    break;
                default:
                    Console.WriteLine("Mauvais choix");
                    break;

            }
        }
    }
}
