using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDesignPatternsDatabaseLambda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Database.Create(database =>
            {
                database.Query1();
                database.Query2();
            });
        }
    }
}
