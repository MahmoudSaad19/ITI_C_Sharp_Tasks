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
            Int16 counter = 1;
            Type type = Type.GetType("Enumerable");
            //object instance = Activator.CreateInstance(type);
            MethodInfo[] methods = type.GetMethods();
            HashSet<string> listOfNames = new HashSet<string>();
            foreach (var method in methods )
                listOfNames.Add(method.Name);            
          
            foreach (var name in listOfNames)
                Console.WriteLine($"{counter++}) {name}");

        }
    }
}
