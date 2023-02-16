using Akka.Actor;
using System;

namespace iGamingPaymentProcessing.DistributedSystemIntegration
{
    public class StartStopActor2 : UntypedActor
    {
        protected override void PreStart() => Console.WriteLine("second started");
        protected override void PostStop() => Console.WriteLine("second stopped");

        protected override void OnReceive(object message)
        {
        }
    }
}
