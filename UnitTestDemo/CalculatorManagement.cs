using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class CalculatorManagement
    {
        private ICalculator calc;
        public int addResult, subResult, mulResult, divResult;

        public CalculatorManagement(ICalculator calculator)
        {
            calc = calculator;
        }

        public void CallCalculatorMethods(int a, int b)
        {
            addResult = calc.Add(a, b);
            Console.WriteLine("Add: " + addResult);
            subResult = calc.Sub(a, b);
            Console.WriteLine("Sub: " + subResult);
            mulResult = calc.Multiply(a, b);
            Console.WriteLine("Multiply: " + mulResult);
            divResult = calc.Divide(a, b);
            Console.WriteLine("Divide: " + divResult);
        }

    }
}
