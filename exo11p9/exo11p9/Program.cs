using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo11p9 {
  class Program {
    static void Main(string[] args) {
      int[] tab1 = { 1, 5, 3, -2, 20 };
      int[] tab2 = { 1, 5, 3, -2, 20 };

      foreach(var item in tab1) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine();

      Console.WriteLine("Order croissant");

      Trier(tab1, tab1.Length, false);
      foreach(var item in tab1) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine();

      Trier(tab2, tab2.Length, true);
      Console.WriteLine("Order decroissant");
      foreach(var item in tab2) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine();
    }


    public static int[] Trier(int[] tab, int nElems, bool order) {
      if(order) {// order croissant 
        for(int i = 0; i < nElems; i++) {
          for(int j = i + 1; j < nElems; j++) {
            if(tab[j] > tab[i]) {
              Swap(ref tab[i], ref tab[j]);
            }

          }
        }

      }
      else {// order decroissant 
        for(int i = 0; i < nElems; i++) {
          for(int j = i + 1; j < nElems; j++) {
            if(tab[j] < tab[i]) {
              Swap(ref tab[i], ref tab[j]);
            }

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
