using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6p17 {
  class Program {
    static void Main(string[] args) {
      /* tri a la volée V1 */
      int taille = 5;
      int val;
      int[] tab = new int[taille];
      int count = 0, j = 0, i = 0 ;

      Console.WriteLine(" Tri à la volée, méthode 1: ");
      Console.WriteLine(" Entrer des entiers (max number 100): ");

      while(count< 100) {
        Console.WriteLine("Entrer une valeur: ");
        val = Convert.ToInt32(Console.ReadLine());
        if(val == 0) {
          break;
        }
        else {
          tab[count] = val; // stocker dans la dernière position de tableau
          int tmp;
          ++count;

          for(i = 0; i < count; i++) {// retrier la partie déjà pleinne de tableau
            for(j = i + 1; j < count; j++) {
              if(tab[j] < tab[i]) {
                tmp = tab[i];
                tab[i] = tab[j];
                tab[j] = tmp;
              }
            }
          }
        }
      }

      Console.WriteLine("Valeurs entrées triées: ");
      for(i = 0; i < count; ++i) {
        Console.Write("{0} ",tab[i]);
      }
      Console.WriteLine("");

      /********** tri avec decalage *************/

      Console.WriteLine("Deuxième méthode: ");
      int[] tab1 = new int[taille];

      count = 0;

      while(count < 100) {
        Console.WriteLine("Entrer une valeur: ");
        val = Convert.ToInt32(Console.ReadLine());
        if(val == 0) {
          break;
        }
        else { /* trouver la position d'insersion, decaler les éléments qui 
                  qui viennent derière, puis inserer l'élement */
          tab1[count] = val;
                   
          for( i = 0; i < count ; i++) {
            if(tab1[i] > val) {
              for(j = count; j > i; j--) {
                tab1[j] = tab1[j - 1];
              }
              tab1[i] = val;
              break;
            }
          }
          ++count;
        }
      }

      Console.WriteLine("Valeurs entrées triées: ");
      for(i = 0; i < count; ++i) {
        Console.Write("{0} ", tab1[i]);
      }
      Console.WriteLine("");

    }
  }
}
