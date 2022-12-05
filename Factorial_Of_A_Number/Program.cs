using System;

namespace Factorial_Of_A_Number
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Please Give Your Number....");
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    int result = 1;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        result = result * i;
        //    }
        //    Console.WriteLine(result);

        //}
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Brush brush = new Brush();
            Spray spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();

        }
        public interface IDraw
        {
            void StartDraw();
        }

        class Draw : IDraw
        {
            public virtual void StartDraw()
            {
                Console.WriteLine("Using pencil");
            }
        }

        //inherit this class from the class Draw
        class Brush : IDraw
        {
            public virtual void StartDraw()
            {
                Console.WriteLine("Using brush");
            }

        }

        //inherit this class from the class Draw
        class Spray : IDraw
        {
            public virtual void StartDraw()
            {
                Console.WriteLine("Using spray");
            }


        }
    }
    





}
    

