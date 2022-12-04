using System;

namespace UserType_PassInConstructor_SoloLearnPblm
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = new DancerPoints(dancer1, dancer2);
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }
    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public DancerPoints(DancerPoints dencer1, DancerPoints dancer2)
        {
            this.name = dencer1.name + " & " + dancer2.name;
            this.points = dencer1.points + dancer2.points;
        }

    }
}
