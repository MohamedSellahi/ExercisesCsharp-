using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg0
{

    class Program
    {
        static void Main(string[] args)
        {
            /* Variable */
            short nbC = 1; 
            int nbA = 7;
            int nbB = 3;
            int resultat = nbB + nbA;

            string msg1 = "je suis un ";
            string msg2 = "message";

            /* CONSTANTES */
            const double PI = 3.14;

            //nbA = nbB = resultat = 12;

            /* operations sur  des entiers */
            resultat = nbA + nbB;
            resultat = nbA - nbB;
            resultat = nbA * nbB;
            resultat = nbA / nbB;
            resultat = nbA % nbB;

            /* string concatenation */

            string resultMessage = msg1 + msg2 + ' '+ nbA;  // implicit conversion fro mint to char 

            Console.WriteLine("Nombre A vaut : {0}, nombre B vaut : {1}", nbA, nbB);
            Console.WriteLine("resultat vaut : {0}", resultat);
            Console.WriteLine("Le resultat vaut : {0}", resultMessage);

            /* Entrer une valeur */
            string userInput;
            Console.Write("Entrer un chiffre : ");
            userInput = Console.ReadLine();
            Console.WriteLine("Vous avez entré : {0}", userInput);
            int input = Convert.ToInt32(userInput);

            Console.WriteLine("input comme entier : {0}", input);
            
            /* */


        }
    }
}
