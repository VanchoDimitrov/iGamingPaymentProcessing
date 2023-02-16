using System.Collections.Generic;

namespace iGamingPaymentProcessing
{
    public interface ICardGames
    {
        int GameID { get; set; }
        string GameName { get; set; }
        List<CasinoCards> typesCasinoGames { get; set; }

        List<CasinoCards> FillCollection(List<CasinoCards> casinoCards);
        void GamePlay(string version, ICardGames cardGames);
    }
}