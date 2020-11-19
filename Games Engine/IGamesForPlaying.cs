using System;
using System.Collections.Generic;
using System.Text;

namespace iGamingPaymentProcessing
{
    public interface IGamesForPlaying
    {
        int GameID { get; set; }
        string GameName { get; set; }
        List<CasinoCards> typesCasinoGames { get; set; }

        List<CasinoCards> FillCollection(List<CasinoCards> casinoCards);
        void GamePlay(string version);
    }
}
