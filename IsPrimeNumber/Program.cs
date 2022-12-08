using System;

namespace IsPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool count =true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    count = false;
                    Console.WriteLine("Number: {0} is not Prime Number ", number);
                    break;
                }
            }
            if (count)
            {
                Console.WriteLine("Number: {0} is Prime Number ", number);
            }
        }
    }
}
