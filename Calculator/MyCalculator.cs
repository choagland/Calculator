using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public enum Operation
   {
      Add,
      Equals,
      InitialState
   }
    public class MyCalculator
    {
       private double _currentResult;
       private IMathStrategy _currentMathStrategy;

       public MyCalculator()
       {
          _currentResult = 0;
          _currentMathStrategy = new InitialMathStrategy();
       }

       public double GetResult()
       {
          return _currentResult;
       }

       public void SetCurrentNumber( int number )
       {
          _currentResult = _currentMathStrategy.Calculate( _currentResult, number );
       }

       public void SetCurrentOperation( Operation operation )
       {
          _currentMathStrategy = SelectMathStrategy( operation );
       }

       private IMathStrategy SelectMathStrategy( Operation operation )
       {
          switch ( operation )
          {
             case Operation.InitialState:
             {
                return new InitialMathStrategy();
             }
             case Operation.Add:
             {
                return new AddingStrategy();
             }
             default:
             {
                throw new NotImplementedException();
             }
          }
       }
    }

   public interface IMathStrategy
   {
      double Calculate( double x, double y );
   }

   public class InitialMathStrategy : IMathStrategy
   {
      public double Calculate( double x, double y )
      {
         return y; //because before an operation is specified you'll always want the only number
      }
   }

   public class AddingStrategy : IMathStrategy
   {
      public double Calculate( double x, double y )
      {
         return x + y;
      }
   }
}
