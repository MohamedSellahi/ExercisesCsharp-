using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo11p5 {
  class Program {
    static void Main(string[] args) {
      string chaine = "bonjour, je n'aime las les espaces ni les les lettre: a, e";
      string str = "ae ";

      Console.WriteLine("{0} --->\n{1}", chaine, purgeString(chaine, str));

    }


    public static string purgeString(string str, string chars) {
      string tmp = "";
      for(int i = 0; i < str.Length; i++) {
        if(!isFound(str[i], chars)) {
          tmp += str[i];
        }
      }
      return tmp;
    }

    public static bool isFound(char c, string str) {

      for(int i = 0; i < str.Length; i++) {
        if(str[i] == c) {
          return true;
        }
      }

      return false;
    }






  }// end class
}// end namespace
