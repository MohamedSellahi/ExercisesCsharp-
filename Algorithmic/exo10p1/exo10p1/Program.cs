using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exo10p1 {
  class Program {
    static void Main(string[] args) {
      string fileName = "C:\\Users\\34011-36-05\\Documents\\Visual Studio 2015\\Projects\\exo10p1\\test.txt";

      try {

        using(StreamReader sr = new StreamReader(fileName)) {
          string line;

          while((line = sr.ReadLine()) != null) {
            Console.WriteLine(line);
          }

        }

      }
      catch(Exception e) {
        Console.WriteLine("File coud ntot be read ");
        Console.WriteLine(e.Message);
      }

    }
  }
}
