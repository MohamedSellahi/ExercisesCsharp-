using Microsoft.VisualStudio.TestTools.UnitTesting;
using Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Accounts.Tests {
  [TestClass()]
  public class CheckingAccountTests {

    [TestMethod()]
    public void WhithdrawTest() {
      // arrange
      double currentBalance = 10.0;
      double withdrawal = 1.0;
      double excpected = 9.0;

      CheckingAccount account = new CheckingAccount("Bob", 10);
      // act
      account.Whithdraw(withdrawal);
      double actual = account.Balance;

      // assert
      Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(excpected, actual);

    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentException))]

    public void WithDrawAmmountMorThanBalanceThrows() {
      // arrange
      var account = new CheckingAccount("John Does", 10.0);
      double withdrawal = 20.0;
      // act
      account.Whithdraw(withdrawal);
      // assert is handeled by ExpectedException
    }


    [TestMethod()]
    
    public void ParameterizedWhithdrawTest() {
      // arrange
      double widrawal = 8.0;
      double expected = 2.0;

      var account = new CheckingAccount("John Doe", 10.0);
      //act
      account.Whithdraw(widrawal);
      double result = account.Balance;

      // assert 
      NUnit.Framework.Assert.AreEqual(expected, result);


    }
  }

}
