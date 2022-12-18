using System;

namespace BubbleSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbersArr = { 8, 2, 5, 10, 9, 7, 6, 4, 1, 3 };
                for (int j = 0; j < numbersArr.Length-1; j++)
                {
                    for (int i = 0; i < numbersArr.Length - 1; i++)
                    {
                        int number1 = 0;
                        int number2 = 0;
                        if (numbersArr[i] > numbersArr[i + 1])
                        {
                            number1 = numbersArr[i];
                            number2 = numbersArr[i + 1];
                            numbersArr[i] = number2;
                            numbersArr[i + 1] = number1;
                        }
                    } 

                }
                
                foreach (int item in numbersArr)
                {
                    Console.Write(" " + item);
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
