using System;
using System.Collections.Generic;
using System.Linq;

namespace iGamingPaymentProcessing
{
    public class CasinoCards : IGamesForPlaying
    {
        #region Types
        private ICustomer customer;

        private IPaymentProcessing paymentProcessing;

        private IGamesForPlaying cardGames;

        private IGamesForPlaying casinoCards;
        #endregion Types

        #region Properties
        public int GameID { get; set; }
        public string GameName { get; set; }

        public List<CasinoCards> typesCasinoGames { get; set; } = new List<CasinoCards>();

        #endregion Properties

        #region Constructor
        public CasinoCards(ICustomer customer, IPaymentProcessing paymentProcessing, IGamesForPlaying cardGames, IGamesForPlaying casinoCards)
        {
            this.customer = customer;
            this.paymentProcessing = paymentProcessing;
            this.cardGames = cardGames;
            this.casinoCards = casinoCards;
        }

        #endregion Constructor

        public List<CasinoCards> FillCollection(List<CasinoCards> casinoCards)
        {
            casinoCards = new List<CasinoCards>()
            {
                new CasinoCards{  GameID = 1, GameName = "Casino Game 1" },
                new CasinoCards{  GameID = 2, GameName = "Casino Game 2" },
                new CasinoCards{  GameID = 2, GameName = "Casino Game 3" }
            };
            return casinoCards;
        }

        private string GetGame(List<CasinoCards> getGames)
        {
            return getGames.Skip(1).Take(1).Select(x => new { GameName }).ToString();
        }

        public CasinoCards()
        {
            this.GameID = 1;
            this.GameName = "Casino Game 1";
        }

        public void GamePlay(string version)
        {
            var checkIfPaid = paymentProcessing.CheckIfPaid(customer, cardGames, casinoCards);

            if (!checkIfPaid)
            {
                // process payment before playing
                var processPayment = paymentProcessing.ProcessPayment(customer, cardGames, casinoCards);

                if (processPayment)
                    Console.WriteLine($"Currently playing {GameName} version {version}. Paid version: {processPayment}");
            }
        }
    }
}
