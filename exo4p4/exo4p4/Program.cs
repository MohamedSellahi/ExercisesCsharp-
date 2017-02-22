using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4p4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ncopies, leftCopies;
            double coutTotal = 0;
            
            Console.WriteLine("Entrer le nombre des copies: ");
            /* TODO : s'assuer que le nombre st valide */
            string inputStr = Console.ReadLine();
            leftCopies = Ncopies = int.Parse(inputStr);
         

            if(leftCopies > 20)
            {
                coutTotal = (leftCopies - 20) *0.08 + coutTotal;
                leftCopies = 20;
            }
            if(leftCopies > 10)
            {
                coutTotal = (leftCopies - 10) * 0.09 + coutTotal;
                leftCopies = 10;
            }
            coutTotal = leftCopies * 0.10 + coutTotal;

            Console.WriteLine("photocopies effectué : {0}", Ncopies);
            Console.WriteLine("Cout total : {0}", coutTotal);
        }
    }
}
