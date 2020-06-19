using System;
using System.Diagnostics;

namespace D02_ass3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];

            Console.WriteLine("Using String method : ");
            countOnesUsingStrings();
            Console.WriteLine("Using digit divide method : ");
            countOnesUsingdivide();

            Console.WriteLine("Using equation method : ");

            var t = Stopwatch.StartNew();
            t.Start();
            string str = "99999999";
            int c = str.Length ;
            double word = c * Math.Pow(10, c - 1);
            t.Stop();
            Console.WriteLine($"Total number of 1s = {word} ");
            double time = t.ElapsedMilliseconds / 1000.0;
            Console.WriteLine($"Time = {time} s");


        }

        static void countOnesUsingdivide ()
        {
            var t = Stopwatch.StartNew();
            int counter = 0;
            t.Start();
            for (int i = 1; i <= 100_000_000; i++)
            {

                int temp = i;
                while (temp > 0)
                {
                    if (temp % 10 == 1)
                        counter++;
                    temp /= 10;
                }
            }
            t.Stop();
            Console.WriteLine($"Total number of 1s = {counter-1} ");
            double time = t.ElapsedMilliseconds / 1000.0;
            Console.WriteLine($"Time = {time} s");
        }

        static void countOnesUsingStrings ()
        {
            var t = Stopwatch.StartNew();
            int counter = 0;
            t.Start();
            for (int i = 0; i <= 100_000_000; i++)
            {
                string str = i.ToString();
                counter += str.Split("1").Length - 1;             
            }
            t.Stop();
            Console.WriteLine($"Total number of 1s = {counter-1} ");
            double time = t.ElapsedMilliseconds / 1000.0;
            Console.WriteLine($"Time = {time} s");
        }
    }
}
