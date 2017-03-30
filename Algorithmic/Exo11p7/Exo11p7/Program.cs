using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo11p7 {
  class Program {
    static void Main(string[] args) {
      int[] tab = { 1, 1, 2, 10, 19 };
      if(isOrdered(tab)) {
        Console.WriteLine("ordered");
      }
      else {
        Console.WriteLine("Not ordered");
      }

    }





    public static bool isOrdered(int[] tab) {

      bool order = true;

      for(int i = 1; i < tab.Length; i++) {
        if(tab[i] < tab[i - 1])
          order = false; 
      }
      return order;
    }
  }
}
