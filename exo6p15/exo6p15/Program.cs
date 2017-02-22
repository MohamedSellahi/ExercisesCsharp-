using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6p15 {
  class Program {
    static void Main(string[] args) {
      int nbAnnee = 20;
      decimal valeurInitial = 1000;
      decimal[] compte = new decimal[nbAnnee];
      decimal gain = 0.0275m; 

      compte[0] = 1000;
      int i;
      for(i = 1; i < nbAnnee; i++) {
        compte[i] = compte[i - 1] + compte[i - 1] * gain;
      }

      Console.WriteLine("Evolution du compte");
      i = 1;
      foreach(var item in compte) {
        Console.Write("Année #{0}: ", i);
        Console.WriteLine("{0:N2}",item);
        ++i;
      }




    }
  }
}
