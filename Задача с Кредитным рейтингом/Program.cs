using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество клиентов:");
            string ns = Console.ReadLine();
            int n = Convert.ToInt32(ns);
            Console.WriteLine("Количество клиентв равно " + n);
            Random rand = new Random();
            double[] clientsRanc = new double[n];
            double [] clientsWant = new double[n];
            bool[] clientAnswer = new bool[n];
            for (int i = 0; i < n; i++)
            {
                clientsRanc[i] = rand.Next(1, 10) + rand.NextDouble();
                clientsRanc[i] = Math.Round(clientsRanc[i], 2);
                int numClient = i + 1;
                Console.WriteLine("Клиент " + numClient + " имеет рейтинг " + clientsRanc[i]);
            }
            for (int i = 0; i < n; i++)
            {
                int numClient = i + 1;
                clientsWant[i] = rand.Next(1, 20000);
                Console.WriteLine("Клиент " + numClient + " желает получить " + clientsWant[i] + " грн");
            }

            for (int i = 0; i < n; i++)
            {
                double creditLim = clientsRanc[i] * 2000;
                int numClient = i + 1;
                if (creditLim >= clientsWant[i])
                {
                    Console.WriteLine("Клиент " + numClient + " может получить кредит.");
                }
                else
                {
                    Console.WriteLine("Клиент " + numClient + " НЕ может получить кредит.");
                }
            }
           
        }
    }
}
