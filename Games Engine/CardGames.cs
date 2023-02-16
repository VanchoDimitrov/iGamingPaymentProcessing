using System;
using System.Collections.Generic;

namespace iGamingPaymentProcessing
{
    public class CardGames : ICardGames
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public List<CasinoCards> typesCasinoGames { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public CardGames()
        {
            this.GameID = 1;
            this.GameName = "Cards Game 1";
        }

        public void GamePlay(string version, ICardGames cardGames)
        {
            Console.WriteLine($"Currently playing {GameName} version {version}. Free version.");
        }

        public List<CasinoCards> FillCollection(List<CasinoCards> casinoCards)
        {
            throw new NotImplementedException();
        }
    }
}
