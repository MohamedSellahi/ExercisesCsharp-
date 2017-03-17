using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPException {
  class Program {
    static void Main(string[] args) {
      try {
        Salarie s = new Salarie("Mohamed", 1, 0, 23, 100);
       
        Console.WriteLine(s.ToString());
      }
      catch (SalarieException e) {
        Console.WriteLine(e.ToString());
        //Console.WriteLine(e.StackTrace);
        //Console.WriteLine(e.GetType());
      }

      


    }// main 



  }
}
