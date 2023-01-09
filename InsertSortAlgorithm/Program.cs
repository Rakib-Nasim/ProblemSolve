using System;

namespace InsertSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numbers ={ 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        int temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
