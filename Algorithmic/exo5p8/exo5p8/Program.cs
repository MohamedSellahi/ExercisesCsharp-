using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5p8 {
  class Program {
    static void Main(string[] args) {
      int val, count = 0, max = 0;
      Console.Write("Entrer 20 nombres : ");

      while(count < 21) {

        Console.WriteLine("Entrer un nombre");
        val = Convert.ToInt32(Console.ReadLine());

        if(val > max) {
          max = val;
        }
        ++count;
      }
      Console.WriteLine("Le plus grand nombre est {0}", max);

            
      

    }
  }
}
