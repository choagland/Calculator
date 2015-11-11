using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.MathStrategies
{
   public interface IMathStrategy
   {
      double Calculate( double x, double y );
   }
}
