using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace exo8p1 {
  class Program {
    static void Main(string[] args) {
      int nRow = 6, nCol = 13;

      int[,] Tab2D = new int[nRow, nCol];

      int i = 0, j = 0; 
      for(i = 0; i < nRow; i++) {

        for(j = 0; j < nCol; j++) {
          Tab2D[i, j] = 0;
        }
      }
      /* afficher le tableau */

      for(i = 0; i < nRow; i++) {
        for(j = 0; j < nCol; j++) {
          Console.Write("{0} ", Tab2D[i,j]);
        }
        Console.WriteLine("");
      }


    }
  }
}
