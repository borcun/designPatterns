using System;
namespace FactoryPatterns
{
    public class SeaLogistics : Logistics
    {
        public SeaLogistics()
        {
            Console.WriteLine("A sea logistics is created");
        }

        // sea logistics creates new ships as transport vehicles
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
