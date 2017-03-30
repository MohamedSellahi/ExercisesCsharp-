using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4p2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours, minutes;
            
            Console.WriteLine("Entré leur actual");
            string[] Tokens = Console.ReadLine().Split();

            if(Tokens.Count() != 2)
            {
                Console.WriteLine("Entrée non valid");
                System.Environment.Exit(1); 
            }

            /* recupérer les minute est les heurs */
            hours = int.Parse(Tokens[0]);
            minutes = int.Parse(Tokens[1]);

            if(hours > 23 | minutes > 59)
            {
                Console.WriteLine("Entrée non valid");
                System.Environment.Exit(1);
            }
            
            /* on peut verifier que les valuers des minutes sont < 60, et les hours < 24 */

            minutes++;
            if(minutes > 59)
            {
                minutes -= 60;
                hours++;
            }
            if (hours >23)
            {
                hours -= 24;
            }
            Console.WriteLine("Dans une minute, il sera {0} heure(s) et {1} minutes", hours, minutes);
        }
    }
}
