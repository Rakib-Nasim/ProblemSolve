using System;

namespace PasswordProblem_SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };

            for (int i = 0; i < notAllowedSymbols.Length; i++)
            {
                if (password.Contains(notAllowedSymbols[i]))
                {
                    Console.WriteLine("Invalid");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
