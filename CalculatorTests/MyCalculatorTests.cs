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

      [TestMethod]
      public void GetResult_TwoNumbersAddedTogether_ReturnsTheirSum()
      {
         var calc = new MyCalculator();
         calc.SetCurrentNumber( 1 );
         calc.SetCurrentOperation( Operation.Add );
         calc.SetCurrentNumber( 2 );
         calc.GetResult().Should().Be( 3 );
      }

      [TestMethod]
      public void GetResult_ThreeNumbersAddedTogether_ReturnsTheirSum()
      {
         var calc = new MyCalculator();
         calc.SetCurrentNumber( 1 );
         calc.SetCurrentOperation( Operation.Add );
         calc.SetCurrentNumber( 2 );
         calc.SetCurrentOperation( Operation.Add );
         calc.SetCurrentNumber( 3 );
         calc.GetResult().Should().Be( 6 );
      }

      [TestMethod]
      public void GetResult_TwoNumbersSubtracted_ReturnsTheirDifference()
      {
         var calc = new MyCalculator();
         calc.SetCurrentNumber( 5 );
         calc.SetCurrentOperation( Operation.Subtract );
         calc.SetCurrentNumber( 3 );
         calc.GetResult().Should().Be( 2 );
      }

      [TestMethod]
      public void GetResult_TwoNumbersMultiplied_ReturnsTheirProduct()
      {
         var calc = new MyCalculator();
         calc.SetCurrentNumber( 2 );
         calc.SetCurrentOperation( Operation.Multiply );
         calc.SetCurrentNumber( 3 );
         calc.GetResult().Should().Be( 6 );
      }

      [TestMethod]
      public void GetResult_TwoNumbersDivided_ReturnsTheirQuotient()
      {
         var calc = new MyCalculator();
         calc.SetCurrentNumber( 6 );
         calc.SetCurrentOperation( Operation.Divide );
         calc.SetCurrentNumber( 2 );
         calc.GetResult().Should().Be( 3 );
      }

      [TestMethod]
      public void GetResult_TwoNumbersExponentiated_ReturnsFirstNumberRaisedToSecondNumbersPower()
      {
         var calc = new MyCalculator();
         calc.SetCurrentNumber( 3 );
         calc.SetCurrentOperation(Operation.Exponent);
         calc.SetCurrentNumber( 4 );
         calc.GetResult().Should().Be( 81 );
      }
   }
}
