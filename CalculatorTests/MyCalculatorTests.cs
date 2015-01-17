using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using FluentAssertions;

namespace CalculatorTests
{
   [TestClass]
   public class MyCalculatorTests
   {
      [TestMethod]
      public void GetResult_Startup_ResultIsZero()
      {
         var calc = new MyCalculator();
         calc.GetResult().Should().Be( 0 );
      }

      [TestMethod]
      public void GetResult_OneNumberEntered_ReturnsThatNumber()
      {
         var calc = new MyCalculator();
         calc.SetCurrentNumber( 3 );
         calc.GetResult().Should().Be( 3 );
      }

      [TestMethod]
      public void GetResult_OneNumberAndAnOperator_StillReturnsThatNumber()
      {
         var calc = new MyCalculator();
         calc.SetCurrentNumber( 3 );
         calc.SetCurrentOperation( Operation.Add );
         calc.GetResult().Should().Be( 3 );
      }
   }
}
