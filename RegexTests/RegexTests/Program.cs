using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexTests {
  class Program {
    static void Main(string[] args) {

      string str = @"{5, 0}, 		// 0 ";
      string ptr = @"(\d+)";
      Regex rgx = new Regex(ptr);
      MatchCollection matches = rgx.Matches(str);
      Console.WriteLine(matches[0].Value);



      Console.WriteLine(str);

    }
  }
}
