using System;

namespace Singleton
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Database database1 = Database.GetInstance();
            Database database2 = Database.GetInstance();

            database1.Name = "MSSQL";
            // last name is persistent, because of static object
            database2.Name = "MySQL";

            // hash codes are same
            Console.WriteLine("{0} hash code: {1}", database1.Name, database1.GetHashCode());
            Console.WriteLine("{0} hash code: {1}", database2.Name, database2.GetHashCode());

        }
    }
}
