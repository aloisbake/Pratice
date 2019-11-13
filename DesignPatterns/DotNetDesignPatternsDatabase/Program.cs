using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDesignPatternsDatabase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                using ( var db = new Database())
                {
                    db.Query1();
                    db.Query2();
                }
            }
            Console.Read();
        }
    }
}
