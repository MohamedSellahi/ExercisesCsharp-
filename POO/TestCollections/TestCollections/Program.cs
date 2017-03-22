using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollections
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] tab1 = new int[5];
      int[] tab2 = (int[])tab1.Clone();
      tab1[0] = 5;

      // list sysntax
      ArrayList collection1 = new ArrayList();
      List<string> collections2 = new List<string>(10);
      Console.WriteLine(collections2.Capacity);
      Console.WriteLine(collections2.Count);

      // dictionnary / hashtable syntax 
      Dictionary<int, string> dict1 = new Dictionary<int, string>();
      IDictionary<int, string> dict2 = new Dictionary<int, string>();

      // Idictionnary is an interface (abstract), cannot be instanciated, 
      // this would be better if for somme reason, you decided to uses a custom
      // dictionnary implementation.
      //
      /*
      Exemple: 
      dict : is a dictionnary 
      key : is the key 
      1st implementation: rigid 

      public string GetValuFromKey(IDictionary dict as Dictionary<int, string>, int key) {

      if (true) { // found 
        return dict.getValue();
      }else {null;}}
      
      a better solution: use IDictionnary interface

      public string GetValuFromKey(dict as IDictionary<int, string>, int key) {

      if (true) { // found 
        return dict.getValue();
      }else {null;}}                                 
    
      */
      dict1.Add(1, "One1");
      dict1.Add(2, "Two1");
      dict1.Add(3, "Three1");
      // with interface we can do the same, or using KeyValuePair template

      dict2.Add(new KeyValuePair<int, string>(4, "Four"));
      dict2.Add(new KeyValuePair<int, string>(5, "Five"));

      // calss initializer 
      IDictionary<int, string> dict3 = new Dictionary<int, string>()
                                                            {
                                                                {1,"One"},
                                                                {2, "Two"},
                                                                {3,"Three"}
                                                            };
      // accessing elements of dictionnaries 
      Console.WriteLine("Using for statements");

      for (int i = 0; i < dict1.Count; i++)
      {
        Console.WriteLine("Key: {0}, Value: {1}", dict1.Keys.ElementAt(i), dict1.Values.ElementAt(i));
      }
      Console.WriteLine("---------------------------------");
      Console.WriteLine("Accessing individual elements ");
      dict1.Add(0, "Zero");

      try
      {
        Console.WriteLine(dict1[0]);
      }
      catch (KeyNotFoundException e)
      {

        Console.WriteLine(e);
        Console.WriteLine();
        Console.WriteLine("----------------------");
        //throw;
      }

      Console.WriteLine("trygetValue ");
      try
      {
        string str;
        dict1.TryGetValue(4, out str);
        Console.WriteLine(str);
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }

      Console.WriteLine("ContainKey & contains");
      Console.WriteLine(dict1.ContainsKey(0));
      Console.WriteLine(dict1.Contains(new KeyValuePair<int, string>(1, "One1")));




      Console.WriteLine();
      Console.WriteLine();


      foreach (KeyValuePair<int, string> item in dict3)
      {
        Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
      }

      foreach (KeyValuePair<int, string> item in dict1)
      {
        Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
      }
      Console.WriteLine();
      Console.WriteLine("------------------");



      /***********************
       Queue, stack 
      */

      Queue Q = new Queue();
      for (int i = 0; i < 5; i++)
      {
        Q.Enqueue(i);
      }
      Console.WriteLine("Number of elements in queue: {0}", Q.Count);

      while (Q.Count > 0)
      {
        Console.WriteLine(Q.Dequeue());
      }
      Console.WriteLine("Number of elements in the Queue {0}", Q.Count);

      for (int i = 2; i < 5; i++)
      {
        Q.Enqueue(i);
      }

      Console.WriteLine("Number of elements in the Queue {0}", Q.Count);
      Console.WriteLine(Q.Peek());
      Console.WriteLine("-------");

      // iterating without removing 

      foreach (var item in Q.ToArray())
      {
        Console.WriteLine(item);
      }

      Console.WriteLine("--------- Contains ----------");
      Console.WriteLine("Q.Contains(2) --> {0}", Q.Contains(2));
      Console.WriteLine("Q.Contains(100) --> {0}", Q.Contains(100));


      //
      Console.WriteLine("\n\n");
      Console.WriteLine("********** LIST ************");
      List<int> intList = new List<int>();

      intList.Add(10);
      intList.Add(20);
      intList.Add(30);
      intList.Add(40);

      IList<string> strList = new List<string>();
      strList.Add("one");
      strList.Add("two");
      strList.Add("three");
      strList.Add("four");
      strList.Add("four");
      strList.Add(null);
      strList.Add(null);

      IList<Student> studentList = new List<Student>();
      studentList.Add(new Student() { StudentID = 1, StudentName = "Bill" });
      studentList.Add(new Student() { StudentID = 2, StudentName = "Steve" });
      studentList.Add(new Student() { StudentID = 3, StudentName = "Moin" });
      foreach (var item in studentList)
      {
        Console.WriteLine(item);
      }

      

      //for (int i = 0; i < studentList.Count; i++)
      //{
      //  studentList[i].StudentID = i;
      //  studentList[i].StudentName = "_name_" + i.ToString();

      //  Console.WriteLine(studentList[i].ToString());
      //}

      IList<int> intList1 = new List<int>();
      intList1.Add(10);
      intList1.Add(20);
      intList1.Add(30);
      intList1.Add(40);

      List<int> intList2 = new List<int>();
      intList2.AddRange(intList1);
      Console.WriteLine(intList2);

      Console.WriteLine();
      Console.WriteLine("Inserting an element");
      intList1.Insert(1, 11);
      
      
      

      
      








    }// main 

  }// Program 
}
