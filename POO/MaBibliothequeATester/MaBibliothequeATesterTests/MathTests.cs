using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaBibliothequeATester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliothequeATester.Tests {

  [TestClass()]
  public class MathTests {
    [TestMethod()]
    public void FactorielleTest() {
      int value = 3;
      int fact = MaBibliothequeATester.Math.Factorielle(value);
      Assert.AreEqual(6, fact);
      
    }


  }
}