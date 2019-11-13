using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDesignPatternsDatabase
{
    public class Database : IDisposable
    {
        public void Dispose()
        {
            Cleanup();
            GC.SuppressFinalize(this);
        }

        private void Cleanup()
        {
            Console.WriteLine("Cleanup code here");
        }

        public void Query1() 
        {
            Console.WriteLine("Query1 executed successfully");
        }

        public void Query2() 
        {
            Console.WriteLine("Query2 executed successfully");
        }
    }
}
