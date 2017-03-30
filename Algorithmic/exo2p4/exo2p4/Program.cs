using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2p4
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg0 = "belle marquise",
                   msg1 = "vos beaux yeux",
                   msg2 = "me font",
                   msg3 = "mourir d'amour";
            Console.WriteLine("{0} {1} {2} {3} \n", msg0, msg1, msg2, msg3);
       
            Console.WriteLine("{0} {2} {1} {3} \n", msg0, msg1, msg2, msg3);
            Console.WriteLine("{0} {1} {3} {2} \n", msg0, msg1, msg2, msg3);
            Console.WriteLine("{3} {1} {2} {0} \n", msg0, msg1, msg2, msg3);

        }
    }
}
