using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomComparerDict {
  class Student {
    public int StudentID { get; set; }
    public string StudentName { get; set; }
  }


  class StudentDictionnaryComparer : IEqualityComparer<KeyValuePair<int, Student>> {


    public bool Equals(KeyValuePair<int, Student> x, KeyValuePair<int, Student> y) {
      return (x.Key == y.Key && (x.Value.StudentID == y.Value.StudentID) && x.Value.StudentName == y.Value.StudentName);
    }

    public int GetHashCode(KeyValuePair<int, Student> obj) {
      return obj.GetHashCode();
    }
  }
}
