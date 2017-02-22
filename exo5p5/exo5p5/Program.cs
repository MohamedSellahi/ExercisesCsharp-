using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5p5 {
  class Program {
    static void Main(string[] args) {

      int val;
      Console.WriteLine("Entrer une nombre de départ");

      val = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Table de 7");
      int i = 1;
      while(i < 11) {
        Console.WriteLine("{0} x {1} = {2}", val, i, val*i);
        ++i;
      }


    }
  }
}
