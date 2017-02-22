using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo11p1 {
  class Program {
    static void Main(string[] args) {
      int x1 = 1, x2 = 2, x3 = 3, x4 = 4, x5 = 5;

      Console.WriteLine(Somme(x1, x2, x3, x4, x5));

    }


    static int Somme(int x1, int x2, int x3, int x4, int x5) {
      return x1 + x2 + x3 + x4 + x5; 
    }

  }
}
