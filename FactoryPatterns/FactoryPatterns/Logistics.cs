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

        // this is abstract method, expected to being implemented in derived classes
        public abstract ITransport CreateTransport();
    }
}
