using System;
using System.Text;

namespace ObjectInitializer {
  enum Pointcolor {
    LightBlue,
    BloodRed,
    Gold
  }


  class Point {
    public int X { get; set; }
    public int Y { get; set; }
    

    public Pointcolor Color { get; set; }
    

    public Point():this(Pointcolor.BloodRed) {}
    /// <summary>
    /// Point in 2D plane 
    /// </summary>
    /// <param name="xVal"></param>
    /// <param name="yVal"></param>
    public Point(int xVal, int yVal) {
      X = xVal;
      Y = yVal;
      Color = Pointcolor.Gold;
    }

    public Point( Pointcolor ptColor) {
      Color = ptColor;
    }

    


    public void DisplayStats() {
      Console.WriteLine("[{0}, {1}]", X, Y);
      Console.WriteLine("Point is {0}", Color);
    }

    public override string ToString() {
      return String.Format("[{0}, {1}], color is {2}", X, Y, Color);
    }






  }
}
