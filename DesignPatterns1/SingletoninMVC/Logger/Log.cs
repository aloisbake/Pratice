using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace SingletoninMVC.Logger
{
    public sealed class Log : ILog
    {
        public Log()
        {

        }

        private static Lazy<Log> singletonInstance = new Lazy<Log>(() => new Log());

        public static Log GetInstance 
        {
            get 
            {
                return singletonInstance.Value;
            }
        }
        public void LogException(string message)
        {
            string fileName = $"Exception.log"; // string.Format("{0}_{1}.log", "Exception", DateTime.Now.ToShortDateString());
            string logFilePath = $@"{AppDomain.CurrentDomain.BaseDirectory}{fileName}"; //string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);

            using (StreamWriter writer = new StreamWriter(logFilePath, true)) 
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}