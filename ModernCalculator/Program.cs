using System;

namespace ModernCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    Hello......   \nYou can calculate anything\n\n\n\n");
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    bool logic=true;
                    if (logic)
                    {
                        Console.WriteLine("Enter what do you want to : \n1 for add\n" +
                        "2 for multiply\n3 for Substraction\n4 for Division");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Your First Number");

                        double firstNumber;
                        firstNumber=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Your Secound Number");
                        double secoundNumber = Convert.ToDouble(Console.ReadLine());
                        if (x == 1)
                        {
                            double total = add(firstNumber, secoundNumber);
                            Console.WriteLine(total);

                        }
                        else if (x == 2)
                        {
                            double total = multply(firstNumber, secoundNumber);
                            Console.WriteLine(total);

                        }
                        else if (x == 3)
                        {
                            double total = substraction(firstNumber, secoundNumber);
                            Console.WriteLine(total);
                        }
                        else if (x == 4)
                        {
                            double total = division(firstNumber, secoundNumber);
                            Console.WriteLine(total);
                        }
                        else
                        {
                            Console.WriteLine("Press wrong number");
                        }
                        Console.WriteLine("Enter 1 to coutinue calculation or any number to exit ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y == 1)
                        {
                            continue;
                        }
                        else
                        {
                            i = 111;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            static double  add(double firstnumber,double secondnumber) 
            {
                return firstnumber + secondnumber;
            }
            static double multply(double firstnumber, double secondnumber)
            {
                return firstnumber * secondnumber;
            }
            static double substraction(double firstnumber, double secondnumber)
            {
                return firstnumber - secondnumber;
            }
            static double division(double firstnumber, double secondnumber)
            {
                return firstnumber / secondnumber;
            }
        }
    }
}
