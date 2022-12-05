using System;

namespace Sum_of_Digits_of_a__given__Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Give Your Number");
            int number = Convert.ToInt32(Console.ReadLine());

            int remainder = 0, newnumber = 0,sum=0,revarce=0;
            while (number != 0)
            {
                remainder = number % 10;
                sum = sum + remainder;
                revarce = (revarce * 10) + remainder;
                newnumber = number / 10;
                number = newnumber;
            }
            Console.WriteLine(sum);
            Console.WriteLine(revarce);


        }
    }
}
