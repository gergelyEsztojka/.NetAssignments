using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace LookupCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListDict = new ListDictionary
            {
                { "Estados Unidos", "United States" },
                { "Canadá", "Canada" },
                { "España", "Spain" }
            };
        }
    }
}
