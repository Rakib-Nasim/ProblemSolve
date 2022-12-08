using System;

namespace Armstrong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder = 0, reverse = number,total=0;
            while (reverse != 0)
            {
                remainder = reverse % 10;
                reverse = reverse / 10;
                total = total + (remainder * remainder * remainder);
            }
            if (number == total)
            {
                Console.WriteLine("Is Armstrong {0}", number);
            }
            else
            {
                Console.WriteLine("Is Not Armstrong {0}", number);
            }



        }
    }
}
