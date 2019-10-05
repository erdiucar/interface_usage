using System;
using System.Collections.Generic;

namespace interface_usage
{
    public class Product : ILoggable
    {
        public string ProductName { get; set; }
        public int CurrentPrice { get; set; }

        public string Log()
        {
            var log = "Product Name " + ProductName + "\n" +
                      "Current Price: " + CurrentPrice;
            return log;
        }
    }
}
