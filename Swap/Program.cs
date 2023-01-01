using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsContinue= true;
            while (IsContinue)
            {
                Console.WriteLine("Enter 1 for number or 2 for text swap");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("Enter First number");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Secound number");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    number1 = number1 * number2;
                    number2 = number1 / number2;
                    number1 = number1 / number2;
                    Console.WriteLine($"After Swap First number = {number1} and second number = {number2}");
                    Console.WriteLine("After Swap First number = {0} and second number = {1}", number1, number2);
                }
                else if (number == 2)
                {
                    Console.WriteLine("Enter First text");
                    string text1 = Console.ReadLine();
                    Console.WriteLine("Enter second text");
                    string text2 = Console.ReadLine();

                    text1 = text1 + text2;
                    text2 = text1.Substring(0, text1.Length - text2.Length);
                    text1 = text1.Substring(text2.Length);
                    Console.WriteLine($"After Swap First text = {text1} and second text = {text2}");
                    Console.WriteLine("After Swap First text = {0} and second text = {1}", text1, text2);
                }
                else
                {
                    Console.WriteLine("You press Wrong Number");
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Press 1 For continue Swapping or any key to exit");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    IsContinue = true;
                }
                else
                {
                    IsContinue = false;
                }
            }
            
        }
    }
}
