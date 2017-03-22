using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer {
  class Rectangle {

    private Point topLeft = new Point();
    private Point bottomRight = new Point();
    

    public Point TOPLEFT {
      get {
        return topLeft;
      }
      set {
        topLeft = value;
      }
    }

    public Point BOTTOMRIGTH { get { return bottomRight; } set { bottomRight = value; } }

    public void DisplayStats() {
      Console.WriteLine("TopLeft: {0}\n"+ 
                        "BottomRight: {1}\n", topLeft.ToString(), bottomRight.ToString());
    }


  }
}
