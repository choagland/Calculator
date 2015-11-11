using System;
using Calculator.Enums;
using Calculator.MathStrategies;

namespace Calculator
{
    public class MyCalculator
    {
       private double _currentResult;
       private IMathStrategy _currentMathStrategy;
       private MathStrategyFactory _mathStrategyFactory;

       public MyCalculator()
       {
          _currentResult = 0;
          _mathStrategyFactory = new MathStrategyFactory();
          _currentMathStrategy = _mathStrategyFactory.SelectMathStrategy( Operation.InitialState );
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
          _currentMathStrategy = _mathStrategyFactory.SelectMathStrategy( operation );
       }

    }

   

   
}
