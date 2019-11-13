using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDesignPatternsDatabaseLambda
{
    public class Database
    {
        private Database()
        {
            Debug.WriteLine("Database Created ... ");
        }

        public void Query1()
        {
            Debug.WriteLine("Query1..");
        }

        public void Query2() 
        {
            Debug.WriteLine("Query2..");
        }

        private void Cleanup() 
        {
            Debug.WriteLine("Cleaned up!!!");
        }

        public static void Create(Action<Database> execution) 
        {
            var db = new Database();
            try
            {
                execution(db);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Cleanup();
            }
        }
    }
}
