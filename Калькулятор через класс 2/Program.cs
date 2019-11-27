using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            char act;
            Console.WriteLine("Enter first element:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second element:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter action:");
            act =Convert.ToChar( Console.ReadLine());

            switch(act)
            {
                case '+':
                    Console.WriteLine(Calculator.Add(a, b)); 
                    break;
                case '-':
                    Console.WriteLine(Calculator.Minus(a, b));
                    break;
                case '*':
                    Console.WriteLine(Calculator.Multy(a, b));
                    break;
                case '/':
                    Console.WriteLine(Calculator.Div(a, b));
                    break;
                default:
                    Console.WriteLine("Enter rigth sign.");
                    break;

            }
        }
    }
}
