using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testRandom {
  class Program {
    static void Main(string[] args) {

      

      long  N = 100, nmin = 0, nmax = 0;
      long count = 0;
      double x, y; 
      Random rnd = new Random(); 
      /*
      while(count < N) {

        x = rnd.NextDouble();

        if(x > 0.5) {

          nmax++;
        }
        else{
          nmin++;
        }
        ++count;      
      }
      Console.WriteLine("nmin = {0} ;  nmax = {1}", nmin, nmax);
      */
      Console.WriteLine("------------------------------------");

      count = 0;
      int inside = 0;
      while(count < N) {
        x = rnd.NextDouble();
        y = rnd.NextDouble();

        if(((x * x + y * y) <= 1)) {
          inside++;
        }

        count++;
        
      }

      Console.WriteLine("pi = {0} vs\npi = {1}", 4.0*inside/N, Math.PI);
       
    }
  }
}
