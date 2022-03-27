using System;
namespace AbstractFactory
{
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public ModernFurnitureFactory(string name) : base(name)
        {

        }

        public override Chair createChair()
        {
            return new ModernChair();
        }
    }
}
