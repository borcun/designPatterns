using System;

namespace AbstractFactory
{
    class Client
    {
        // this is abstract factory object
        private FurnitureFactory m_factory;

        public Client(FurnitureFactory factory)
        {
            m_factory = factory;
        }

        public void makeDesign()
        {
            Chair chair = m_factory.createChair();

            Console.WriteLine("Furniture Name  : " + m_factory.GetName());
            Console.WriteLine(" Chair Has Legs : " + chair.HasLegs());
            Console.WriteLine(" Chair Sit On   : " + chair.SitOn() + "\n");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Client client1 = new Client(new VictorianFurnitureFactory("Victorian"));
            Client client2 = new Client(new ModernFurnitureFactory("Modern"));

            client1.makeDesign();
            client2.makeDesign();
        }
    }
}
