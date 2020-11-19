using System;
using System.Collections.Generic;
using System.Text;

namespace iGamingPaymentProcessing
{
    public class Customer : ICustomer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public Customer()
        {
            this.CustomerID = 1;
            this.Name = "John";
            this.LastName = "Doe";
        }
    }
}
