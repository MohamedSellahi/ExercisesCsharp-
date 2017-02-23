using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpQuickSort {
  class Program {
    static void Main(string[] args) {

      int[] tab = { 2, 8, 7, 1, 3, 5, 6, -1, 10, 20};

      int start = 0;
      int end = tab.Length - 1;

      foreach(var item in tab) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine();

      Qsort(tab, start, end);


      foreach(var item in tab) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine();
      
    }
    

    public static void Qsort (int[] tab, int begin, int end) {

      if(begin < end) {
        int pivot = Partition(tab, begin, end);
        Qsort(tab, begin, pivot - 1);
        Qsort(tab, pivot + 1, end);       
      }
    }


    public static int Partition(int[]tab, int begin, int end) {
      int i = begin - 1,
          x = tab[end];
      // 
      for(int j = begin; j < end; j++) {
        if(tab[j] <= x) {
          ++i;
          Swap(ref tab[i], ref tab[j]);
        }
      }
      ++i;
      Swap(ref tab[i], ref tab[end]);
      return i; 
    }

    public static void Swap(ref int x, ref int y) {
      int tmp = x;
      x = y;
      y = tmp;
    }




  }
}
