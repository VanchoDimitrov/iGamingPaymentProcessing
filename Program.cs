using Akka.Actor;
using iGamingPaymentProcessing.DistributedSystemIntegration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;


namespace iGamingPaymentProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection().AddLogging(c => c.AddConsole(opt => opt.LogToStandardErrorThreshold = LogLevel.Debug))
                .AddLogging()
                .AddScoped<IGamesFactory, GamesFactory>()

                .AddScoped<IGamesForPlaying, CardGames>()
                .AddScoped<IGamesForPlaying,CasinoCards>()

                .AddScoped<IPaymentProcessing, Payments>()
                .AddScoped<ICustomer, Customer>()         
                
                .BuildServiceProvider();

            services.GetService<ILoggerFactory>();

            var logger = services.GetService<ILoggerFactory>().CreateLogger<Program>();
            logger.LogDebug("Start Console App");

            var casinoCards = services.GetService<CasinoCards>();

            var gamesFactory = services.GetService<IGamesFactory>();
            gamesFactory.AvailableGames();

            var games = gamesFactory.PayToPlayGame("Casino Game 1");
            games.FillCollection(casinoCards.typesCasinoGames);
            games.GamePlay("Level 1");

            //var cardsGame = gamesFactory.PayToPlayGame("Cards Game 1");
            //cardsGame.GamePlay("Level 2");

            //var casinoCards1 = gamesFactory.PayToPlayGame("Casino Game 1");
            //casinoCards1.GamePlay("Level 2");

            //var cardsGame1 = gamesFactory.PayToPlayGame("Cards Game 1");
            //cardsGame1.GamePlay("Level 3");

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

