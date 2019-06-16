using System;

namespace ConsoleApp1
{
    class Program
    {
        static void CreatArraysClient(int num)
        {
            double[] clientsRanc = new double[num];
            double[] clientsWant = new double[num];
            bool[] clientAnswer = new bool[num];
            
        }
        static void AddClientRank(double[] array, int num)
        {
            Random rand = new Random();

            for (int i = 0; i < num; i++)
            {
                array[i] = rand.Next(1, 10) + rand.NextDouble();
                array[i] = Math.Round(array[i], 2);
               
            }
        }
        static void ClientsWant(double[] array, int num)
        {
            Random rand = new Random();

            for (int i = 0; i < num; i++)
            {
                array[i] = rand.Next(1, 20000) + rand.NextDouble();
                array[i] = Math.Round(array[i], 2);

            }
        }
        static void ClientAnswer(bool[] clientAnswer, double[] clientsRanc, double[] clientsWant, int num)
        {
            for (int i = 0; i < num; i++)
            {
                double creditLim = clientsRanc[i] * 2000;
                if (creditLim >= clientsWant[i])
                {
                    clientAnswer[i] = true;
                }
                else clientAnswer[i] = false;
            }

        }
        static void Report(bool[] clientAnswer, int num)
        {
            for (int i = 0; i < num; i++)
            {
                
                int numClient = i + 1;
                if (clientAnswer[i] == true)
                {
                    Console.WriteLine( "Клиент " + numClient + " может получить кредит.");
                    
                }
                else
                {
                    Console.WriteLine("Клиент " + numClient + " НЕ может получить кредит.");
                  
                }
                
            }
           
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество клиентов:");
            string ns = Console.ReadLine();
            int n = Convert.ToInt32(ns);
            double[] clientsRanc = new double[n];
            double[] clientsWant = new double[n];
            bool[] clientAnswer = new bool[n];
            Console.WriteLine("Количество клиентв равно " + n);
            Random rand = new Random();
            Program.CreatArraysClient(n);
            Program.AddClientRank(clientsRanc, n);
            Program.ClientsWant(clientsWant, n);
            Program.ClientAnswer(clientAnswer, clientsRanc, clientsWant, n);
            Program.Report(clientAnswer, n);
            /*for (int i = 0; i < n; i++)
            {
                
                int numClient = i + 1;
                Console.WriteLine("Клиент " + numClient + " имеет рейтинг " + clientsRanc[i]);
            }
            for (int i = 0; i < n; i++)
            {
                int numClient = i + 1;
                Console.WriteLine("Клиент " + numClient + " желает получить " + clientsWant[i] + " грн");
            }

            for (int i = 0; i < n; i++)
            {
                
                int numClient = i + 1;
                if (clientAnswer[i] == true)
                {
                    Console.WriteLine("Клиент " + numClient + " может получить кредит.");
                }
                else
                {
                    Console.WriteLine("Клиент " + numClient + " НЕ может получить кредит.");
                }
            }*/
           
        }
    }
}
