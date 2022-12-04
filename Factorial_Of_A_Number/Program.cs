using System;

namespace Factorial_Of_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Give Your Number....");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);

        }
    }
    
}
