using System;
using System.IO;
using System.IO.Compression;

namespace SeekAndArchive
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo searchedFile = new FileInfo(args[0]);
            DirectoryInfo searchedDirectory = new DirectoryInfo(args[1]);

            FileInfo datFile = new FileInfo(@"C:\Users\Gery\source\repos\AdvanceSI\DotNet\SI_Assignments\TestingFolder\testingDat.dat");

            BinaryReader br = new BinaryReader(datFile.OpenRead());
            
            if(searchedFile.LastWriteTime.ToString() == br.ReadString())
            {
                br.Close();
                Console.WriteLine("File has not been changed from last time");
            }
            else
            {
                br.Close();
                BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

                bw.Write(searchedFile.LastWriteTime.ToString());
                bw.Close();
                Compress(searchedFile.FullName, searchedFile.FullName.Replace(".txt", ".gzip"));
            }

            

            Console.ReadLine();
        }

        static void Compress(string fileToCompress, string outputFileName)
        {
            using (FileStream inputStream = new FileStream(fileToCompress, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (FileStream outputStream = new FileStream(outputFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (GZipStream gzip = new GZipStream(outputStream, CompressionMode.Compress))
                    {
                        inputStream.CopyTo(gzip);
                    }
                }
            }
        }
    }
}
