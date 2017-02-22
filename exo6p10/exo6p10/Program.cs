using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6p10 {
  class Program {
    static void Main(string[] args) {
      int[] tableau1 = { 4, 8, 7, 9, 1, 5, 4, 6 };
      int[] tableau2 = { 7, 6, 5, 2, 1, 3, 7, 4 };
      int[] tableau3 = new int[tableau1.Length];

      for(int i = 0; i < tableau1.Length; i++) {
        tableau3[i] = tableau1[i] + tableau2[i];
        Console.WriteLine("{0}", tableau3[i]);
      }

    }
  }
}
