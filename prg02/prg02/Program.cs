using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = { 1, 2, 3 };
            string[] noms = { "foo", "bar", "baz" };

            for (int i = 0; i < noms.Length ; i++)
            {
                Console.Write(points[0]);
                Console.Write(" ");
                Console.WriteLine(noms[i]);
            }

            /* alternative: for each */

            foreach (var item in noms)
            {
                Console.WriteLine(item);
            }

            /* Dynamic arrays */

            int taille = 5;

            int[] entries = new int[taille];

            for (int i = 0; i < entries.Length; i++)
            {
                entries[i] = i;
                Console.WriteLine(entries[i]); 
            }
        }
    }
}
