using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test00 {
  class Program {
    static void Main(string[] args) {

      int val;

      while(true) {
        Console.Write("Entrer valeur : ");
        val = Convert.ToInt32(Console.ReadLine());
        if(val == 0)
          break;
        else
          Console.WriteLine("val = {0}", val);
      }
    }
  }
}
