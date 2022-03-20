using System;

namespace FactoryPatterns
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Logistics roadLogistics = new RoadLogistics();
            Logistics seaLogistics = new SeaLogistics();

            roadLogistics.PlanDelivery();
            seaLogistics.PlanDelivery();
        }
    }
}
