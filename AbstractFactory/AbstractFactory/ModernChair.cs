using System;
namespace AbstractFactory
{
    public class ModernChair : Chair
    {
        public ModernChair()
        {
        }

        public override bool HasLegs()
        {
            return false;
        }

        public override bool SitOn()
        {
            return true;
        }
    }
}
