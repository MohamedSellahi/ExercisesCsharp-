using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7p1 {
  class Program {
    static void Main(string[] args) {
    
      Console.Write("Entrer la taille de tableau: ");
      int taille = Convert.ToInt32(Console.ReadLine());

      int[] tab = new int[taille];

      int i = 0;
      for(i = 0; i < taille; i++) {
        Console.Write("Entrer l'elment {0}: ",i);
        tab[i] = Convert.ToInt32(Console.ReadLine());
      }
      bool consecutif = true;
      for(i = 1; i < taille; i++) {
        if((tab[i] - tab[i - 1]) != 1) {
          Console.WriteLine("Les éléments de tableau ne sont pas consécutifs");
          consecutif = false;
          break;
        }
      }
      if(consecutif) {
        Console.WriteLine("Les éléments de tableau sont consécutifs");
      }
      



    }
  }
}
