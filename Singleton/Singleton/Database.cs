using System;

namespace Singleton
{
    public class Database
    {
        // private class instance
        private static Database m_database = null;
        private string m_name;

        // private default constructor to prevent explicit calls
        private Database()
        {
            m_name = "";
        }

        public string Name
        {
            set
            {
                m_name = value;
            }

            get
            {
                return m_name;
            }
        }

        // public static function that gets class instance
        public static Database GetInstance()
        {
            if (null == m_database)
            {
                m_database = new Database();
            }

            return m_database;
        }
    }
}
