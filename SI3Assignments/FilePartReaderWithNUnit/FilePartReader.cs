using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FilePartReaderWithNUnit
{
    class FilePartReader
    {
        public string FilePath { get; set; }
        public int FromLine { get; set; }
        public int ToLine { get; set; }


        public FilePartReader()
        {

        }

        public void Setup(string filePath, int fromLine, int toLine)
        {
            if(toLine < fromLine || fromLine < 1)
            {
                throw new ArgumentException("toLine has to be bigger then fromLine and formLine has to bigger then 1");
            }
            else
            {
                FilePath = filePath;
                FromLine = FromLine;
                ToLine = toLine;
            }


        }

        public string Read()
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                return reader.ReadToEnd();
            }
        }

        public string ReadLines()
        {
            var fileContent = Read();
            var resultString = new StringBuilder();
            var lines = new List<string>();

            lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            
            for(int i = 0; i < lines.Count + 1; i++)
            {
                if(i >= FromLine -1 && i <= ToLine -1)
                {
                    resultString.Append(lines[i] + ' ');
                }
            }

            resultString.Length--;
            return resultString.ToString();
        }
    }
}
