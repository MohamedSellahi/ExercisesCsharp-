using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6p7 {
  class Program {
    static void Main(string[] args) {

      int taille = 5;
      int[] notes = new int[taille];
      string strTmp;
      int somme = 0;


      for(int i = 0; i < taille; i++) {
        Console.WriteLine("entrer notes {0}", i + 1);
        strTmp = Console.ReadLine();
        notes[i] = Convert.ToInt32(strTmp);
        somme += notes[i]; 
      }

      Console.WriteLine(" la moyenne = {0}", somme /taille);
    }
  }
}
