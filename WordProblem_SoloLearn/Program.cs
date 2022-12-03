using System;

namespace WordProblem_SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();
            int number = 0;
            foreach (var item in words)
            {
                if (item.Contains(letter))
                {
                    Console.WriteLine(item);
                    number++;
                }
                
            }
            if (number == 0)
            {
                Console.WriteLine("No match");
            }
            
            Console.ReadKey();
            
        }
    }
}
