using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResourcePoolDLL
{
    public class Resouce
    {
        static int Counter;

        public string Name { get; }

        public DateTime TimeStamp { get; } = DateTime.Now;

        internal Resouce()
        {
            Console.WriteLine("Ctor Started");
            Name = $"Resource{++Counter}";

            Thread.Sleep(2000);

            Console.WriteLine($"Ctor {Name} Finised");
        }

        public void DoSomeResourceWork ()
        {
            Console.WriteLine($"Using Resource {Name} {TimeStamp}");
        }


        ~Resouce()
        {
            if (!ResourcePool.IsClosing)
            {
                ResourcePool.AddResourceToPool(this);
                ///Re Add this To Finalization List
                GC.ReRegisterForFinalize(this);
                Console.WriteLine("Dest.");
            }
        }


    }
}
