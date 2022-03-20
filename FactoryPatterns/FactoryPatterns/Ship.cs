using System;

namespace FactoryPatterns
{
    public class Ship : ITransport
    {
        public Ship()
        {
        }

        public bool Deliver()
        {
            Console.WriteLine("The cargo is delived via Ship");
            return true;
        }
    }
}
