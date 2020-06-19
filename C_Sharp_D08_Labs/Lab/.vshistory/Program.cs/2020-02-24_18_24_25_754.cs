using System;
using System.Linq;
using System.Reflection;
using static Lab.ListGenerators;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 ctr = 1;
            MethodInfo[] infos = typeof(Enumerable).GetMethods();
            foreach (var i in infos)
            {
                //if ()
                Console.WriteLine(i.Name);

            }
        }
    }
}
