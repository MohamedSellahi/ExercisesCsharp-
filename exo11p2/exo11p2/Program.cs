using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo11p2 {
  class Program {
    static void Main(string[] args) {
      char[] chaine = { 'a', 'b', 'c', 'd', 'e', 'Y' };

      Console.WriteLine("Il ya {0}", NbVoyel(chaine));
    }

   

    public static int NbVoyel(char[] chaine) {
      int count = 0;

      for(int i = 0; i < chaine.Length; i++) {
        if(isVoyel(chaine[i])) {
          ++count;
        }
      }
      return count; 
    }

    public static bool isVoyel(char c) {
      switch(c) {
        case 'a':
        case 'A':
        case 'e':
        case 'E':
        case 'o':
        case 'O':
        case 'i':
        case 'I':
        case 'u':
        case 'U':
        case 'y':
        case 'Y':
          return true;
        default:
          return false;
      }
    }


  }
}
