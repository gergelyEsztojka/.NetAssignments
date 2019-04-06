using System.Collections.Generic;
using System.Linq;

namespace FilePartReaderWithNUnit
{
    class FileWordAnalyzer
    {

        private FilePartReader _filepartreader { get; }

        public FileWordAnalyzer(FilePartReader fpr)
        {
            _filepartreader = fpr;
        }

        public List<string> WordsByABC()
        {
            var wordsOrdered = new List<string>();

            wordsOrdered = _filepartreader.ReadLines().Split(' ').ToList();

            wordsOrdered.Sort();

            return wordsOrdered;
        }

        public List<string> WordsContainingSubstring(string subString)
        {
            var subStringWords = new List<string>();
            var wordsInFile = _filepartreader.ReadLines().Split(' ').ToList();

            subStringWords = wordsInFile.FindAll(delegate (string s) { return s.Contains(subString); });

            return subStringWords;
        }

        public List<string> WordsArePalindrome()
        {
            var palindromeWords = new List<string>();
            var wordsInFile = _filepartreader.ReadLines().Split(' ').ToList();

            foreach(string word in wordsInFile)
            {
                if(word.ToLower().SequenceEqual(word.ToLower().Reverse()))
                {
                    palindromeWords.Add(word);
                }
            }

            return palindromeWords;
        }
    }
}
