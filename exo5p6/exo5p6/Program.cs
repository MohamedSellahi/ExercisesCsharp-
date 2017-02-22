using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo5p6 {
  class Program {
    static void Main(string[] args) {
      int depart;
      Console.WriteLine("Entrer une valeur de départ");

      depart = Convert.ToInt32(Console.ReadLine());
      int i = 1;
      int somme = 0;
      while(i < (depart + 1)) {
        somme += i;
        Console.Write("{0} + ", i);
        ++i;
      }
      Console.Write("\b\b");
      Console.WriteLine("= {0}", somme);
    }
  }
}
