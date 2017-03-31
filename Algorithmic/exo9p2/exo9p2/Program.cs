using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo9p2 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("entrer un mots");
      string mots = Console.ReadLine();

      Console.WriteLine("le mots {0} contient {1} lettres", mots, mots.Length);
    }
  }
}
