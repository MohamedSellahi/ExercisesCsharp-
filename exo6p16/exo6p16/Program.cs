using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6p16 {
  class Program {
    static void Main(string[] args) {
      int taille = 20;
      int[] tab = new int[taille];

      Random rnd = new Random();


      /* remplire le tableau avec des valeur aléatoires */
      int i; 
      for( i = 0; i < taille; i++) {
        tab[i] = rnd.Next(100);        
      }

      /* affichage de tableau initial */
      foreach(var item in tab) {
        Console.WriteLine(item);
      }

      bool consecutif = true; 
      for(i = 0; i < taille - 1; i++) {
        if(tab[i + 1] - tab[i] != 1) {
          consecutif = false;
        }
      }

      if(consecutif) {
        Console.WriteLine("Valeur de tabeau sont consécutives");
      }
      else {
        Console.WriteLine("Valeur de tabeau ne sont pas consécutives");
      }
    }
  }
}
