using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo9p10 {
  class Program {
    static void Main(string[] args) {

      Console.Write("Entrer un nombre entier: ");
      int val = Convert.ToInt32(Console.ReadLine());

      if(val%2 == 0) {
        Console.WriteLine("{0} est pair.",val );
      }
      else {
        Console.WriteLine("{0} est unpair.", val);
      }


    }
  }
}
