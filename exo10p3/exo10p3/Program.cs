using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exo10p3 {
  class Program {
    static void Main(string[] args) {

      string filePath = @"C:\Users\34011-36-05\Documents\Visual Studio 2015\Projects\exo10p3\repertoire.txt";
      int maxNameLen = 16,
          maxTelLen = 13,
          maxMailLen = 30;
      string nom, tel, mail, UserInput;



      // prompt user for input 

      while(true) {

        // open file for appending
        if(!File.Exists(filePath)) { // create file to write to

          using(StreamWriter sw = File.CreateText(filePath)) {
            nom = "Nom";
            tel = "Numéro de Tel";
            mail = "Mail";
            sw.WriteLine("{0}{1}{2}", TrimInput(ref nom, maxNameLen + 1),
                                      TrimInput(ref tel, maxTelLen + 1),
                                      TrimInput(ref mail, maxMailLen + 1));
          }

        }
        
         

        // get name : add exeption handeling later 
        Console.Write("Entrer le nom d'utilisateur: ");
        nom = Console.ReadLine();
        Console.Write("Entrer le numero de telephone: ");
        tel = Console.ReadLine();
        Console.Write("Entrer l'email: ");
        mail = Console.ReadLine();

        // trim input if  necessary
        TrimInput(ref nom, maxNameLen);
        TrimInput(ref tel, maxTelLen);
        TrimInput(ref mail, maxTelLen);

    

        // Append text to the existing file 

        using(StreamWriter sw = File.AppendText(filePath)) {
          sw.WriteLine("{0}{1}{2}", nom, tel, mail);
        }

        Console.Write("Voulez rajouter un nouveau contact:O/N");
        UserInput = Console.ReadLine();
        if(UserInput != "O")
          break;
      }

      
       




    }

    /*  truncates input if input length is greater than size allocated for,
     *  or pads with spaces if length is less than size 
     */
    public static string TrimInput(ref string str, int MaxLen) {

      if(str.Length >= MaxLen) {
        str = str.Substring(0, MaxLen);
      }
      else {
        str = str.PadRight(MaxLen);
      }
      return str;
    }



  }
}
