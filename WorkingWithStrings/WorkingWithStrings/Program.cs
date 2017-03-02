using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings {
  class Program {
    static void Main(string[] args) {
      basicStringFunctionality();
      StringConcatenation();
      EscapeCharacters();
      // Verbatim string
      Console.WriteLine(@"C:\MyApp\bin\Debug");
      string myLongstring = @"this is a very
                very 
                           very long string";
      Console.WriteLine(myLongstring);
      Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");

      StringEquality();
      StringsAreImmutable();
      FunWithStringBuilder();



    }// end of main

    static void FunWithStringBuilder() {
      StringBuilder sb = new StringBuilder("*** fantastic Games ****");
      sb.Append("\n");
      sb.AppendLine("half Life");
      sb.AppendLine("Morrowind");
      sb.AppendLine("Deus Ex" + "2");
      sb.AppendLine("System Shock");
      Console.WriteLine(sb.ToString());
      sb.Replace("2", " Invisible War");
      Console.WriteLine(sb.ToString());
      Console.WriteLine("sb has {0} chars.", sb.Length);
    }

    static void StringsAreImmutable2() {
      string s2 = "My other string";
      s2 = "New string value";
    }

    static void StringsAreImmutable() {

      string s1 = "this is my string";
      Console.WriteLine("s1 = {0}", s1);
      string upperString = s1.ToUpper();
      Console.WriteLine("upperString = {0}",upperString);
      Console.WriteLine("s1 = {0}", s1);


    }

    static void StringEquality() {
      Console.WriteLine("=> String equality:");
      string s1 = "Hello!";
      string s2 = "Yo!";
      Console.WriteLine("s1 = {0}", s1);
      Console.WriteLine("s2 = {0}", s2);
      Console.WriteLine();
      // Test these strings for equality.
      Console.WriteLine("s1 == s2: {0}", s1 == s2);
      Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
      Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
      Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
      Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
      Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
      Console.WriteLine();
      Console.WriteLine("----------------------------------------");
    }

    private static void EscapeCharacters() {
      Console.WriteLine("=> Escape characters");
      string strWithTabs = "Model\tColor\tSpeed\t Name\a";
      Console.WriteLine(strWithTabs);

      Console.WriteLine("everyone loves \"Hello World\"\a");
      Console.WriteLine("C:\\MyApp\\bin\\debug\a");
      Console.WriteLine("All finished.\n\n\n\n\a");
    }

    private static void StringConcatenation() {
      Console.WriteLine("=> String concatenation");
      string s1 = "Programming the";
      string s2 = "Psychodrill(PTP)";
      string s3 = s1 + s2;
      Console.WriteLine(s3);
      Console.WriteLine();
      Console.WriteLine("----------------------------------------");
    }

    static void basicStringFunctionality() {
      Console.WriteLine("=> basic string functionality:");
      string firstname = "Freddy";
      Console.WriteLine("Value of first name: {0}", firstname);
      Console.WriteLine("firstname has {0} characters. ", firstname.Length);
      Console.WriteLine("firstname in upperCase: {0}", firstname.ToUpper());
      Console.WriteLine("firstname to lowercase:{0}", firstname.ToLower());
      Console.WriteLine("firstname contains the letter y ?: {0}", firstname.Contains('y'));
      Console.WriteLine("firstname after replace: {0}", firstname.Replace("dy",""));
      Console.WriteLine("----------------------------------------");
    }
    

  }// end of Program
}// end of namespace 
