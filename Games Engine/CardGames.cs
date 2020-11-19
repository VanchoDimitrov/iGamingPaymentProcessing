using System;
using System.Collections.Generic;
using System.Text;

namespace iGamingPaymentProcessing
{
    public class CardGames : IGamesForPlaying
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public List<CasinoCards> typesCasinoGames { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public CardGames()
        {
            this.GameID = 1;
            this.GameName = "Cards Game 1";
        }

        /// <summary>
        /// Free Game Play
        /// </summary>
        /// <param name="version"></param>
        public void GamePlay(string version)
        {
            Console.WriteLine($"Currently playing {GameName} version {version}. Free version.");
        }

        public List<CasinoCards> FillCollection(List<CasinoCards> casinoCards)
        {
            throw new NotImplementedException();
        }
    }
}
