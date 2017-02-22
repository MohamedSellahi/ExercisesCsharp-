using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exo10p2 {
  class Program {
    static void Main(string[] args) {
      string filePath = @"C:\Users\34011-36-05\Documents\Visual Studio 2015\Projects\exo10p2\repertoire.txt";
      List<string> noms = new List<string>();
      List<string> prenom = new List<string>();
      List<string> tel = new List<string>();
      
      string line;
      string[] tockens;
      char delimiter = '/';
      int nContact = 0;
      int nContactEnregistre = 5;

      // Test ecriture
      try {
        using(StreamWriter sr = new StreamWriter(filePath)) {
          for(int i = 0; i < nContactEnregistre; i++) {
            sr.Write("nom{0}" + delimiter + "prenom{1}" + delimiter + "tel{2}" + Environment.NewLine, i, i, i);
          }

        }

      }
      catch(Exception e) {
        Console.WriteLine("can't write to file");
        Console.WriteLine(e.Message);
      }

      // test lecture 
      try {
        using(StreamReader sr = new StreamReader(filePath)) {
          

          while((line = sr.ReadLine()) != null) {
            tockens = line.Split(delimiter);
            noms.Add(tockens[0]);
            prenom.Add(tockens[1]);
            tel.Add(tockens[2]);
            ++nContact;
          }

          for(int i = 0; i < nContact; i++) {
            Console.WriteLine("{0} {1} {2}", noms[i], prenom[i], tel[i]);
          }
        }

      }
      catch(Exception e) {
        Console.WriteLine("cant open file");
        Console.WriteLine(e.Message);
      }

      try {
        using(StreamWriter sr = new StreamWriter(filePath)) {
          int n = 2;
          int i = 0;
          for( i = 0; i < n; i++) {
            sr.WriteLine("{0} {1} {2}", noms[i], prenom[i], tel[i]);
          }
          sr.WriteLine("{0} {1} {2}", noms[i], prenom[i], tel[i] + "modif");

          while(i < nContact) {
            sr.WriteLine("{0} {1} {2}", noms[i], prenom[i], tel[i]);
            ++i;
          }
        }



      }
      catch(Exception e) {
        Console.WriteLine("cant open file");
        Console.WriteLine(e.Message);
      }



    }
  }
}
