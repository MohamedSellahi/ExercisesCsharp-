using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo9p11 {
  class Program {
    static void Main(string[] args) {
      Random rnd = new Random();

      Console.WriteLine("# Aléatoire entre [0 2]: {0:N4}", 2.0* rnd.NextDouble());
      Console.WriteLine("# Aléatoire entre [-1 1]: {0:N4}", rnd.NextDouble()*2.0 - 1);
      

      //
      Console.WriteLine("# Aléatoire entre [1.35 1.65]: {0:N4}", rnd.NextDouble()*0.3 + 1.35);
      Console.WriteLine("# Aléatoire entre [-10.5 6.5]: {0:N4}", rnd.NextDouble()*17.0 -10.5);
      Console.WriteLine("# emulation d'un dé : {0:N4}",1.0/6);
      // la some du jet simultané: je comprends pas la question: 
      // es ce que 2*1/6 ou (1/6)^2

    }
  }
}
