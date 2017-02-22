using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6p12 {
  class Program {
    static void Main(string[] args) {
      int taille;

      Console.WriteLine("Entrer le nombre des élements dans le tableau");
      taille = Convert.ToInt32(Console.ReadLine()); 

      int[] tab = new int[taille];

      for(int i = 0; i < taille; i++) {
        tab[i] = Convert.ToInt32(Console.ReadLine());
        ++tab[i]; 
      }

      foreach(var item in tab) {
        Console.WriteLine("items {0}", item);
      }
    }
  }
}
