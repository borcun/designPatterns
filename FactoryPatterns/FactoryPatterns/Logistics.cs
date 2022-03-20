using System;

namespace FactoryPatterns
{
    public abstract class Logistics
    {
        public Logistics()
        {
        }

        public bool PlanDelivery()
        {
            ITransport transport = CreateTransport();

            return transport.Deliver();
        }

        public abstract ITransport CreateTransport();
    }
}
