using System;

namespace FactoryPatterns
{
    public class Truck : ITransport
    {
        public Truck()
        {
        }

        public bool Deliver()
        {
            Console.WriteLine("The cargo is delivered via Truck");
            return true;
        }
    }
}
