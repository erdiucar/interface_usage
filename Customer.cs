using System;
using System.Collections.Generic;

namespace interface_usage
{
    public class Customer : ILoggable
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Log()
        {
            var log = "Customer ID: " + CustomerId + "\n" +
                      "First Name: " + FirstName + "\n" +
                      "Last Name: " + LastName;
            return log;
        }
    }
}
