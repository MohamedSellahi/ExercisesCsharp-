using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7p4 {
  class Program {
    static void Main(string[] args) {

      int[] tab = { 12, 8, 4, 45, 64, 9, 2 };
      int val;
      bool trouvee = false;
      int count = 0;

      foreach(var item in tab) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");

      Console.WriteLine("Entrer la valeur à suprimer: ");
      /* on devrait s'assurer la bonne saisie */
      val = Convert.ToInt32((Console.ReadLine()));

      /* chercher la première valeur */
      int i; 
      for(i = 0; i < tab.Length; i++) {
        if(val == tab[i]) {
          trouvee = true;
          count = i;
          break;
        }
      }


      /* */
      if(trouvee) {
        for(++i; i < tab.Length; i++) {
          tab[i - 1] = tab[i];
        }
        tab[i-1] = 0;

        Console.WriteLine(" Le tableau devient: ");
        foreach(var item in tab) {
          Console.Write("{0} ", item);
        }
        Console.WriteLine("");
      }
      else {
        Console.WriteLine("La valeur entrée ne fait pas partie du tableau");
      }



    }
  }
}
