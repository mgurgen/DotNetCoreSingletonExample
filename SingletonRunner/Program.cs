using System;
using Singleton;

namespace SingletonRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            DataLayer dataLayer = DataLayer.Instance;
            //DataLayer dataLayer1 = DataLayer.Instance;

            Console.WriteLine(dataLayer.ConnectionString);
            //Console.WriteLine(dataLayer1.ConnectionString);

            dataLayer.ConnectionString = "New Connection String";

            Console.WriteLine(dataLayer.ConnectionString);
            //Console.WriteLine(dataLayer1.ConnectionString);
        }
    }
}
