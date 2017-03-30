using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6p14 {
  class Program {
    static void Main(string[] args) {
      int taille = 0;
      double moyenne = 0;
      double somme = 0;
      int count = 0;

      Console.WriteLine("Entrer le nombre des notes");
      taille = Convert.ToInt32(Console.ReadLine()); // normalement on devrait s'assurer de bonne entrée.

      double[] notes = new double[taille];

      for(int i = 0; i < taille; i++) {
        notes[i] = Convert.ToDouble(Console.ReadLine());
        somme += notes[i];
      }
      moyenne = somme / taille; 

      foreach(var item in notes) {
        if(item > moyenne) {
          count++;
        }
      }

      Console.WriteLine("il ya {0} notes plus grandes que la moyenne", count);

    }
  }
}
