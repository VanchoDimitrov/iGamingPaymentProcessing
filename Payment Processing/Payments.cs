using System;
using System.Collections.Generic;
using System.Text;

namespace iGamingPaymentProcessing
{
    public class Payments : IPaymentProcessing
    {
        public bool CheckIfPaid(ICustomer customer, params object[] game)
        {
            return false;
        }

        public bool ProcessPayment(ICustomer customer, params object[] game)
        {
            return true;
        }
    }
}
