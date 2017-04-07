using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod {
  class Program {


    static void Main(string[] args) {
      Console.WriteLine("***** Anonylous Methods *****\n");

      int AboutTOBlowCounter = 0;

      Car c1 = new Car("BMW", 200, 20);
      // Register evnet handlers as anonymous methods 
      c1.AboutToBlow += delegate {
        Console.WriteLine("Going too fast");
      };

      c1.AboutToBlow += delegate (object sender, CarEventArgs e) {
        AboutTOBlowCounter++;
        Console.WriteLine("Critical Message: {0}", e._message);
      };

      c1.Exploaded += delegate (object sender, CarEventArgs e) {
        Console.WriteLine("Fatal Error from Car: {0}", e._message);
      };

      // trigger events 
      for (int i = 0; i < 10; i++) {
        c1.Accelerate(20);
      }

      Console.WriteLine("About To blow event was fired {0}", AboutTOBlowCounter);


    }
  }
}
