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
        void GamePlay(string version);
        List<CasinoCards> FillCollection(List<CasinoCards> casinoCards);
    }
}
