using System;
using System.IO;

namespace SeekAndArchiveAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var watcher = new FileSystemWatcher(args[0]))
            {
                watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;

                watcher.Changed += OnChanged;
                watcher.Deleted += OnDeleted;
                watcher.Renamed += OnRename;

                watcher.EnableRaisingEvents = true;

                Console.WriteLine("Press q to stop the application");
                while (Console.Read() != 'q');
            }
        }

        private static void OnRename(object sender, RenamedEventArgs e)
        {
            Console.WriteLine("Rename happend");
        }

        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Delete happend");
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            FileInfo fileInfo = new FileInfo(e.FullPath);
            Console.WriteLine($"A File changed: {e.Name} changeType: {e.ChangeType} {fileInfo.LastWriteTime.Ticks}");
        }
    }
}
