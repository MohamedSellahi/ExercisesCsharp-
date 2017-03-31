using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6p3 {
  class Program {
    static void Main(string[] args) {

      int taille = 9;
      int[] notes = new int[taille];
      string strTmp; 

      
      for(int i = 0; i < taille; i++) {
        Console.WriteLine("entrer notes {0}", i + 1);
        strTmp = Console.ReadLine();
        notes[i] = Convert.ToInt32(strTmp);
      }

      Console.WriteLine("vous avez entré :");
      foreach(var item in notes) {
        Console.WriteLine(item); 
      }
    }
  }
}
