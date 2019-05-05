using System;
using System.Reflection;
using System.Reflection.Emit;

namespace DemoDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyName name = new AssemblyName();
            name.Name = "DemoAssembly";
            name.Version = new Version("1.0.0.0");

            AppDomain domain = AppDomain.CurrentDomain;

            AssemblyBuilder assemBldr = domain.DefineDynamicAssembly(name, AssemblyBuilderAccess.ReflectionOnly);

            ModuleBuilder modBldr = assemBldr.DefineDynamicModule("CodeModule", "DemoAssembly.dll");

            TypeBuilder animalBldr = modBldr.DefineType("Animal", TypeAttributes.Public);

            Type animal = animalBldr.CreateType();
            Console.WriteLine(animal.FullName);

            foreach(var info in animal.GetMembers())
            {
                Console.WriteLine($"Member ({info.MemberType}: {info.Name}");
            }

            Console.ReadKey();
        }
    }
}
