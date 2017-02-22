using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo9p5 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Entrer une phrase: ");
      string phrase = Console.ReadLine();

      Console.WriteLine("entrer le rang du character a suprimer: ");

      int iChar = Convert.ToInt32(Console.ReadLine());

      if(iChar>-1 && iChar < phrase.Length+1) {
        phrase = phrase.Remove(iChar, 1);
        Console.WriteLine(phrase);
      }
      else {
        Console.WriteLine("entrée non valide");
      }

    }
  }
}
