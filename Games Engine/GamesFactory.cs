using System;
using System.Collections.Generic;
using System.Threading;

namespace iGamingPaymentProcessing
{
    public class GamesFactory : IGamesFactory
    {
        private readonly Dictionary<string, IGamesForPlaying> gamesProcessed = new Dictionary<string, IGamesForPlaying>();

        private IGamesForPlaying games;

        private IGamesForPlaying casinoCards;
        private IGamesForPlaying cardGames;

        public GamesFactory(IGamesForPlaying games, IGamesForPlaying _casinoCards, IGamesForPlaying cardGames)
        {
            this.games = games;
            this.casinoCards = _casinoCards;
            this.cardGames = cardGames;
        }

        public void PayToPlayGame(string gameName, params object[] gameType)
        {
            if (gamesProcessed.ContainsKey(gameName))
            {
                throw new InvalidOperationException("Such game exists.");
            }

            switch (gameName)
            {
                case "Casino Game 1":
                    //games = (IGamesForPlaying)casinoCards;
                    games = casinoCards;
                    Thread.Sleep(1300);
                    break;
                case "Cards Game 1":
                    games = cardGames;
                    Thread.Sleep(1300);
                    break;
            }

            gamesProcessed.Add(gameName, games);
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
