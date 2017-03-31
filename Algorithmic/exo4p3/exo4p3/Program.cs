using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4p3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours, minutes, seconds;

            Console.WriteLine("Entré leur actual");
            string[] Tokens = Console.ReadLine().Split();

            if (Tokens.Count() != 3)
            {
                Console.WriteLine("Entrée non valid");
                System.Environment.Exit(1);
            }

            /* recupérer les minute est les heurs */
            hours = int.Parse(Tokens[0]);
            minutes = int.Parse(Tokens[1]);
            seconds = int.Parse(Tokens[2]);

            if (hours > 23 | minutes > 59 | seconds > 59)
            {
                Console.WriteLine("Entrée non valid");
                System.Environment.Exit(1);
            }

            /* on peut verifier que les valuers des minutes sont < 60, et les hours < 24 */

            seconds++; 
            if(seconds > 59)
            {
                seconds -= 60;
                minutes++;
            }
            if (minutes > 59)
            {
                minutes -= 60;
                hours++;
            }
            if (hours > 23)
            {
                hours -= 24;
            }
            Console.WriteLine("Dans une second, il sera {0} heure(s), {1} minutes et {2} seconds", hours, minutes, seconds);
        }
    }
}
