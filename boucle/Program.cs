using System;

namespace boucle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int somme = i;

            while (somme <= 100)
            {

                i = i + 1;
                somme = somme + i;
            }

            Console.WriteLine("La valeur cherchée est N= '" + i + "'.");
            /*
                        int NB, Div;
                        for(NB=1; NB<=100;NB++)
                        {
                            Console.WriteLine(NB);
                        }


            */

            int nombre, diviseur;
            for (nombre = 1; nombre <= 100; nombre++) //boucle de 1 à 100
            {
                for (diviseur = 2; diviseur <= nombre; diviseur++)
                {
                    if ((nombre % diviseur) == 0) //ici on teste la limite du modulo, dès qu'on atteind 0 c'est que ça ne sert a rien d'incrémenter encore le diviseur.
                        break;          //Exemple avec nombre =5 et diviseur = 2 -> modulo = 1 (c'est le reste) alors on incrémente, 5 modulo 3  -> 2, 5 modulo 4 -> 1 et donc 5 modulo 5 -> 0 là on break.
                }
                //une fois la limite du diviseur donné avec la boucle juste au dessus on peut faire la suite.
                if (diviseur > (nombre / diviseur)) // Ici on a vu au dessus que tant que le modulo n'est pas à 0 on continue a incrémenté notre diviseur pour atteindre 0.
                                                    // Donc toujours avec 5 comme nombre on sait que notre diviseur est aller jusqu'à 5. Ici on vérifie (5 > (5/5)) donc 5 > 1 on entre dans la condition. Donc c'est un nombre premier
                    Console.WriteLine("{0} est un nombre premier.", nombre);
            }
            //Console.ReadLine();

            /*
             algorithme liste nombre premier de 1 à 100


            Variables

            nombrePremier, diviseur : entier

            Début
            nombrePremier <-1
            Pour nombrePremier <=100
                nombrePremier = nombrePremier+1
                pour diviseur <=nombrePremier
                    si nombrePremier modulo du diviseur = 0 alors
                        break; arrêter
                    FinSi

                si diviseur > nombrePremier/diviseur
                    ecrire(nombrePremier +" est un nombre premier")
                finSi
            Fin



int nb = 1;

while (nb <= 100)
{

    int x = 2;
    bool entier = true;
    while (x <= nb / 2)
    {
        if ((nb % x) == 0)
        {
            entier = false;
        }
        x++;
    }
    if (entier == true)
    {
        Console.WriteLine("{0} est un nombre premier", nb);

    }
    nb++;
}


            int num, verif;

            for (num = 1; num <= 100; num++)
            {
                verif = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        verif++;
                        break;
                    }
                }

                if (verif == 0 && num != 1)
                    Console.Write("{0} ", num);
                    
            }
            
            Console.WriteLine("  ");
*/
            int NbreNote;
            int note;
            
            Console.WriteLine("Combien de note?");
            NbreNote = int.Parse(Console.ReadLine());
            int[] notes = new int[NbreNote];

            for(i=0; i< notes.Length; i++)
            {
                Console.WriteLine("Ecrivez une note.");
                note = int.Parse(Console.ReadLine());

                notes[i]=note;
            }
            Console.WriteLine("Voici les notes");
            Console.Write(string.Join(" ", notes));


            
            double sommeTableau = 0;
            foreach (int x in notes)
            {
                sommeTableau += x;
            }

            double moyenne = sommeTableau / notes.Length;
            Console.WriteLine(" \n Moyenne des notes: {0}", moyenne);



            double[] notes2 = new double[5];
            int cpt;
            double moyenne2, total = 0;
            Console.WriteLine("Veuillez entrer les notes.");
            for (cpt = 0; cpt < 5; cpt++)
            {
                Console.WriteLine("Note " + (cpt + 1));
                notes2[cpt] = Convert.ToDouble(Console.ReadLine());
                total += notes2[cpt];
            }
            moyenne2 = total / notes2.Length;
            Console.WriteLine("La moyenne est de " + moyenne2 + ".");
        }
    }
}
