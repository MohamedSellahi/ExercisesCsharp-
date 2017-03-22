using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HashTables {
  class Program {
    static void Main(string[] args) {

      Hashtable ht1 = new Hashtable() {
        {1, "One"},
        {2, "Two"},
        {3, "Three"},
        {4, null },
        {"Fv", "Five" },
        {8.5F, 8.5F }
      };

      Console.WriteLine("Display using key");
      Console.WriteLine(ht1["Fv"]);

      //
      Dictionary<int, string> dict = new Dictionary<int, string>();

      dict.Add(1, "one");
      dict.Add(2, "two");
      dict.Add(3, "three");

      Hashtable ht = new Hashtable(dict);

      // Accessing hash table

      string strVal1 = (string)ht1[1];
      float fValue = (float)ht1[8.5F];

      Console.WriteLine(strVal1);
      Console.WriteLine(fValue);

      foreach (DictionaryEntry item in ht) {
        Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
      }

      //
      Console.WriteLine("--------------------------------");
      Console.WriteLine();
      

      foreach (var key in ht1.Keys) {
        Console.WriteLine("Key: {0}, Value: {1}", key, ht1[key]);
      }

      Console.WriteLine();
      Console.WriteLine("***All Value*****");
      foreach (var item in ht1.Values) {
        Console.WriteLine("Value: {0}", item);
      }

      // remove element 
      ht1.Remove("Fv");
      Console.WriteLine();
      Console.WriteLine("***All Value*****");
      foreach (var item in ht1.Values) {
        Console.WriteLine("Value: {0}", item);
      }

      // Contains 

      Console.WriteLine("****** HT ******");
      Hashtable ht2 = new Hashtable();
      ht2.Add(1, "One");
      ht2.Add(2, "Two");
      ht2.Add(3, "Three");
      ht2.Add(4, "Four");

      Console.WriteLine(ht2.Contains(2));
      Console.WriteLine(ht2.ContainsKey(2));
      Console.WriteLine(ht2.ContainsValue("One"));
      ht2.Clear();
      Console.WriteLine("Totals elements: {0}", ht2.Count);

      

      



    }// main 

  }
}
