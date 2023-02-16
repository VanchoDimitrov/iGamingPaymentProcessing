using System;
using System.Collections.Generic;
using System.Text;

namespace iGamingPaymentProcessing
{
    public interface IPaymentProcessing
    {
        bool CheckIfPaid(ICustomer customer, params object[] game);

        bool ProcessPayment(ICustomer customer, params object[] game);
    }
}
