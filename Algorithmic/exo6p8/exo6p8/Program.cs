using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo6p8 {
  class Program {
    static void Main(string[] args) {
      int taille;
      string strTmp;

      Console.WriteLine("Entrer le nombre d'element dans le tableau: ");
      strTmp = Console.ReadLine();
      taille = Convert.ToInt32(strTmp);

      int[] tableau = new int[taille];
      int nbNegative = 0;
      int nbPositive = 0;
      int nbZero = 0;

      for(int i = 0; i < taille; i++) {
        Console.WriteLine("Entrer l'element suivant", i);
        tableau[i] = Convert.ToInt32(Console.ReadLine());
        if(tableau[i] > 0) {
          ++nbPositive; 
        }
        else if(tableau[i] < 0) {
          ++nbNegative;
        }
        else {
          ++nbZero;
        }
      }

      Console.WriteLine("Vous avez entré: {0} positif(s) et {1} négatif(s)", nbPositive, nbNegative);
    }
  }
}
