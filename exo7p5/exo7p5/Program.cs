using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7p5 {
  class Program {
    static void Main(string[] args) {
      string[] dictionnary = { "salut", "bye", "mots", "oui" };
      string val;
      bool trouvee = false; 

      Console.WriteLine("entrer le mots à chercher");
      val = Console.ReadLine();

      for(int i = 0; i < dictionnary.Length; i++) {
        if(val == dictionnary[i]) {
          trouvee = true;
          break; 
        }
      }

      if(trouvee) {
        Console.WriteLine("{0}: fait partie du dictionnaire.", val);
      }
      else {
        Console.WriteLine("{0}: pas trouvée dans le dictionnaire", val);
      }




    }
  }
}
