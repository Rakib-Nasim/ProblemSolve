using System;

namespace ReverseOfAString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Way=1
            //Console.WriteLine("Put Your String");
            //string str1 = Console.ReadLine();
            //char[] cr1 = str1.ToCharArray();
            //string str2 = "";
            //int index = cr1.Length;
            //for (int i = 0; i < cr1.Length; i++)
            //{
            //    str2 =str2+(cr1[index - 1]).ToString();
            //    index--;
            //}
            //Console.WriteLine("str2");


            //2nd way reverse
            Console.WriteLine("Put Your String");
            string str1 = Console.ReadLine();
            char[] cr1 = str1.ToCharArray();
            string str2 = "";
            for (int i = cr1.Length - 1; i > -1; i--)
            {
                str2 = str2 + cr1[i].ToString();
            }
            Console.WriteLine(str2);

            //3rd way
            //Console.WriteLine("Put Your String");
            //string str1 = Console.ReadLine();
            //char[] cr1 = str1.ToCharArray();
            //string str2 =string.Empty;
            //int index = cr1.Length;
            //while (index>0)
            //{
            //    str2 = str2 + cr1[index - 1];
            //    index--;
            //}
            //Console.WriteLine(str2);
        }
    }
}
