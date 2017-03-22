using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollections
{
  class Student
  {
    public string StudentName { get; set; }
    public int StudentID { get; set; }

    public override string ToString()
    {
      return "Name: " + StudentName + ", \tID:" + StudentID;
    }


  }
}
