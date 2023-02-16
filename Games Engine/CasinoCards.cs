using System;
using System.Collections.Generic;
using System.Linq;

namespace iGamingPaymentProcessing
{
    public class CasinoCards : ICasinoCards
    {
        #region Types
        private readonly ICustomer _customer;

        private readonly IPaymentProcessing _paymentProcessing;
        #endregion Types

        #region Properties
        public int GameID { get; set; }
        public string GameName { get; set; }

        public List<CasinoCards> typesCasinoGames { get; set; }

        #endregion Properties

        #region Constructor
        public CasinoCards(ICustomer customer, IPaymentProcessing paymentProcessing)
        {
            this._customer = customer;
            this._paymentProcessing = paymentProcessing;
            typesCasinoGames = new List<CasinoCards>();
        }

        #endregion Constructor

        public List<CasinoCards> FillCollection()
        {
            typesCasinoGames = new List<CasinoCards>()
            {
                new CasinoCards{  GameID = 1, GameName = "Casino Game 1" },
                new CasinoCards{  GameID = 2, GameName = "Casino Game 2" },
                new CasinoCards{  GameID = 2, GameName = "Casino Game 3" }
            };
            return typesCasinoGames;
        }

        public void AvailableGames()
        {
            Console.WriteLine();
            Console.WriteLine($"{typesCasinoGames.Count} games saved for playing!");

            foreach (var games in typesCasinoGames)
            {

                Console.WriteLine("Games saved for playing: {0} ", games);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private string GetGame(List<CasinoCards> getGames)
        {
            return getGames.Skip(1).Take(1).Select(x => new { GameName }).ToString();
        }

        public CasinoCards()
        {
            this.GameID = 1;
            this.GameName = "Casino Game 4";
            typesCasinoGames = new List<CasinoCards>();
        }

        public void GamePlay(string version, ICasinoCards casinoCards)
        {
            var checkIfPaid = _paymentProcessing.CheckIfPaid(_customer, casinoCards);

            if (!checkIfPaid)
            {
                // process payment before playing
                var processPayment = _paymentProcessing.ProcessPayment(_customer, casinoCards);

                if (processPayment)
                    Console.WriteLine($"Currently playing {GameName} version {version}. Paid version: {processPayment}");
            }
        }
    }
}
