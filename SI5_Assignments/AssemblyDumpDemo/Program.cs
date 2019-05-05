using System;
using System.Reflection;

namespace AssemblyDumpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ServiceProcess.dll";

            BindingFlags flags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;

            Assembly assembly = Assembly.LoadFrom(path);

            Console.WriteLine(assembly.FullName);
            Type[] types = assembly.GetTypes();

            foreach(var type in types)
            {
                Console.WriteLine($"Type name: {type.Name}");
                MemberInfo[] members = type.GetMembers(flags);

                foreach(var member in members)
                {
                    Console.WriteLine($"Membery type: {member.MemberType}, Name: {member.Name}");
                }
            }

            Console.ReadLine();
        }
    }
}
