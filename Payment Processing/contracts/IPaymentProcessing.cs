using System;
using System.Collections.Generic;
using System.Text;

namespace iGamingPaymentProcessing
{
    public interface IPaymentProcessing
    {
        bool CheckIfPaid(ICustomer customer, IGamesForPlaying cardGames, IGamesForPlaying casinoCards);

        bool ProcessPayment(ICustomer customer, IGamesForPlaying cardGames, IGamesForPlaying casinoCards);
    }
}
