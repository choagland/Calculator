using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CalculatorTests.CalculatorSpec.StepDefinitions
{
   [Binding]
   public class AddingSteps
   {
      // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

      [Given(@"I have started the calculator")]
      public void GivenIHaveStartedTheCalculator()
      {
         ScenarioContext.Current.Pending();
      }

      [When(@"I enter the number ""(.*)""")]
      public void WhenIEnterTheNumber(int p0)
      {
         ScenarioContext.Current.Pending();
      }

      [When(@"I press the ""(.*)"" button")]
      public void WhenIPressTheButton(string p0)
      {
         ScenarioContext.Current.Pending();
      }

      [When(@"I hit the ""(.*)"" button")]
      public void WhenIHitTheButton(string p0)
      {
         ScenarioContext.Current.Pending();
      }

      [Then(@"the result should be ""(.*)""")]
      public void ThenTheResultShouldBe(int p0)
      {
         ScenarioContext.Current.Pending();
      }

   }
}
