using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemoV1
{
    public sealed class SingletonThreadSafeDemo
    {
        private static SingletonThreadSafeDemo singletonThreadSafe = null;

        private static readonly object instanceLock = new object();

        public static SingletonThreadSafeDemo GetSingletonThreadSafeDemo
        {
            
            get 
            {
                lock (instanceLock)
                {
                    if (singletonThreadSafe == null)
                        singletonThreadSafe = new SingletonThreadSafeDemo();
                    return singletonThreadSafe;
                }                
            }
        }
        private SingletonThreadSafeDemo()
        {
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
