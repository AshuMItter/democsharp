using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class Interfaces
    {
    }
    //definition
    interface ICalc
    {
        void Add(int num1, int num2);
        void Subtract(int num2, int num1);
    }
    //definition
    interface ICalcB
    {
        void Divide(int num2, int num1);
        void Multiply(int num1, int num2);
    }
    //implementation
    class CalculatorA : ICalc, ICalcB
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("From CalcuatorA");
            // throw new NotImplementedException();
        }

        public void Divide(int num2, int num1)
        {
            // throw new NotImplementedException();
        }

        public void Multiply(int num1, int num2)
        {
            // throw new NotImplementedException();
        }

        public void Subtract(int num2, int num1)
        {
            // throw new NotImplementedException();
        }
    }
    //implementation
    class CalculatorB : ICalc, ICalcB
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("From CalculatorB");
            //  throw new NotImplementedException();
        }

        public void Divide(int num2, int num1)
        {
            //throw new NotImplementedException();
        }

        public void Multiply(int num1, int num2)
        {
            // throw new NotImplementedException();
        }

        public void Subtract(int num2, int num1)
        {
            //  throw new NotImplementedException();
        }
    }

}
