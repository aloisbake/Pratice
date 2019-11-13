using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemoV1
{
    public sealed class Student
    {
        private static Student instance;

        private static Student GetStudent 
        {
            get 
            {
                if (instance == null)
                    instance = new Student();
                return instance;
            }
        }
        private Student()
        {

        }
    }
}
