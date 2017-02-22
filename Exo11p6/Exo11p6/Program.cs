using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo11p6 {
  class Program {
    static void Main(string[] args) {
      int[] tab = { 10, 2, 15, 3, 3, 4 };
      int nElems = tab.Length;

      // afficher tableau d'origine 
      foreach(var item in tab) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine();

      tab = Trier(tab, nElems);  // trier 

      // afficher tableau trié
      foreach(var item in tab) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine();

    }



    public static int[] Trier(int[] tab, int nElems) {
      for(int i = 0; i < nElems; i++) {
        for(int j = i+1; j < nElems; j++) {
          if(tab[i] > tab[j]) {
            Swap(ref tab[i], ref tab[j]);
          }
        }
      }
      
      return tab;
    }

    public static void Swap(ref int x, ref int y) {
      int tmp = x;
      x = y;
      y = tmp;
    }



  }
}
