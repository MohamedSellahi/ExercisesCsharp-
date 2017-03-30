using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo11p8 {
  class Program {
    static void Main(string[] args) {
      int x = 1;
      int y = 2;

      Console.WriteLine("x = {0}, y = {1}", x, y);

      Swap(ref x, ref y);

      Console.WriteLine("x = {0}, y = {1}", x, y);

    }



    public static void Swap(ref int x, ref int y) {
      int tmp;
      tmp = x;
      x = y;
      y = tmp;
    }






  }
}
