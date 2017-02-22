using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exo10p3 {
  class Program {
    static void Main(string[] args) {

      string filePath = @"C:\Users\34011-36-05\Documents\Visual Studio 2015\Projects\exo10p4\repertoire.txt";
      int maxNameLen = 16,
          maxTelLen = 13,
          maxMailLen = 30;
      string nom, tel, mail, UserInput;
      List<string> Names = new List<string>(),
                   Phones = new List<string>(),
                   EMAILS = new List<string>();
      int nContacts = 0;
      char delimiter = ' ';

      // open file for appending
      if(!File.Exists(filePath)) { // create file to write to
        Console.WriteLine("Creation de nouveau repertoire");
      }
      else { // read all contacts to RAM
        using(StreamReader sr = File.OpenText(filePath)) {
          string tmp;
          string[] tockens = new string[3];
          while((tmp = sr.ReadLine()) != null) { // read contacts 
            //tockens = tmp.Split(delimiter); bug for multiple spaces 
            tockens[0] = tmp.Substring(0, maxNameLen);
            tockens[1] = tmp.Substring(maxNameLen, maxTelLen);
            tockens[2] = tmp.Substring(maxNameLen + maxTelLen);

            // TODO test for num tockens == 3 otherwise print error format
            Names.Add(tockens[0]);
            Phones.Add(tockens[1]);
            EMAILS.Add(tockens[2]);
            ++nContacts;
          }
        }
      }

      // prompt user for input 

      while(true) {

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
        TrimInput(ref mail, maxMailLen);



        // Insert Contact to directory 
        // find position where to insert
        int i = 0;
        while(i < nContacts && string.Compare(Names[i], nom) < 0) {
          ++i;
        }
        Names.Insert(i, nom);
        Phones.Insert(i, tel);
        EMAILS.Insert(i, mail);
        ++nContacts;   // update number of contacts 

        // we will not write after each contact entrey; wait until the end.

        Console.Write("Voulez rajouter un nouveau contact:O/N");
        UserInput = Console.ReadLine();
        if(UserInput != "O") {

          // write back contacts to 


          using(StreamWriter sw = File.CreateText(filePath)) { // try StreamWriter sw = new StreamWriter(File.Open(filePath,FileMode.Create,FileAccess.Write),Encoding.UTF8);
            for(int ic = 0; ic < nContacts; ic++) {
              sw.WriteLine("{0}{1}{2}", Names[ic], Phones[ic], EMAILS[ic]);
            }
          }

          break;
        }

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
