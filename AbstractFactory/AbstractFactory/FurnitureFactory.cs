using System;
namespace AbstractFactory
{
    public abstract class FurnitureFactory
    {
        private readonly string m_name;

        public FurnitureFactory(string name)
        {
            m_name = name;
        }

        public string GetName()
        {
            return m_name;
        }

        public abstract Chair createChair();
    }
}
