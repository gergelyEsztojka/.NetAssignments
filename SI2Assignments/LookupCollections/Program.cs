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

            foreach(DictionaryEntry country in ListDict)
            {
                Console.WriteLine(country.Key);
            }

            Console.ReadLine();
        }
    }
}
