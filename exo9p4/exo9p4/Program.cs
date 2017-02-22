using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo9p4 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Entrer une phrase");
      string phrase = Console.ReadLine();

      char[] voyel = { 'a', 'o', 'e','u', 'i', 'y' };
      int count = 0;

      for(int i = 0; i < phrase.Length; i++) {
        for(int j = 0; j < voyel.Length; j++) {
          if(phrase[i] == voyel[j]) {
            count++;
          }
        }
      }

      Console.WriteLine(phrase);
      Console.WriteLine("contient {0} voyels", count);

    }
  }
}
