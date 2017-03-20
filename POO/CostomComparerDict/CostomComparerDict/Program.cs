using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomComparerDict {
  class Program {
    static void Main(string[] args) {

      IDictionary<int, Student> StudentDictionnary = new Dictionary<int, Student>() {
        {1, new Student() {StudentID = 1, StudentName = "Bill" }},
        {2, new Student() {StudentID = 2, StudentName = "Steve" }},
        {3, new Student() {StudentID = 3, StudentName = "ram"} }
      };

      Student std = new Student() { StudentID = 1, StudentName = "Bill" };

      KeyValuePair<int, Student> elementToFind = new KeyValuePair<int, Student>(1, std);

      Console.WriteLine(StudentDictionnary.Contains(elementToFind,new StudentDictionnaryComparer()));

      Dictionary<int, Student> Dict1 = new Dictionary<int, Student>() {
        {1, new Student() {StudentID = 1, StudentName = "Bill" }},
        {2, new Student() {StudentID = 2, StudentName = "Steve" }},
        {3, new Student() {StudentID = 3, StudentName = "ram"} }
      };

      Console.WriteLine(Dict1.Contains(elementToFind, new StudentDictionnaryComparer()));

      for (int i = 0; i < Dict1.Count; i++) {
        Console.WriteLine("Index: {0}, Key: {1}, Value: {2}",i, Dict1.ElementAt(i).Key, Dict1.ElementAt(i).Value.StudentName);
      }







    }// main 

  }
}
