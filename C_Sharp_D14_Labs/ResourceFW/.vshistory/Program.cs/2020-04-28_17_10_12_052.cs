using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResourcePoolDLL;

namespace ResourceFW
{
    class Program
    {
        static void Main(string[] args)
        {
            ResourcePool resourcePool = new ResourcePool();
            Resouce R01 = resourcePool.GetResouce();
            //new Resouce();
            Console.WriteLine($"R01 {R01.GetHashCode()}");
            R01.DoSomeResourceWork();

            R01 = null;

            GC.Collect();

            int X = int.Parse(Console.ReadLine());
            ++X;
            Console.WriteLine(X);
            Console.ReadLine();

            Resouce R02 = resourcePool.GetResouce();
            //new Resouce();
            Console.WriteLine($"R02 {R02.GetHashCode()}");
            R02.DoSomeResourceWork();

            R02 = null;

            GC.Collect();

            X = int.Parse(Console.ReadLine());
            ++X;
            Console.WriteLine(X);
            Console.ReadLine();


            Resouce R03 = resourcePool.GetResouce();
            //new Resouce();
            Console.WriteLine($"R03 {R03.GetHashCode()}");
            R03.DoSomeResourceWork();

            ResourcePool.IsClosing = true;
        }
    }
}
