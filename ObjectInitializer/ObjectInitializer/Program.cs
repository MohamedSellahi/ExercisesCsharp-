using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("****** Object Init Syntax *****");

      Point p1 = new Point();
      p1.X = 10;
      p1.Y = 11;
      p1.DisplayStats();

      Console.WriteLine();
      // using custom contructor
      Point p2 = new Point(20, 20);
      p2.DisplayStats();

      Console.WriteLine();

      Point p3 = new Point { X = 2, Y = 3 };
      p3.DisplayStats();

      // explicit call of default constructor with initialization syntax

      Point p4 = new Point() { X = 0, Y = 2 };
      p4.DisplayStats();

      Point p5 = new Point(2, 2) { };
      p5.DisplayStats();

      Console.WriteLine("------------------");
      Point p6 = new Point(Pointcolor.Gold) { X = 90, Y = 20 };
      p6.DisplayStats();

      Point p7 = new Point() { X = 13, Y = 45 };
      p7.DisplayStats();
      Console.WriteLine(p7);

      Console.WriteLine("----------------------");
      Rectangle rect = new Rectangle() { TOPLEFT = p7, BOTTOMRIGTH = p6 };
      rect.DisplayStats();

    }



  }
}
