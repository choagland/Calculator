using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Enums;

namespace Calculator.MathStrategies
{
   public class MathStrategyFactory
   {
      public IMathStrategy SelectMathStrategy( Operation operation )
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
}
