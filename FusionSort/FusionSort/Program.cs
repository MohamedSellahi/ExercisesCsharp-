using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionSort {
  class Program {
    static void Main(string[] args) {
      int[] tab1 = { 1, 3, 3, 10, 20 };
      int[] tab2 = { -2, 2, 3, 8 };

      LinkedList<int> list = new LinkedList<int>(tab1);
      LinkedListNode<int> Node;









      int[] res = Fusion(tab1, tab2);
      int[] res2 = PartialFusion(tab1, tab2, 0, tab1.Length - 1, 0, 1);

      foreach(var item in res) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine();
      Console.WriteLine();
      foreach(var item in res2) {
        Console.Write("{0} ", item);
      }
      Console.WriteLine();

      int[] tab = { 3, 2, 40, 20, 15, 13 };
      int[] res3 = FusionSort(tab, 0, 5);



    }









    public static int[] FusionSort(int[] tab, int begin, int end) {
      if(tab.Length <= 1) {
        return tab;
      }
      else {

        return PartialFusion(FusionSort(tab, begin, (begin + end) / 2),
                             FusionSort(tab, (begin + end) / 2 + 1, end), begin, (begin + end) / 2, (begin + end) / 2 + 1, end);
      }

    }








    public static int[] PartialFusion(int[] A, int[] B, int StartA, int EndA, int StartB, int EndB) {
      int lenA = EndA - StartA + 1,
          lenB = EndB - StartB + 1,
          LenResult = lenA + lenB;

      int[] Result = new int[LenResult];
      int i = StartA,
          j = StartB,
          k = 0;
      while(i < StartA + lenA && j < StartB + lenB) {
        if(A[i] < B[j]) {
          Result[k] = A[i];
          ++i;
          ++k;
        }
        else {
          Result[k] = B[j];
          ++j;
          ++k;
        }
      }

      //
      if(lenA < lenB) {
        //++j;
        while(k < LenResult) {
          Result[k] = B[j];
          ++j;
          ++k;
        }
      }
      else {
        //++i;
        while(k < LenResult) {
          Result[k] = A[i];
          ++i;
          ++k;
        }
      }


      return Result;
    }








    public static int[] Fusion(int[] A, int[] B) {
      int lenA = A.Length,
          lenB = B.Length,
          LenResult = lenA + lenB;
      int[] Result = new int[LenResult];
      int i = 0,
          j = 0,
          k = 0;

      while(i < lenA && j < lenB) {
        if(A[i] < B[j]) {
          Result[k] = A[i];
          ++i;
          ++k;
        }
        else {
          Result[k] = B[j];
          ++j;
          ++k;
        }
      }

      //
      if(lenA < lenB) {
        //++j;
        while(k < LenResult) {
          Result[k] = B[j];
          ++j;
          ++k;
        }
      }
      else {
        //++i;
        while(k < LenResult) {
          Result[k] = A[i];
          ++i;
          ++k;
        }
      }

      return Result;
    }
  

         

    
  }
}
