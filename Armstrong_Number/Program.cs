using System;

namespace Armstrong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder = 0, reverse = number,total=0,powr;
            string lengthCount = number.ToString();
            while (reverse != 0)
            {
                remainder = reverse % 10;
                reverse = reverse / 10;
                powr = lengthCount.Length;
                total = total + Convert.ToInt32((Math.Pow(remainder,powr)));
            }
            if (number == total)
            {
                Console.WriteLine("{0} Is Armstrong ", number);
            }
            else
            {
                Console.WriteLine("{0} Is Not Armstrong ", number);
            }
        }
    }
}
