using Akka.Actor;
using iGamingPaymentProcessing.DistributedSystemIntegration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;


namespace iGamingPaymentProcessing
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var services = new ServiceCollection().AddLogging(c => c.AddConsole(opt => opt.LogToStandardErrorThreshold = LogLevel.Debug))
                .AddScoped<IGamesFactory, GamesFactory>()

                .AddScoped<ICardGames, CardGames>()
                .AddScoped<ICasinoCards, CasinoCards>()

                .AddScoped<IPaymentProcessing, Payments>()
                .AddScoped<ICustomer, Customer>()

                .BuildServiceProvider();

            services.GetService<ILoggerFactory>();

            var logger = services.GetService<ILoggerFactory>().CreateLogger<Program>();
            logger.LogDebug("Start Console App");

            var cardGames = services.GetService<ICardGames>();
            var casinoCards = services.GetService<ICasinoCards>();
            casinoCards.FillCollection();
            casinoCards.AvailableGames();



            var gamesFactory = services.GetService<IGamesFactory>();
            gamesFactory.AvailableGames();
            

            gamesFactory.PayToPlayGame("Casino Game 3", casinoCards);
            casinoCards.GamePlay("Level 2", casinoCards);
            casinoCards.GamePlay("Level 1", casinoCards);
            

            gamesFactory.PayToPlayGame("Cards Game 14", cardGames);
            cardGames.GamePlay("Level 2", cardGames);

            gamesFactory.PayToPlayGame("Casino Game 6", casinoCards);
            casinoCards.GamePlay("Level 3", casinoCards);

            gamesFactory.PayToPlayGame("Cards Game 1", cardGames);
            cardGames.GamePlay("Level 4", cardGames);

            gamesFactory.AvailableGames();



            //Distributed integration test - not implemented in full yet. Testing.
            var system1 = ActorSystem.Create("test");

            var first =
                system1.ActorOf(Props.Create<StartStopActor1>(), "first");
            first.Tell("Games added");

            logger.LogDebug("Finished");

            Console.ReadKey();
        }
    }
}

