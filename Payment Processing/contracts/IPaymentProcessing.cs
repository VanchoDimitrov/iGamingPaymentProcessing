using System;
using System.Collections.Generic;
using System.Text;

namespace iGamingPaymentProcessing
{
    public interface IPaymentProcessing
    {
        bool CheckIfPaid(ICustomer customer, CardGames cardGames, CasinoCards casinoCards);

        bool ProcessPayment(ICustomer customer, CardGames cardGames, CasinoCards casinoCards);
    }
}
