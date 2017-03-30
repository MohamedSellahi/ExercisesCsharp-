using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3p3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enterer trois nom");
            string[] Tockens = Console.ReadLine().Split();

            int nElems = Tockens.Count();
            if (nElems != 3)
            {
                Console.WriteLine(" nombre d'entrer doit etre egale à 3");
            }
            else
            {
                if((String.Compare(Tockens[0], Tockens[1], true) <= 0) & (String.Compare(Tockens[1], Tockens[2], true) <= 0))
                {
                    Console.WriteLine("Les nom sont rentré dans l'ordre");
                }
                else 
                {
                    Console.WriteLine("les noms ne som pas entrés en l'ordre");
                    Console.WriteLine("dans l'ordre");
                    Array.Sort(Tockens);
                    for (int i = 0; i < nElems; i++)
                    {
                        Console.WriteLine(Tockens[i]); 
                    }
                }

            }
        }
    }
}
