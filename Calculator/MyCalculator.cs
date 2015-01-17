using System;

namespace Calculator
{
   public enum Operation
   {
      Add,
      Equals,
      InitialState,
      Subtract,
      Multiply,
      Divide
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
                return new AdditionStrategy();
             }
             case Operation.Subtract:
             {
                return new SubtractionStrategy();
             }
             case Operation.Multiply:
             {
                return new MultiplicationStrategy();
             }
             case Operation.Divide:
             {
                return new DivisionStrategy();
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

   public class AdditionStrategy : IMathStrategy
   {
      public double Calculate( double x, double y )
      {
         return x + y;
      }
   }

   public class SubtractionStrategy : IMathStrategy
   {
      public double Calculate( double x, double y )
      {
         return x - y;
      }
   }

   public class MultiplicationStrategy : IMathStrategy
   {
      public double Calculate( double x, double y )
      {
         return x * y;
      }
   }

   public class DivisionStrategy : IMathStrategy
   {
      public double Calculate( double x, double y )
      {
         return x / y;
      }
   }
}
