using System;
namespace FactoryPatterns
{
    public class SeaLogistics : Logistics
    {
        public SeaLogistics()
        {
            Console.WriteLine("A sea logistics is created");
        }

        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
