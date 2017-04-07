using System;
using System.Collections;
using System.Collections.Generic;
using MaBibliothequeATester;
using NUnit.Framework;

namespace NUnitMathTest {

  [TestFixture]
  public class NUnitTest1{

    [Test]

    public void TestMethod_TestFactorielle() {

      // arrange
      List<int> Res = new List<int> { 1, 2, 6, 24, 120 };
      List<int> ni = new List<int> { 1, 2, 3, 4, 5 };

      NUnitTest1 results = new NUnitTest1();
      for (int i = 0; i < Res.Count; i++) {
        NUnit.Framework.Assert.AreEqual(Res[i], MaBibliothequeATester.Math.Factorielle(ni[i]));
      }
     
      //int result = MaBibliothequeATester.Math.Factorielle(n);
      //NUnit.Framework.Assert.AreEqual(expected, result);
                                                            

    }

    [Test]
    [TestCase(1,1)]
    [TestCase(2, 2)]
    [TestCase(3, 6)]
    [TestCase(4, 24)]
    public void TestMethodFactorielle_V2(int n, int res) {
      NUnit.Framework.Assert.AreEqual(res, MaBibliothequeATester.Math.Factorielle(n));
    }

  }
}