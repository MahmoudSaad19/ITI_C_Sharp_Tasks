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
            MethodInfo[] methods = typeof(Enumerable).GetMethods();
            HashSet<string> listOfNames = new HashSet<string>();
            foreach (var i in methods )
                listOfNames.Add(i.Name);            
          
            foreach (var name in listOfNames)
                Console.WriteLine($"{ctr++}) {name}");

        }
    }
}
