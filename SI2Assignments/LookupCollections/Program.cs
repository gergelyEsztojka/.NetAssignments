using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace LookupCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListDict = new ListDictionary(StringComparer.OrdinalIgnoreCase)
            {
                { "Estados Unidos", "United States" },
                { "Canadá", "Canada" },
                { "España", "Spain" }
            };

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");

            Console.WriteLine(ListDict["Canadá"]);
            Console.WriteLine(ListDict["España"]);

            Console.ReadLine();
        }
    }
}
