using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions {
  class Program {
    static void Main(string[] args) {

      Console.WriteLine("**** Fun with type conversions *****");
      short x1 = 9, x2 = 3;
      short answer = (short)Add(x1, x2);
      Console.WriteLine("{0} + {1} = {2}", x1, x2, answer);

      ProcessBytes();
      DeclareImplicitVars();
      LinqQueryOverInts();

    }// end of main

    static void DeclareImplicitVars() {
      var myInt = 0;
      var myBool = true;
      var myString = "Time, marches on ...";
      Console.WriteLine(myInt);
      Console.WriteLine(myBool);
      Console.WriteLine(myString);
      Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
      Console.WriteLine("myBoll is a: {0}", myBool.GetType().Name);
    }

    static int Add(int n1, int n2) {
      return n1 + n2;
    }

    static void ProcessBytes() {
      byte b1 = 100;
      byte b2 = 250;
      try {
        byte sum = checked((byte)Add(b1, b2));
        Console.WriteLine("sum = {0}", sum);
      }
      catch(Exception e) {
        Console.WriteLine(e.Message);      
      }
    }

    // use of implicite typing 
    static void LinqQueryOverInts() {
      int[] numbers = {10,20,30,40,1,2,3,8};

      var subset = from i in numbers where i < 10 select i;
      Console.Write("values in subset: ");
      foreach(var i in subset) {
        Console.Write("{0} ", i);
      }
      Console.WriteLine();
      // what is the type of subset
      Console.WriteLine("subset is a: {0}", subset.GetType().Name);
      Console.WriteLine("subset is defined in {0}", subset.GetType().Namespace);

    }

  }// end of program 
}// end of name space 
