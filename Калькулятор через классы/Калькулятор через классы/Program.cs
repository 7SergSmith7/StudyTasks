using System;

namespace Калькулятор_через_классы
{
    class AddArgument
    {
        double argument;

        public void SetAgrument(string value)
        {

            argument = Convert.ToDouble(value);
        }
        public double GetArgument()
        {
            return argument;
        }
    }

    class Result
    {
        double a;
        double b;
        string sign;
        double result;
        

        public void SetResult(double firstArgument, double secondArgument, string operationsign )
        {
            a = firstArgument;
            b = secondArgument;
            sign = operationsign;
            

            switch (operationsign)
            {
                case "+":
                    result = firstArgument + secondArgument;
                    break;
                case "-":
                    result = firstArgument - secondArgument;
                    break;
                case "/":
                    result = firstArgument / secondArgument;
                    break;
                case "*":
                    result = firstArgument * secondArgument;
                    break;

            }
        }
        public void GetResult()
        {
            Console.WriteLine($"{a}{sign}{b}={result}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AddArgument firstArgument = new AddArgument();
            AddArgument secondArgument = new AddArgument();
            Result resultTask = new Result();
            Console.WriteLine("Введите Первый аргумент");
            firstArgument.SetAgrument( Console.ReadLine());
            Console.WriteLine("Введите Второй аргумент");
            secondArgument.SetAgrument(Console.ReadLine());
            Console.WriteLine("Введите Операцию (+,-,/,*)");
            resultTask.SetResult(firstArgument.GetArgument(), secondArgument.GetArgument(), Console.ReadLine());
            resultTask.GetResult();
        }
    }
}
