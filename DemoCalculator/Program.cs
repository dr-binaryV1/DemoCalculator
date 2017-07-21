using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            var num1 = 6;
            var num2 = 5;

            var result = calc.Addition(num1, num2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
