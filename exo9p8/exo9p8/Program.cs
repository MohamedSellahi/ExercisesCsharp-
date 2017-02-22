using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo9p8 {
  class Program {
    static void Main(string[] args) {

      string alphabet = "HYLUJPVREAKBNDOFSQZCWMGITX";

      Console.WriteLine("entrer le message a crypter: ");
      string message = Console.ReadLine();
      char[] mChars = new char[message.Length];

      int i;
      for(i = 0; i < mChars.Length; i++) {

        if(message[i] > 96) {
          mChars[i] = (char)(message[i] - 32);
        }
        else {
          mChars[i] = message[i];
        }
        //Console.WriteLine((mChars[i] - 'A') % 26);
        mChars[i] = alphabet[(mChars[i] - 'A') % 26];
      }

      /* crypter le message */

      Console.WriteLine("--------------------------------");
     
      Console.WriteLine(alphabet);
      Console.WriteLine(message);
      Console.WriteLine(mChars);



    }
  }
}
