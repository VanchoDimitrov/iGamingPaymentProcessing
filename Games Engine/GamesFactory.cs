using System;
using System.Collections.Generic;
using System.Linq;

namespace iGamingPaymentProcessing
{
    public class GamesFactory : IGamesFactory
    {
        private readonly Dictionary<string, dynamic> _gamesProcessed = new();

        public void PayToPlayGame(string gameName, object gameType)
        {
            _gamesProcessed.Add(gameName, gameType);
        }

        public void AvailableGames()
        {
            Console.WriteLine();
            Console.WriteLine($"{_gamesProcessed.Count} games added to the queue for playing!");

            foreach (var games in _gamesProcessed)
            {
                
                    Console.WriteLine("Game for playing: {0} {1}", games.Key, games.Value);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public int AddedAvailableGames()
        {
            int countGames = 0;
            foreach (var games in _gamesProcessed)
            {
                countGames++;
            }

            return countGames;
        }
    }
}
