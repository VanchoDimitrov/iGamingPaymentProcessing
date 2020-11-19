using System;

namespace iGamingPaymentProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamesFactory = new GamesFactory();
            gamesFactory.AvailableGames();

            var casinoCards = gamesFactory.PayToPlayGame("Casino Game 1");
            casinoCards.FillCollection(casinoCards.typesCasinoGames);
            casinoCards.GamePlay("Level 1");

            var cardsGame = gamesFactory.PayToPlayGame("Cards Game 1");
            cardsGame.GamePlay("Level 2");

            var casinoCards1 = gamesFactory.PayToPlayGame("Casino Game 1");
            casinoCards1.GamePlay("Level 2");

            var cardsGame1 = gamesFactory.PayToPlayGame("Cards Game 1");
            cardsGame1.GamePlay("Level 3");

            gamesFactory.AvailableGames();

            Console.ReadKey();
        }
    }
}
