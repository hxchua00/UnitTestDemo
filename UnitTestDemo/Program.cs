using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class Program
    {
        public static int addResult, subResult, mulResult, divResult;
        public static ICalculator calc;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Integer: ");
            string integer1 = Console.ReadLine();
            Console.WriteLine("Enter the Second Integer: ");
            string integer2 = Console.ReadLine();
            int a = int.Parse(integer1);
            int b = int.Parse(integer2);
            calc = new Calculator();
            CalculatorManagement mgmt= new CalculatorManagement(calc);
            mgmt.CallCalculatorMethods(a,b);
            Console.ReadLine();
        }

        public static void CallCalculatorMethods(int a, int b)
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
