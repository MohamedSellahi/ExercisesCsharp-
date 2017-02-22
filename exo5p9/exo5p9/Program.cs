using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5p9 {
  class Program {
    static void Main(string[] args) {
      int val, count = 0, max = 0;
      Console.Write("Entrer nombres : ");

      while(true) {

        Console.WriteLine("Entrer un nombre");
        val = Convert.ToInt32(Console.ReadLine());
        if(val == 0) {
          break;
        }
        else {
          if(val > max) {
            max = val;
            ++count; 
          }  
        }
      }

      if(count > 0) {
        Console.WriteLine("Le plus grand nombre est {0}", max);
      }
      

    }
  }
}
