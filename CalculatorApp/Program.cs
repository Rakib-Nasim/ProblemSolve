using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    class Program
    {
        public static void Main()
        {
            //1st pblm
            //string[] sdata = new string[2];
            //string data = Console.ReadLine();
            //sdata = data.Split(' ');
            //double a = double.Parse(sdata[0]);
            //double b = double.Parse(sdata[1]);
            //double c = 0.50;
            //double d = b - (a + c);
            //if (d >= 0 && (a % 5) == 0)
            //{
            //    Console.WriteLine(d);
            //}
            //else
            //{
            //    Console.WriteLine(b);
            //}


            //2nd pblm
            //string[] n = Console.ReadLine().Split(' ');
            //float a = float.Parse(n[0]);
            //float b = float.Parse(n[1]);
            //float c = 0.50f;
            //float d = b - (a + c);
            //if (d >= 0 && (int.Parse(n[0]) % 5) == 0)
            //    Console.WriteLine(d.ToString("f"));
            //else
            //    Console.WriteLine(b.ToString("f"));


            //3rd pblm
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    string[] sdata = new string[2];
            //    string data = Console.ReadLine();
            //    sdata = data.Split(' ');
            //    int a = int.Parse(sdata[0]);
            //    int b = int.Parse(sdata[1]);
            //    if (a >= b)
            //    {
            //        Console.WriteLine("YES");
            //    }
            //    else
            //    {
            //        Console.WriteLine("NO");
            //    }
            //}

            //4th pblm
            //string[] parts = Console.ReadLine().Split();
            //uint n = UInt32.Parse(parts[0]);
            //uint k = UInt32.Parse(parts[1]);
            //uint ans = 0;
            //for (uint i = 0; i < n; i++)
            //{
            //    uint t = UInt32.Parse(Console.ReadLine());

            //    if (t % k == 0)
            //        ans++;
            //}
            //Console.WriteLine(ans);

            //5th pblm
            //int t = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < t; i++)
            //{
            //    string[] data = Console.ReadLine().Split();
            //    int N = Convert.ToInt32(data[0]);
            //    int M = Convert.ToInt32(data[1]);
            //    int K = Convert.ToInt32(data[2]);
            //    if (N<=(M-K))
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}

            //6th pblm
            //int x = Convert.ToInt32(Console.ReadLine());
            //if ( x+7>170)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //7th pblm
            //int x = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < x; i++)
            //{
            //    int y = Convert.ToInt32(Console.ReadLine());
            //    if (y <= 15)
            //    {
            //        Console.WriteLine("No");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //}

            //8th pblm
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                string[] Data = new string[2];
                string strn = Console.ReadLine();
                Data = strn.Split(' ');
                int a = Convert.ToInt32(Data[0]);
                int b = Convert.ToInt32(Data[1]);
                if (b <= a * 1.07)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

            //9th
            //int x = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < x; i++)
            //{
            //    string[] data = Console.ReadLine().Split();
            //    string[] match = Console.ReadLine().Split();
            //    int a = Convert.ToInt32(data[0]);
            //    int b = Convert.ToInt32(data[1]);
            //    int c= Convert.ToInt32(match[0]);
            //    int d= Convert.ToInt32(match[1]);
            //    if (a<=c && b<=d)
            //    {
            //        Console.WriteLine("POSSIBLE");
            //    }
            //    else
            //    {
            //        Console.WriteLine("IMPOSSIBLE");
            //    }
            //}

            //10 th Self Defence Training
            //int cas = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < cas; i++)
            //{
            //    Console.WriteLine("give total people");
            //    int N = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("give value");
            //    string[] t = new string[N];
            //    t = Console.ReadLine().Split(' ');
            //    List<int> total = new List<int>();
            //    foreach (string item in t)
            //    {
            //        int k = Convert.ToInt32(item);
            //        if (k >= 10 && k <= 60)
            //        {
            //            Console.WriteLine(k);
            //            total.Add(k);
            //        }
            //    }
            //    Console.WriteLine(total.Count);
            //}

            //11th pelendrom pblm
            //int n, r, sum = 0, temp;
            //Console.Write("Enter the Number: ");
            //n = int.Parse(Console.ReadLine());
            //temp = n;
            //while (n > 0)
            //{
            //    r = n % 10;
            //    sum = (sum * 10) + r; 
            //    n = n / 10;
            //}
            //if (temp == sum)
            //{
            //    Console.Write("Number is Palindrome.");
            //}

            //else
            //{
            //    Console.Write("Number is not Palindrome");
            //}

            //    int[] arr = { 78, 55, 45, 98, 13 };
            //    int temp;

            //    for (int j = 0; j <= arr.Length - 2; j++)
            //    {
            //        for (int i = 0; i <= arr.Length - 2; i++)
            //        {
            //            if (arr[i] > arr[i + 1])
            //            {
            //                temp = arr[i + 1];
            //                arr[i + 1] = arr[i];
            //                arr[i] = temp;
            //            }
            //        }
            //        foreach (int p in arr)
            //            Console.Write(p + " ");
            //    }
            //    Console.WriteLine("Sorted:");
            //    foreach (int p in arr)
            //        Console.Write(p + " ");



            //int[,] arr = new int[3, 3];
            //arr[0, 1] = 10;
            //arr[1, 2] = 20;
            //arr[2, 0] = 30; 
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}



            //int number = Convert.ToInt32(Console.ReadLine());
            //string divi;
            //for (int i = 1; i <= number; i++)
            //{
            //    int a = i;
            //    if (a % 3 == 0)
            //    {
            //        divi = Convert.ToString(a);
            //        divi = "*";
            //        Console.Write(divi);
            //    }
            //    else
            //    {
            //        Console.Write(a);
            //    }
            //}



            //last pblm
            //int salaryBudget = Convert.ToInt32(Console.ReadLine());
            //int percent = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Before the increase: " + salaryBudget);
            //Increase(ref salaryBudget, percent);

            //Console.WriteLine("After the increase: " + salaryBudget);

        }
        //static void Increase(ref int before, int incPer)
        //{
        //    before = before * (incPer + 100) / 100;
        //}

    }
}

