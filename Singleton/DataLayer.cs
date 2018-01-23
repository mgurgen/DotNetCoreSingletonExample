using System;

namespace Singleton
{
    public class DataLayer
    {
        private static DataLayer _dataLayer = new DataLayer();
        private string _connectionString = "Default connection string";

        private DataLayer()
        {
            
        }

        public static DataLayer Instance 
        { 
            get
            {
                return _dataLayer;
            }
        }

        public string ConnectionString 
        { 
            get
            {
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }
    }
}
