using System;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int start1=0, start2=1, total =0;
            Console.WriteLine("Please Set The Limite!");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < limit-2; i++)
            {
                if (start1 == 0 && start2 == 1)
                {
                    Console.Write(start1 + " " + start2);
                }
                total = start1+start2 ;
                start1 = start2;
                start2 = total;  
                if (total < 0)
                {
                    Console.WriteLine(" "+"Negative Number");
                    break;
                }
                Console.Write(" "+total);
            }
            Console.ReadKey();
        }
    }
}
