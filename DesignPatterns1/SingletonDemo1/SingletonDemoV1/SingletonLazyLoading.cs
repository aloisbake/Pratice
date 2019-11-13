using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemoV1
{
    public sealed class SingletonLazyLoading
    {
        private SingletonLazyLoading()
        {

        }

        private static readonly Lazy<SingletonLazyLoading> instanceLock = new Lazy<SingletonLazyLoading>(() => new SingletonLazyLoading());

        public static SingletonLazyLoading GetInstance
        {
            get 
            {
                return instanceLock.Value;
            }
        }
    }
}
