using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountReccurence {
  class Program {
    static void Main(string[] args) {

      int[] tab = { 1, 1, 1, 2, 3, 2, 3 };
      int[] score = new int[tab.Length];

      for(int i = 1; i < 10; i++) {
        for(int j = 0; j < tab.Length; j++) {
          if(tab[j] == i) {
            score[i-1]++;
          }
        }
      }
      foreach(var item in score) {
        Console.Write("{0} ", item);
      }




    }
  }
}
