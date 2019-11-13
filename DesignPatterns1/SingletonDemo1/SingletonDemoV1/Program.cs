using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemoV1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton fromTeachaer = Singleton.GetInstance;
            fromTeachaer.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            ParrallelInvokingForThreading();
            Console.ReadLine();
        }

        private static void ParrallelInvokingForThreading()
        {
            Parallel.Invoke(() => PrintTeacherDetails(),
                            () => PrintStudentdetails());
        }

        private static void PrintTeacherDetails()
        {
            SingletonThreadSafeDemo fromTeacher = SingletonThreadSafeDemo.GetSingletonThreadSafeDemo;
            fromTeacher.PrintDetails("From Student");
        }
        private static void PrintStudentdetails()
        {
            SingletonThreadSafeDemo fromStudent = SingletonThreadSafeDemo.GetSingletonThreadSafeDemo;
            fromStudent.PrintDetails("From Student");
        }

    }
}
