using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7p6 {
  class Program {
    static void Main(string[] args) {
      int taille = 10;
      int[] tab1 = new int[taille];

      Random rnd = new Random();
      int i;
      for( i = 0; i < tab1.Length; i++) {
        tab1[i] = rnd.Next(0, 50);
      }

      Console.WriteLine("Tableau de positifs");
      foreach(var item in tab1) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");
      int min = tab1[0], max = tab1[0]; 

      for(i = 0; i < tab1.Length; i++) {
        if(tab1[i] < min) {
          min = tab1[i];
        }
        else if(tab1[i] > max) {
          max = tab1[i];
        }

      }
      Console.WriteLine("min = {0}, max = {1} : Ecart = {2}\n", min, max, max - min);

      /************* tablaux a  avec des positifs/negatifs **************/

      
      int[] tab2 = new int[taille]; 
      for(i = 0; i < tab2.Length; i++) {
        tab2[i] = rnd.Next(-50, 50);
      }

      Console.WriteLine("Tableau de valeurs pos/neg");
      foreach(var item in tab2) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine("");
      min = tab2[0];
      max = tab2[0];

      for(i = 0; i < tab2.Length; i++) {
        if(tab2[i] < min) {
          min = tab2[i];
        }
        else if(tab2[i] > max) {
          max = tab2[i];
        }

      }
      Console.WriteLine("min = {0}, max = {1} : Ecart = {2}", min, max, max - min);


    }
  }
}
