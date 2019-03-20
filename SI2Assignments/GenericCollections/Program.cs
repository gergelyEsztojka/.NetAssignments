using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dict = new Dictionary<int, string>();
            Dict.Add(36, "Hungary");
            Dict.Add(81, "Japan");
            Dict.Add(41, "Poland");

            //dict.Add("1", "testCountry"); <-- this line will fail!

            System.Console.WriteLine(Dict[81]);

            foreach(KeyValuePair<int, string> keyValuePair in Dict)
            {
                System.Console.WriteLine($"The country code of {keyValuePair.Value} is {keyValuePair.Key}");
            }

            System.Console.ReadLine();
        }
    }
}
