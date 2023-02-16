using System;
using System.Collections.Generic;
using System.Threading;

namespace iGamingPaymentProcessing
{
    public class GamesFactory : IGamesFactory
    {
        private readonly Dictionary<string, IGamesForPlaying> gamesProcessed
            = new Dictionary<string, IGamesForPlaying>();

        private IGamesForPlaying games;

        public GamesFactory(IGamesForPlaying games)
        {
            this.games = games;
        }

        public IGamesForPlaying PayToPlayGame(string gameName)
        {
            if (gamesProcessed.ContainsKey(gameName))
            {
                return gamesProcessed[gameName];
            }

            switch (gameName)
            {
                case "Casino Game 1":
                    games = new CasinoCards();
                    Thread.Sleep(1300);
                    break;
                case "Cards Game 1":
                    games = new CardGames();
                    Thread.Sleep(1300);
                    break;
            }

            gamesProcessed.Add(gameName, games);
            return games;
        }

        public void AvailableGames()
        {
            Console.WriteLine($"{gamesProcessed.Count} games added to the queue for playing!");

            foreach (var games in gamesProcessed)
            {
                Console.WriteLine("Game for playing: {0}", games.Value.GameName);
            }
        }

        public int AddedAvailableGames()
        {
            int countGames = 0;
            foreach (var games in gamesProcessed)
            {
                countGames++;
            }

            return countGames;
        }
    }
}
