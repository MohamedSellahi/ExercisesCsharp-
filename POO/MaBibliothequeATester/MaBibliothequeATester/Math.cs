using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliothequeATester {

  public static class Math {

    public static int Factorielle(int n) {
      if (n <= 1)
        return 1;
      return n * Factorielle(n - 1);
    }





  }
}
