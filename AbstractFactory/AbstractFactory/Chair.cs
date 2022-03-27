using System;

namespace AbstractFactory
{
    public abstract class Chair
    {
        public Chair()
        {
        }

        public abstract bool HasLegs();
        public abstract bool SitOn();
    }
}
