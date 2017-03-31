using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo11p4 {
  class Program {
    static void Main(string[] args) {
      string str = "j' ai horreurs des espace";
      char c = ' '; 
      Console.WriteLine("{0} ---> {1}",str, purgeString(str, c));
    }


    public static string purgeString(string str, char c) {
      string tmp = "";
      for(int i = 0; i < str.Length; i++) {
        if(str[i] != c) {
          tmp += str[i];
        }
      } 
      return tmp;
    }

  }
}
