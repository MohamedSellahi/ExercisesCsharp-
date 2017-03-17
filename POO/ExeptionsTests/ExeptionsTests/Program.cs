using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExeptionsTests {
  class Program {
    static void Main(string[] args) {
      try {
        string chaine = "dix";

        //throw new MyException();

        int val = Convert.ToInt32(chaine);
        Console.WriteLine("val: {0}", val);
        // pour bien traiter les exceptions, il est recommander d'attrapper  
        // les exceptions en partant des plus specifiques au plus générale (voir hierarchie des classes Exception)
      }
      catch (MyException e) {
        Console.WriteLine(e.ToString());
      }
      catch (FormatException e) { // e reference d'un object de la class exception. (C++ --->   Exception& e)
        Console.WriteLine("Il y eu une erreur de conversion. Plus d'infos ci dessous : \n");
        Console.WriteLine(e.Message);
        Console.WriteLine("Pile d'appel : " + e.StackTrace);
        Console.WriteLine();
        Console.WriteLine("Type de l'exception : " + e.GetType());
        Console.WriteLine("------------------");
        Console.WriteLine(e.ToString());
      }
      // propagation d'une exception 

      Console.WriteLine('\n');
      Console.WriteLine("-------------Propagation exception---------------");
      Console.WriteLine("-------------------------------------------------");
      Console.WriteLine('\n');
      try {
        Method1();
      }
      catch (NotImplementedException e) {
        Console.WriteLine("On intercepte l'exception dans la methode Method3().");
        Console.WriteLine(e.Message);
      }
      Console.WriteLine('\n');
      Console.WriteLine("-------------------------------------------------");
      Console.WriteLine('\n');

      // faire propager une exception 
      Console.WriteLine('\n');
      Console.WriteLine("-------------Faire propager exception------------");
      Console.WriteLine("-------------------------------------------------");
      Console.WriteLine('\n');

      try {
        MyMethode();
      }
      catch (Exception) {
        // ici on surveille toutes les exception 
        EnvoyerExceptionAdministrateur();        
      }


      Console.WriteLine('\n');
      Console.WriteLine("-------------------------------------------------");
      Console.WriteLine('\n');




      // il est possible d'imbriquer les blocs try catsh 
      CultureInfo[] local = { new CultureInfo("fr-FR"),
                              new CultureInfo("en-US")};
      string str = "18.0"; // ou saisie dans la console 

      try {
        int i = Convert.ToInt32(str);
        Console.WriteLine("Val= {0}", i);
      }
      catch (FormatException eInt) { // conversion ver int echouée
        try {
          double d = Convert.ToDouble(str, local[0]);
          Console.WriteLine("d = {0}", d);
        }
        catch (FormatException eDouble) {
          Console.WriteLine("La saisie n'est pas une valeur int ou double");
        }
      }
      finally {// utile pour liberer des resources, enregistrer un logfile ...
        Console.WriteLine("Merci d'avoir ssaisie qualque chose");
      }

      try {
        double nb = -19;
        Console.WriteLine("sqrt({0}) = {1:0.00}", nb, RacineCarree(nb));

      }
      catch (ArgumentOutOfRangeException e) {
        Console.WriteLine(e.ToString());
      }

    }



    public static void EnvoyerExceptionAdministrateur() {
      Console.WriteLine("au finale, J'ai envoyé un message a administrateur"); ;
    }

    public static void MyMethode() {

      try {
        Console.WriteLine("Je simule exception FormatException");
        throw new FormatException();
        //throw new Exception();
      }
      catch (FormatException ex) {
        Console.WriteLine("J'ai attrapé l exception FormatException, je sais la traiter");
        
      }
      catch(Exception exx) {
        Console.WriteLine("Je sais pas traité ce genre de exception, j'enregistre un log, je releve l'exception");
        throw exx;
      }
      
    }

    public static double RacineCarree(double valeur) {
      if (valeur < 0) {
        throw new ArgumentOutOfRangeException("valeur", valeur, "le paramètre doit être positive.");
      }

      return Math.Sqrt(valeur);
    }

    public static void Method1() {

      Method2();
    }

    public static void Method2() {
      Method3();
    }

    public static void Method3() {
      throw new NotImplementedException();
    }
  }
}
