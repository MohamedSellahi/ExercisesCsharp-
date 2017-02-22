using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo9p6 {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Entrer le message à crypter: ");

      string message = Console.ReadLine();
      char[] msgChars = new char[message.Length];    
      
      char newChar;  
      for(int i = 0; i < message.Length; i++) {
        newChar = message[i];
        msgChars[i] = (char)(Convert.ToUInt16(newChar) + 1);
      }
      
      Console.WriteLine(message);
      Console.WriteLine(msgChars);
    }
  }
}
