using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculatorUi
{
   public class MyCalculatorViewModel
   {
      private decimal _currentResult;

      public string GetCurrentResult()
      {
         return _currentResult.ToString();
      }

      public string GetCurrentResultWithAppendedNumber( string appendedNumber )
      {
         string oldCurrentResult = _currentResult.ToString();
         string newResult = oldCurrentResult + appendedNumber;
         decimal.TryParse( appendedNumber, out _currentResult );
         return _currentResult.ToString();
      }


   }
}
