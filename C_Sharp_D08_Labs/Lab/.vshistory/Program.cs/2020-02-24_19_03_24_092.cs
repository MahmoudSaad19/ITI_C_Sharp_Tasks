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
            Int16 ctr = 1;
            MethodInfo[] infos = typeof(Enumerable).GetMethods();
            var list = new List<MethodInfo>(infos);
            list = list.Distinct().ToList();
            HashSet<string> vs = new HashSet<string>();
            foreach (var i in list)
                vs.Add(i.Name);
            
            
            foreach (var i in vs)
                Console.WriteLine($"{ctr++}) {i}");

        }
    }
}
