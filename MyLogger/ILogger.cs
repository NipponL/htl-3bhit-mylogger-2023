using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    internal interface ILogger
    {
        void Log(string message, LogLevel level);
    }
}
