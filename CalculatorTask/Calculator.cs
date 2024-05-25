using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    public class Calculator<T> where T : INumber<T>
    {
        public T NumberOne { get; set; }
        public T NumberTwo { get; set; }

        public Calculator(T numberOne, T numberTwo)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
        }

        public void Sum()
        {
            Console.WriteLine($"{NumberOne} + {NumberTwo} = {NumberOne + NumberTwo}");
        }

        public void Multible()
        {
            Console.WriteLine($"{NumberOne} * {NumberTwo} = {NumberOne * NumberTwo}");
        }

        public void Substract()
        {
            Console.WriteLine($"{NumberOne} - {NumberTwo} = {NumberOne - NumberTwo}");
        }

        public void Divide()
        {
            Console.WriteLine($"{NumberOne} / {NumberTwo} = {NumberOne / NumberTwo}");
        }
    }
}

