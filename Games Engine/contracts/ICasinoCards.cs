using System.Collections.Generic;

namespace iGamingPaymentProcessing
{
    public interface ICasinoCards
    {
        int GameID { get; set; }
        string GameName { get; set; }
        List<CasinoCards> typesCasinoGames { get; set; }

        List<CasinoCards> FillCollection();
        void GamePlay(string version, ICasinoCards casinoCards);

        void AvailableGames();
    }
}