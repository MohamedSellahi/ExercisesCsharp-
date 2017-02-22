using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo8p5 {
  class Program {
    static void Main(string[] args) {
      int nRow = 12, nCol = 8;
      int[,] tab = new int[nRow, nCol];
      Random rnd = new Random();

      /** remplir le tableau avec des valeur aléatoire **/
      int i, j, imax = 0, jmax = 0,previousMax = 0, max = 0, countMax = 0;

      for(i = 0; i < nRow; i++) {
        for(j = 0; j < nCol; j++) {
          tab[i, j] = rnd.Next(20);
        }
      }

      /* rechercher une valeur maximal: V1 : garder i,j pour le dernier max rencontrer
      *  si multiple occurence de ce max.
      *  le nombre de max rencontré est sauvé dans la variable countMax.
      */
      for(i = 0; i < nRow; i++) {
        for(j = 0; j < nCol; j++) {
          if(tab[i, j] >= max) {
            previousMax = max; 
            max = tab[i, j];
            imax = i;
            jmax = j;
            if(max == previousMax) {
              ++countMax;
            }
            else {
              countMax = 1;
            }

          }
        }
      }
      /* afficher le tableau */

      for(i = 0; i < nRow; i++) {
        for(j = 0; j < nCol; j++) {
          Console.Write(string.Format("{0,-2} ", tab[i, j]));
        }
        Console.WriteLine("");
      }

      Console.WriteLine("\nle max est : {0}", max);
      Console.WriteLine("il y a {0} occurence de ce max:", countMax);
      Console.WriteLine("la dernière occurence se trouve à tab[{0}, {1}]", imax, jmax);


    }
  }
}
