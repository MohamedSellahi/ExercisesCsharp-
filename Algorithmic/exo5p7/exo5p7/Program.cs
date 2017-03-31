using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5p8 {
  class Program {
    static void Main(string[] args) {
      int val, fact = 1;

      Console.WriteLine("Entrer une valeur: ");
      val = Convert.ToInt32(Console.ReadLine());
      int i = 1;

      if(val == 0) {
        fact = 1;
        Console.WriteLine("{0}! = {1}", val, fact);
      }
      else if(val < 0) {
        Console.WriteLine("valeur négative: error factorielle");
      }
      else {
        while(i < (val + 1)) {
          fact *= i;
          ++i;
        }
        Console.WriteLine("{0}! = {1}", val, fact);
      }




    }
  }
}
