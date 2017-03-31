/**
*   Ecrivez un algorithme qui inverse l’ordre des éléments d’un tableau 
*   dont on suppose qu'il a été préalablement saisi 
*   (« les premiers seront les derniers… »)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7p2 {
  class Program {
    static void Main(string[] args) {

      int[] tab = { 1, 3, 5, 10, 1, 12 };
      int i = 0, j = tab.Length -1;
      int tmp;

      /* affichage de tableau initial */

      foreach(var item in tab) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");

      while(j > i) {
        tmp = tab[i];
        tab[i] = tab[j];
        tab[j] = tmp;
        ++i;
        --j;
      }

      /* affichage de tableau inversé */
      foreach(var item in tab) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");



    }
  }
}
