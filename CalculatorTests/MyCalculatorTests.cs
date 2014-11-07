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
         calc.GetResult().Should().Be(0);
      }
   }
}
