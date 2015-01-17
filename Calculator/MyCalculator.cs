using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MyCalculator
    {
       private double CurrentResult;

       public MyCalculator()
       {
          CurrentResult = 0;
       }

       public double GetResult()
       {
          return CurrentResult;
       }

       public void SetCurrentNumber( int number )
       {
          throw new NotImplementedException();
       }
    }
}
