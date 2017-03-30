using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7p3 {
  class Program {
    static void Main(string[] args) {
      int[] tab1 = { 1, 2, 5, 2, 5, 20, 11 };
      int[] tab2 = { 1, 2, 5, 2, 5, 20, 11 };
      int tmp;
      int i, j;
      foreach(var item in tab1) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");

      /******* tri par : sélection *******/
      for(i = 0; i < tab1.Length; i++) {

        for(j = i + 1; j < tab1.Length; j++) {
          if(tab1[i] < tab1[j]) {
            tmp = tab1[i];
            tab1[i] = tab1[j];
            tab1[j] = tmp;
          }
        }
      }

      foreach(var item in tab1) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");

      /******** tri par : a bulles ************/

      foreach(var item in tab2) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");
      bool Yapermute = true;

      while(Yapermute) {
        Yapermute = false;
        for(i = 0; i < tab2.Length - 1; i++) {
          if(tab2[i] < tab2[i + 1]) {
            Yapermute = true;
            tmp = tab2[i];
            tab2[i] = tab2[i + 1];
            tab2[i + 1] = tmp;
          }
        }
      }

      foreach(var item in tab2) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");


    }
  }
}
