using System;

namespace SumOfTwoPrimeOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int oneDigite=0 , twoDigite = 0,temporary=number;
            for (int i = 0; i < number; i++)
            {
                oneDigite = i + 1;
                twoDigite = temporary - 1;
                temporary--;
                if (twoDigite == 0)
                {
                    break;
                }
                bool count = true;
                for (int j = 2; j < oneDigite; j++)
                {
                    if (oneDigite % j == 0  )
                    {
                        count = false;
                        break;
                    }
                }
                for (int k = 2; k < twoDigite; k++)
                {
                    if (twoDigite % k == 0 )
                    {
                        count = false;
                        break;
                    }
                }

                if (count)
                {
                    Console.WriteLine("Sum of The Digit {0} and {1} Both are prime \n", oneDigite, twoDigite);
                }
            }
        }
    }
}
