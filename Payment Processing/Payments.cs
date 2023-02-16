using System;
using System.Collections.Generic;
using System.Text;

namespace iGamingPaymentProcessing
{
    public class Payments : IPaymentProcessing
    {
        public bool CheckIfPaid(ICustomer customer, IGamesForPlaying cardGames, IGamesForPlaying casinoCards)
        {
            return false;
        }

        public bool ProcessPayment(ICustomer customer, IGamesForPlaying cardGames, IGamesForPlaying casinoCards)
        {
            return true;
        }
    }
}
