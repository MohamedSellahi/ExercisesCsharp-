using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer deux nombre entier");

            int nbElems = 0;  

            string[] Tockens = Console.ReadLine().Split();

            nbElems = Tockens.Count();
                        
            if (nbElems != 2)
            {
                Console.WriteLine("Nombre d'entier doit etre egale a 2"); 
            }
            else
            {
                int a = int.Parse(Tockens[0]); //  lire le premier entier 
                int b = int.Parse(Tockens[1]);

                if (a * b > 0)
                    Console.WriteLine("Le produit des deux entier est postif");
                else
                    Console.WriteLine("Le produit des deux entier est négatif");
            }       

        }
    }
}
