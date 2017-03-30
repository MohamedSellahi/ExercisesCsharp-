using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3p6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer votre age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("entré non valide"); 
            }

            if (age >= 6 & age <= 7)
            {
                Console.WriteLine("\"Poussin\" de 6 à 7 ans");
            }
            else if (age >=8 & age <=9 )
            {
                Console.WriteLine("\"Pupille\" de 8 à 9");
            }
            else if (age >= 10 & age <= 11)
            {
                Console.WriteLine("\"Minime\" de 10 à 11 ans");
            }
            else if (age >= 12)
            {
                Console.WriteLine("\"Cadet\" après 12");
            }               
        }
    }
}
