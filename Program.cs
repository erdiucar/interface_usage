using System;
using System.Collections.Generic;

namespace interface_usage
{
    class Program
    {
        static void Main()
        {
            Customer customer = new Customer()
            {
                CustomerId = 1,
                FirstName = "George",
                LastName = "Harry"
            };

            Product product = new Product()
            {
                ProductName = "Ball",
                CurrentPrice = 10
            };

            var items = new List<ILoggable>
            {
                customer,
                product
            };

            LoggingService.WriteToConsole(items);
        }
    }
}
