using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5p2 {
  class Program {
    static void Main(string[] args) {

      int valeur = 0;

      do {
        Console.WriteLine("Entrer une valeur entre 10 et 20");

        valeur = Convert.ToInt32(Console.ReadLine());
        
        if(valeur != 0) {
          if(valeur < 10) {
            Console.WriteLine("Plus grand");
          }else if(valeur > 20) {
            Console.WriteLine("Plus petit!");
          }
          else {
            Console.WriteLine("Bon!");
          }
        }

      } while(valeur!= 0);

    }
  }
}
