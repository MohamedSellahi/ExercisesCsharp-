using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5p3 {
  class Program {
    static void Main(string[] args) {
      int depart;
      Console.WriteLine("Entrer une nombre de départ");

      depart = Convert.ToInt32(Console.ReadLine());

      for(int i = 1; i < 11; i++) {
        Console.WriteLine(depart + i);

      }
    }
  }
}
