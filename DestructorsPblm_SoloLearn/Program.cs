using System;

namespace DestructorsPblm_SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] finalists = { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };
            int winner = Convert.ToInt32(Console.ReadLine());
            FinalRound finalRound = new FinalRound(finalists, winner);
           
        }
    }
    class FinalRound
    {
        public FinalRound(string[] finalists, int winner)
        {
            Console.WriteLine("Winner is " + finalists[winner]);
        }
        ~FinalRound()
        {
            Console.WriteLine("Game Over");
        }
        
    }
}
