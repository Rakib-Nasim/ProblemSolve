using System;

namespace PalendromNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 For Number check and Press 2 for String ");
            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    int number = Convert.ToInt32(Console.ReadLine());
                    int count = number, revarce = 0, remainder = 0;
                    while (count != 0)
                    {
                        remainder = count % 10;
                        count = count / 10;
                        revarce = (revarce * 10) + remainder;
                    }
                    if (revarce == number)
                    {
                        Console.WriteLine("The Number is Palendram");
                    }
                    else
                    {
                        Console.WriteLine("The Number is not Palendram");
                    }
                    break;

                case 2:
                    string text= Console.ReadLine();
                    char[] arr = text.ToCharArray();
                    string newString = "";
                    for (int i = arr.Length-1; i>-1; i--)
                    {
                        newString = newString+ arr[i];
                    }
                    if(text== newString)
                    {
                        Console.WriteLine("The Text is Palendram");
                    }
                    else
                    {
                        Console.WriteLine("The Text is not Palendram");
                    }
                    break;
                default:
                    Console.WriteLine("You Enter wrong number .....Please Type 1 or 2 ");
                    break;
            }
            
            
        }
    }
}
