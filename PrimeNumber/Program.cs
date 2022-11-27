using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter the Start Limit:");
            int Startlimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter the End Limit:");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int i = Startlimit; i <= limit; i++)
            {
                bool isPrimeNumber = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.ReadKey();
        }
    }
}
