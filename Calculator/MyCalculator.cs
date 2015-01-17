using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public enum Operation
   {
      Add
   }
    public class MyCalculator
    {
       private double _currentResult;

       public MyCalculator()
       {
          _currentResult = 0;
       }

       public double GetResult()
       {
          return _currentResult;
       }

       public void SetCurrentNumber( int number )
       {
          _currentResult = number;
       }

       public void SetCurrentOperation( Operation operation )
       {
          throw new NotImplementedException();
       }
    }
}
