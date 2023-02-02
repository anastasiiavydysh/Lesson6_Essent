using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public static class Calculator
    {
        public static void Calculate(int a, int b, string operation)
        {             
            switch (operation)
            {
                case "+":
                    Add(a, b);
                    break;
                case "-":
                    Subtraction(a, b);
                    break;
                case "*":
                    Multiplication(a, b);
                    break;
                case "/":
                    if(b!=0)
                        Divide(a, b);
                    else
                        Console.WriteLine("Divide by 0!");
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    break;
            }
        }

        private static void Add(this int a, int b)
        {
            Console.WriteLine("Result = "+ (a + b));
        }
        private static void Subtraction(this int a, int b)
        {
            Console.WriteLine("Result = " + (a - b));
        }
        private static void Multiplication(this int a, int b)
        {
            Console.WriteLine("Result = " + (a * b));
        }
        private static void Divide(this int a, int b)
        {
            Console.WriteLine("Result = " + (a / b));
        }
    }
}
