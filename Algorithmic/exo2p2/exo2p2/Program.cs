/**
*  Programme que demande a un utulisateur de rentrer le prix HT, TVA et nombre d'article 
   puis affiche le cout total
*
*
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2p2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal prixHT, TVA;
            int nbArticles;
            string userInput; 

            /* lire le prix unitaire */
            Console.WriteLine("Entrer le prix unitaire HT");
            userInput = Console.ReadLine();
            prixHT = Convert.ToDecimal(userInput);

            /* lire le nombre */
            Console.WriteLine("Entrer le nombre d'article ");
            userInput = Console.ReadLine();
            nbArticles = Convert.ToInt32(userInput);

            /* lire le */
            Console.WriteLine("Entrer la valeur de la TVA en %");
            userInput = Console.ReadLine();
            TVA = Convert.ToDecimal(userInput);

            //Console.WriteLine("{0} {1} {2}", prixHT, TVA, nbArticles);
            Console.WriteLine("Total TTC : {0}", prixHT * (1 + TVA / 100)*nbArticles);
            Console.WriteLine("Dont TVA  : {0}", prixHT * (TVA / 100) * nbArticles);
        }
    }
}
