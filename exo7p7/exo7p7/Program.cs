using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7p7 {
  class Program {
    static void Main(string[] args) {

      int taille1 = 10, taille2 = 15;
      int[] tab1 = new int[taille1];
      int[] tab2 = new int[taille2];
      int[] tab3 = new int[taille1 + taille2];

      Random rnd = new Random();

      /* remplir les tab par des valeurs aleatoire entre 0 et 100 */
      int i, j;


      for(i = 0; i < tab1.Length; i++) {
        tab1[i] = rnd.Next(0, 100);
      }
      for(i = 0; i < tab2.Length; i++) {
        tab2[i] = rnd.Next(0, 100);
      }


      /* afficher les tableaux*/
      foreach(var item in tab1) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");

      foreach(var item in tab2) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");

      int tmp; 
      /* trier les tableux */
      for(i = 0; i < tab1.Length; i++) {
        for(j = i + 1; j < tab1.Length; j++) {
          if(tab1[j] < tab1[i]) {
            tmp = tab1[i];
            tab1[i] = tab1[j];
            tab1[j] = tmp;
          }
        }
      }

      Console.WriteLine("\ntab1 trié");
      foreach(var item in tab1) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");
      
      /* tab2 */
      for(i = 0; i < tab2.Length; i++) {
        for(j = i + 1; j < tab2.Length; j++) {
          if(tab2[j] < tab2[i]) {
            tmp = tab2[i];
            tab2[i] = tab2[j];
            tab2[j] = tmp;
          }
        }
      }

      Console.WriteLine("\ntab2 trié");
      foreach(var item in tab2) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");

      /* merger les tableaux */
      i = j = 0;
      int k = 0;

      while((i < taille1) && (j < taille2)) {
        if(tab1[i] < tab2[j]) {
          tab3[k] = tab1[i];
          ++k;
          ++i;
        }
        else if(tab1[i] > tab2[j]) {
          tab3[k] = tab2[j];
          ++k;
          ++j;
        }
        else {/* tab1[i] == tab2[j] */
          tab3[k] = tab1[i];
          ++k;
          tab3[k] = tab1[i];
          ++k;
          ++i;
          ++j;
        }
      }


      if(taille1 <= taille2) { /* remplire tab3 par ce qui reste de tab2 */
        while(j < taille2) {
          tab3[k] = tab2[j];
          ++j;
          ++k;
        }
      }
      else { /* taille2 < taille1: remplire tab3 par ce qui reste de tab1 */
        while(i < taille1) {
          tab3[k] = tab1[i];
          ++i;
          ++k;
        }

      }

      Console.WriteLine("\ntab3 trié");
      foreach(var item in tab3) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");



    }
  }
}
