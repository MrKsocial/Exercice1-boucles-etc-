using System;

namespace pythagore
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             Algo pythagore

            variables
                val1, val2, res: entier;
                choixUt: chaine;
            début
                
            ecrire ("Tapez 1 pour faire un calcul du théoreme de Pythagore.")
            ecrire ("Tapez 2 pour dire si votre triangle est rectangle.")

            lire(choixUt)

            selon   choix faire
                        1:

                        ecrire("calcul du théoreme:")
                        ecrire ("choisissez la valeur du premier coté:")
                        lire(val1)
                        ecrire("choisissez la valeur du deuxieme coté:")
                        lire(val2)
                        ecrire("resultat : ", val1*val1+val2*val2)
                        
                        2:

                        ecrire("triangle rectangle???????")
                        ecrire("choisissez la valeur du premier coté:")
                        lire(val1)
                        ecrire("choisissez la valeur du deuxieme coté:")
                        lire(val2)
                        ecrire("choisissez la valeur du troisieme coté:")
                        lire(val3)
                        si(al1*val1+val2*val2) = val3*val3 alors

                            ecrire"Votre triangle est rectangle")
                        sinon 
                            ecrire("Votre triangle est pas rectangle")
                        

            fin
             
             */
            int choixUt;
            double val1 = 0;
            double val2 = 0;
            double val3 = 0;
            
            Console.WriteLine("Tapez 1 pour faire un calcul du théoreme de Pythagore. Tapez 2 pour dire si votre triangle est rectangle.");

            choixUt = int.Parse(Console.ReadLine());

            switch (choixUt)
            {
                case 1:
                    Console.WriteLine("calcul du théoreme:");

                    

                    Console.WriteLine("choisissez la valeur du premier coté:");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("choisissez la valeur du deuxieme coté:");
                    val2 = double.Parse(Console.ReadLine());
                    val3 = Math.Sqrt(val1 * val1 + val2 * val2);



                    Console.WriteLine("Result = {0}", val3);
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("triangle rectangle???????");
            

                    Console.WriteLine("choisissez la valeur du premier coté:");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("choisissez la valeur du deuxieme coté:");
                    val2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("choisissez la valeur du troisieme coté:");
                    val3 = double.Parse(Console.ReadLine());
                    

                    if (val3 == Math.Sqrt(val1 * val1 + val2 * val2))
                    {
                        Console.WriteLine("Votre triangle est rectangle");
                    }
                    else if(val3 != Math.Sqrt(val1 * val1 + val2 * val2))
                    {
                        Console.WriteLine("Votre triangle est pas rectangle");
                    }

                    break;
                default:
                    break;
            }

          
            
        }
    }
}
