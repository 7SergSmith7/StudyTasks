using System;

namespace Калькулятор_через_классы
{
    class AddArgument
    {
       public double Argument { get; set;}
    }

    class Calculator
    {
        static public double Add(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
        static public double Minus(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
        static public double Multi(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
        static public double Division(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            AddArgument firstArgument = new AddArgument();
            AddArgument secondArgument = new AddArgument();
            Calculator calculator = new Calculator();
            Console.WriteLine("Введите Первый аргумент");
            firstArgument.Argument = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Второй аргумент");
            secondArgument.Argument = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Операцию (+,-,/,*)");
            string operationsign = Console.ReadLine();
            switch (operationsign)
            {
                case "+":
                    Console.WriteLine($"{firstArgument.Argument}+{secondArgument.Argument}={Calculator.Add(firstArgument.Argument, secondArgument.Argument)}");
                    break;
                case "-":
                        Console.WriteLine($"{firstArgument.Argument}-{secondArgument.Argument}={Calculator.Minus(firstArgument.Argument, secondArgument.Argument)}");
                        break;
                case "/":
                        Console.WriteLine($"{firstArgument.Argument}/{secondArgument.Argument}={Calculator.Division(firstArgument.Argument, secondArgument.Argument)}");
                        break;
                case "*":
                        Console.WriteLine($"{firstArgument.Argument}*{secondArgument.Argument}={Calculator.Multi(firstArgument.Argument, secondArgument.Argument)}");
                        break;

            }
        }
    }
}
