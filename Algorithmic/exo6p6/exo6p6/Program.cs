using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6p6 {
  class Program {
    static void Main(string[] args) {
      int taille = 7;
      int[] suite = new int[taille];

      suite[0] = 0;
      suite[1] = 1;
      int i;
      for(i = 2; i < suite.Length; i++) {
        suite[i] = suite[i - 1] + suite[i - 2];
      }

      i = 0;
      foreach(var item in suite) {
        Console.WriteLine("Element #{0} : {1}", i, item);
        ++i;
      }
    }
  }
}
