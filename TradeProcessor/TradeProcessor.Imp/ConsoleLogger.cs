using System;
using System.Collections.Generic;
using System.Text;

namespace TradeProcessor.Imp
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"ERR: {message}"); ;
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"WRN: {message}");
        }
    }
}
