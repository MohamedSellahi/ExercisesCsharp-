using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3p1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb = 1;
            string userInput; 
            
            while(true)
            {
                Console.WriteLine("Entrer un entier: ");
                userInput = Console.ReadLine();

                nb = Convert.ToInt32(userInput);

                if (nb > 0)
                    Console.WriteLine("{0} est un nombre positif", nb);
                else if (nb < 0)
                    Console.WriteLine("{0} est un nombre negatif", nb);
                else
                {
                    Console.WriteLine("fin de programme");
                    break;
                }
                 
            }
                       
        }
    }
}
