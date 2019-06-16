using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Калькулятор v.0.1");
                Console.WriteLine("Введите число 1");
                string num1s = Console.ReadLine();
                double num1 = Convert.ToDouble(num1s);
                Console.WriteLine("Введите число 2");
                string num2s = Console.ReadLine();
                double num2 = Convert.ToDouble(num2s);
                Console.WriteLine("Выбирете операцию (+, -, /, *)");
                string act = Console.ReadLine();
                double result;
                switch (act)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine(num1 + " + " + num2 + " = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine(num1 + " - " + num2 + " = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine(num1 + " * " + num2 + " = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        if (num2 == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя");
                        }
                        else
                        {
                            Console.WriteLine(num1 + " / " + num2 + " = " + result);
                        }
                        break;
                }
                Console.WriteLine("Повторить? Да(y) / Нет(n)");
            } while (Console.ReadLine() == "y");
        }
    }
}
