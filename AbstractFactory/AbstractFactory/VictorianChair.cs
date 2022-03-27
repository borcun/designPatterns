using System;
namespace AbstractFactory
{
    public class VictorianChair : Chair
    {
        public VictorianChair()
        {
        }

        public override bool HasLegs()
        {
            return true;
        }

        public override bool SitOn()
        {
            return false;
        }
    }
}
