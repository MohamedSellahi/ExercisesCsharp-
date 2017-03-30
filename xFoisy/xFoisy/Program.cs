using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xFoisy {
  class Program {
    static void Main(string[] args) {

      string str = "  0x2A, 0x80, //   # # # # ";
      str = " 0x70, //  ### ";
      Console.WriteLine(str);
      Console.WriteLine(str.IndexOf("// ")+3);


      
      if (args.Length != 0) {
        Console.WriteLine("Vous avez entré");
        foreach (var item in args) {
          Console.Write("{0}, ", item);
        }

      }

      //if(args.Length != 2) {
      //  Console.WriteLine("Error:");
      //  System.Environment.Exit(0);
      //}

      //try {

      //  double x = Convert.ToDouble(args[0]);
      //  double y = Convert.ToDouble(args[1]);
      //  Console.WriteLine("Le produit est: {0}", x*y );
      //}
      //catch (Exception e) {
      //  Console.WriteLine(e.Message);

      //}

      
    }



  }
}
