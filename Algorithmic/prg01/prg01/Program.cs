using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg01
{
    class Program
    {
        static void Main(string[] args)
        {
            int entier = 8;
            int chiffre = 9;

            /***** SWITCH *******/
            /* toujour mettre break in C# */
           
            switch (entier)
            {
                case 1:
                    Console.WriteLine("vaut 1");
                    break;
                case 2:
                    Console.WriteLine("vaut 2");
                    break;
                default:
                    break;
            }

            char caractere = 'A';
            switch (caractere)
            {
                case 'a':
                    Console.WriteLine(" vaut a");
                    break;
                case 'A':
                    Console.WriteLine("vaut A");
                    break;
                default:
                    break;
            }

            string chaine1 = "aaaaa";
            string chaine2 = "aaaaabb";
            string chaine3 = "ccc";

            Console.WriteLine(string.Compare(chaine1, chaine2));

            string menu = "a";
            entier = 0;

            while (menu != "q")
            {
                menu = Console.ReadLine();
                while(entier < 10)
                {
                    entier++;
                    Console.WriteLine(entier);
                }
            }

            /* DO WHILE */

            menu = "q";
            entier = 0;
            do
            {
                menu = Console.ReadLine();
                entier++;
            } while (menu != "q");

            /* FOR */
            string chaine4 = "dsqfkjhslkdjhfqslkhlksqdhfksqljdhgsqd"; 
            for (int i = 0; i < chaine4.Length; i++)
            {
                Console.WriteLine(i);
                for (int j = 0; j < 18; j++)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
