using System;
using System.Collections.Generic;

namespace interface_usage
{
    public static class LoggingService
    {
        public static void WriteToConsole(IEnumerable<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
