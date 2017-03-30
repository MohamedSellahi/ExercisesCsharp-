using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo7p5_dichotomi {
  class Program {

    
    static void Main(string[] args) {
      int taille = 6;
      //int[] tab = new int[taille];
      int[] tab = { 1, 2, 3, 4, 5, 6 };

      int start = 0;
      int end = taille - 1;
      int mid = (end + start) / 2;
      bool found = false;
      int key = 20;

      /******* version iterative ************/

      do {
        
        if(tab[mid] < key) {
          start = mid + 1;
          mid = (end + start) / 2;
        }
        else if(tab[mid] > key) {
          end = mid - 1 ;
          mid = (end + start) / 2;
        }
        else {
          found = true;
        }

      } while((!found) && (start < end));

      if(found) {
        Console.WriteLine("Key found");
      }
      else {
        Console.WriteLine("key not found");
      }


      /*************** methode recursive *************/

      int taille2 = 6;
      start = 0;
      end = taille2 - 1;
      int[] tab1 = { 1, 2, 3, 4, 5, 6};


      int key2 = 5;

      Program prg = new Program();

      if(prg.FindKey(tab1, start, end, key2)) {
        Console.WriteLine("Key2 found again ");
      }
      else {
        Console.WriteLine("Key2 not found again");
      }
   
    }

         
    public bool FindKey(int[] tab, int start, int end, int key) {

      if(end < start) {
        return false;
      }
      else {
        int mid = (start + end) / 2;

        if(tab[mid] < key) {
          start = mid + 1;
          return FindKey(tab, start, end, key);
        }
        else if(tab[mid] > key) {
          end = mid - 1;
          return FindKey(tab, start, end, key);
        }
        else {
          return true; 
        }

      }



    }
  }

}
