using System;

namespace Calculator
{
    class Calculator
    {
        public int a;
        public int b;

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public double Div(int a, int b)
        {
            return (double)a / (double)b;
        }
    }
}
