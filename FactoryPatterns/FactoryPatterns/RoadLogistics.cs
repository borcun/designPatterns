using System;

namespace FactoryPatterns
{
    public class RoadLogistics : Logistics
    {
        public RoadLogistics()
        {
            Console.WriteLine("A road logistics is created");
        }

        // road logistics creates new trucks as transport vehicles
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
