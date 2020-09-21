using System;

namespace boucle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            int somme=i;

            while(somme<=100)
            {

                i = i + 1;
                somme = somme + i;
            }

            Console.WriteLine("La valeur cherchée est N= '" + i + "'.");

            int nombrePremier, j;
            for (nombrePremier = 1; nombrePremier <+ 100; nombrePremier++)
            {
                for (j = 2; j <= (nombrePremier / j); j++)
                    if ((nombrePremier % j) == 0) 
                        break;

                if (j > (nombrePremier / j))
                    Console.WriteLine("{0} est un nombre premier", nombrePremier);
            }
            Console.ReadLine();
        }
    }
}
