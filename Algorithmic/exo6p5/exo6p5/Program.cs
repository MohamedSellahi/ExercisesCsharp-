using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6p5 {
  class Program {
    static void Main(string[] args) {
      int taille = 6;
      int[] tableau = new int[taille];

      tableau[0] = 1;
      for(int i = 1; i < tableau.Length; i++) {
        tableau[i] = tableau[i - 1] + 2;
      }

      foreach(var item in tableau) {
        Console.WriteLine(item);
      }

    }
  }
}
