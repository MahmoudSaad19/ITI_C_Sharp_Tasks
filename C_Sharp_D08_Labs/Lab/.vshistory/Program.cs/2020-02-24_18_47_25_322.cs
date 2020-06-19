using System;
using System.Collections.Generic;
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
            var list = new List<MethodInfo>(infos);
            foreach (var i in list.Distinct())
            {
                //if ()
                Console.WriteLine(i.Name);

            }
        }
    }
}
