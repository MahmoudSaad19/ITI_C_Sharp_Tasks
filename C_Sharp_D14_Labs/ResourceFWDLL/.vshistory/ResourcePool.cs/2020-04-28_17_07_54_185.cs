using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcePoolDLL
{
    /// <summary>
    /// Lab
    /// 1. Resource Pool Non Static Class (Concrete Class --- Can't BE SingleTon DP)
    /// 2. Resource Implement Dispose ( Resurection also)
    /// 3. ResourcePool Implement Dispose instead of IsClosing
    /// 
    /// </summary>


    public static class ResourcePool
    {
        static Queue<Resouce> Pool;

        public static Boolean IsClosing { get; set; }

        public static int CurrentPoolSize { get => Pool?.Count ?? 0; }

        ///Non Static Class
        /// public int MinPoolSize {get;}
        /// public int MxPoolSize {get;}
        /// Ctor ( MINPS , MAXPSize ){}

        static ResourcePool()
        {
            Console.WriteLine("Pool Created");
            Pool = new Queue<Resouce>();

        }

        public static Resouce GetResouce ()
        {
            if (Pool.Count > 0)
                return Pool.Dequeue();
            return new Resouce();
        }

        public static void AddResourceToPool ( Resouce R)
        {
            if ((!IsClosing)&&(!Pool.Contains(R)))
                Pool.Enqueue(R);
        }


    }
}
