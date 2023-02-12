using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message, LogLevel level)
        {
            Console.WriteLine($"[{DateTime.Now}] [{level}] {message}");
        }
    }
}
