using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.Enums;

namespace WpfCalculatorUi
{
   public class MyCalculatorViewModel
   {
      private int _currentResult;
      private readonly MyCalculator _myCalculator;

      public MyCalculatorViewModel( MyCalculator myCalculator )
      {
         _myCalculator = myCalculator;
         _currentResult = 0;
      }

      public string GetInitialResult()
      {
         return _currentResult.ToString();
      }

      public string NumberIsEntered( string appendedNumber )
      {
         string oldCurrentResult = _currentResult.ToString();
         string newResult = oldCurrentResult + appendedNumber;
         int.TryParse( appendedNumber, out _currentResult );
         return _currentResult.ToString();
      }

      public string OperatorIsEntered( Operation operation )
      {
         _myCalculator.SetCurrentNumber( _currentResult );
         _myCalculator.SetCurrentOperation( operation );
         return _myCalculator.GetResult().ToString();
      }

      public string EqualsIsEntered()
      {
         string result;
         _myCalculator.SetCurrentNumber( _currentResult );
         result = _myCalculator.GetResult().ToString();
         _myCalculator.SetCurrentNumber( 0 );
         _myCalculator.SetCurrentOperation( Operation.InitialState );
         return result;
      }
   }
}
