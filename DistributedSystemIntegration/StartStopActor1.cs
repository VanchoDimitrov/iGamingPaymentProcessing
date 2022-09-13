using Akka.Actor;
using System;

namespace iGamingPaymentProcessing
{
    public class StartStopActor1 : UntypedActor
    {
        protected override void PreStart()
        {
            Console.WriteLine("first started");
            Context.ActorOf(Props.Create<StartStopActor2>(), "second");
        }

        protected override void PostStop()
        {
            Console.WriteLine("first stopped");
        } 

        protected override void OnReceive(object message)
        {
            switch (message)
            {
                case "Games added":
                    Console.WriteLine("Message delivered.\nGames have been started!");
                    Context.Stop(Self);
                    break;
            }
        }
    }
}
