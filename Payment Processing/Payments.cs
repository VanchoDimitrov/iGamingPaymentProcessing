using System;
using System.Collections.Generic;
using System.Text;

namespace iGamingPaymentProcessing
{
    public class Payments : IPaymentProcessing
    {
        public bool CheckIfPaid(ICustomer customer, CardGames cardGames, CasinoCards casinoCards)
        {
            return false;
        }

        public bool ProcessPayment(ICustomer customer, CardGames cardGames, CasinoCards casinoCards)
        {
            return true;
        }
    }
}
