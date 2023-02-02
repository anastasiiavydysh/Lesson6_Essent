//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Потрібно: Створити статичний клас Calculator, з методами виконання основних арифметичних операцій. 
//    Написати програму, яка виводить на екран основні арифметичні операції.

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            Calculator.Calculate(a, b, "+");
            Calculator.Calculate(a, b, "-");
            Calculator.Calculate(a, b, "*");
            Calculator.Calculate(a, b, "/");
            Calculator.Calculate(a, b, "^");
            Calculator.Calculate(a, 0, "/");
        }
    }
}