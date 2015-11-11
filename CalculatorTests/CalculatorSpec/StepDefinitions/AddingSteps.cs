using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator;
using Calculator.Enums;
using WpfCalculatorUi;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace CalculatorTests.CalculatorSpec.StepDefinitions
{
   [Binding]
   public class AddingSteps
   {
      // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

      [Given( @"I have started the calculator" )]
      public void GivenIHaveStartedTheCalculator()
      {
         ScenarioContext.Current.Add( "viewModel", new MyCalculatorViewModel( new MyCalculator() ) );
      }

      [When( @"I enter the number ""(.*)""" )]
      public void WhenIEnterTheNumber( string number )
      {
         var calc = ScenarioContext.Current.Get<MyCalculatorViewModel>( "viewModel" );
         calc.NumberIsEntered( number );
      }

      [When( @"I press the ""(.*)"" button" )]
      public void WhenIPressTheButton( string operatorName )
      {
         var calc = ScenarioContext.Current.Get<MyCalculatorViewModel>( "viewModel" );
         Operation operation;
         Enum.TryParse<Operation>( operatorName, out operation );
         calc.OperatorIsEntered( operation );
      }

      [When( @"I hit the equals button" )]
      public void WhenIHitTheEqualsButton()
      {
         var calc = ScenarioContext.Current.Get<MyCalculatorViewModel>( "viewModel" );
         double result;
         double.TryParse( calc.EqualsIsEntered(), out result );
         ScenarioContext.Current.Add( "actualResult", result );
      }


      [Then( @"the result should be ""(.*)""" )]
      public void ThenTheResultShouldBe( int expectedResult )
      {
         var actualResult = ScenarioContext.Current.Get<double>( "actualResult" );
         actualResult.Should().Be( expectedResult );
         
      }

   }
}
