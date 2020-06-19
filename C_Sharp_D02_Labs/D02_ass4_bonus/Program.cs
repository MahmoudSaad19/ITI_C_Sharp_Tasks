using System;

namespace D02_ass4_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] presentVolume = {4.53, 9.11, 4.53, 6, 1.04, 0.87, 2.57, 19.45 ,
                               65.59, 14.14, 16.66, 13.53 };

            double[] presentPrice = { 12.23, 45.03, 12.23, 32.93, 6.99, 0.46, 7.34,
                           65.98, 152.13, 7.23, 10, 25.25 };

            double budget = 183.23;
            double bagVolume = 64.11;
            int people = 7;
            int Npresents = 12;

            presentList(budget, bagVolume, people,Npresents,
                presentVolume, presentPrice);




            Console.WriteLine("Hello World!");
        }

        public static void presentList(double budget, double bagVolume, int people,
            int Npresents, double[] presentVolume, double[] presentPrice)
        {

        }
    }
}
