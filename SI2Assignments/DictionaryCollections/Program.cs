using System.Collections;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hashtable = new Hashtable
            {
                { "1", "one" },
                { "2", "two" },
                { "3", "three" },
                { "4", "four" },
                { "5", "five" },
                { "6", "six" },
                { "7", "seven" },
                { "8", "eight" },
                { "9", "nine" },
                { "0", "zero" }
            };

            var NumberSequence = "654823540";

            foreach(char number in NumberSequence)
            {
                if(Hashtable.ContainsKey(number.ToString()))
                {
                    System.Console.WriteLine(Hashtable[number.ToString()]);
                } else
                {
                    System.Console.WriteLine("Charachter is not a number!");
                }
            }

            System.Console.ReadLine();
        }
    }
}
