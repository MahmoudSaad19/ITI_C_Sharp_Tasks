using System;
using System.Linq;
using System.Reflection;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodInfo[] infos = typeof(Enumerable).GetMethods();
            foreach (var i in infos)
                Console.WriteLine(i.Name);
        }
    }
}
