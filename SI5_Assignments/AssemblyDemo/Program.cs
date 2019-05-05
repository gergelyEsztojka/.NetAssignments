using System;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll";

            // Load Assembly file
            Assembly assembly = Assembly.LoadFile(path);
            ShowAssembly(assembly);

            // Get executing assembly
            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            ShowAssembly(currentAssembly);

            Console.ReadLine();
        }

        static void ShowAssembly(Assembly assembly)
        {
            Console.WriteLine(assembly.FullName);
            Console.WriteLine($"From GAC? {assembly.GlobalAssemblyCache}");
            Console.WriteLine($"Path: {assembly.Location}");
            Console.WriteLine($"Version: {assembly.ImageRuntimeVersion}");

            foreach(var modules in assembly.GetModules())
            {
                Console.WriteLine($"Module: {modules.Name}");
            }
        }
    }
}
