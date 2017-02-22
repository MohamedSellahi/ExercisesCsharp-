using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4p5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entrer votre age, sex (h/f): ");
            string ageStr = Console.ReadLine();
            string sex = Console.ReadLine();
            decimal age = Convert.ToDecimal(ageStr); 
            /* code pour valider les entrées */

            if(sex == "h")
            {
                if(age > 20)
                {
                    Console.WriteLine("Vous payez l'impot");
                }
                else
                {
                    Console.WriteLine("Vous ne payez pas d'impot");
                }
            }
            else
            {
                if((age > 18) && (age < 35))
                {
                    Console.WriteLine("Vous payez l'impot");
                }
                else
                {
                    Console.WriteLine("Vous n epayez pas d'impot");
                }
            }
        }
    }
}
