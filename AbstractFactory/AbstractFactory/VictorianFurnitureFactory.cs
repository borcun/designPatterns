using System;

namespace AbstractFactory
{
    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public VictorianFurnitureFactory(string name) : base(name)
        {
        }

        public override Chair createChair()
        {
            return new VictorianChair();
        }
    }
}
