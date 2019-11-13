using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemoV1
{
    public sealed class SingletonEagerLoadingOnStartup
    {
        private SingletonEagerLoadingOnStartup()
        {

        }

        private static readonly SingletonEagerLoadingOnStartup singleton = new SingletonEagerLoadingOnStartup();

        public static SingletonEagerLoadingOnStartup GetInstance 
        {
            get 
            {
                return singleton;
            }
        }
    }
}
