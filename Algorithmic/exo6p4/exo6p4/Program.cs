using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6p4 {
  class Program {
    static void Main(string[] args) {
      int taille = 5;
      int[] tableau = new int[taille];

      for(int i = 0; i < tableau.Length; i++) {
        tableau[i] = i * i;
        Console.WriteLine(tableau[i]);
      }
    }
  }
}
