using System;

namespace FactoryPatterns
{
    public class RoadLogistics : Logistics
    {
        public RoadLogistics()
        {
            Console.WriteLine("A road logistics is created");
        }

        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
