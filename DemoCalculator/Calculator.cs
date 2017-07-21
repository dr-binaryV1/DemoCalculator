using System;

namespace DemoCalculator
{
    public class Calculator
    {
        public int Addition(int num1, int num2)
        {
            if (num1 < 0 || num2 < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot accept negative values.");
            }
            return num1 + num2;
        }


        public int Division(int num1, int num2)
        {
            if(num1.Equals(0) || num2.Equals(0))
            {
                throw new ArgumentException("0 is not a valid divisor. Please enter a valid number");
            }

            return num1 / num2;
        }

        public int Multiplication(int num1, int num2)
        {
            if(num1.Equals(0) || num2.Equals(0))
            {
                throw new ArgumentException("Cannot multiply with 0. Zero multiply anything is 0.");
            }

            if(num1 > 12 || num2 > 12)
            {
                throw new ArgumentOutOfRangeException("Enter a number thats not greater than 12");
            }
            return num1 * num2;
        }
    }
}
