using System;
using System.Reflection;

namespace AssemblyAttrDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get running assembly
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type attrType = typeof(AssemblyDescriptionAttribute);

            object[] attrs = assembly.GetCustomAttributes(attrType, false);

            if (attrs.Length > 0)
            {
                AssemblyDescriptionAttribute desc = (AssemblyDescriptionAttribute)attrs[0];
                Console.WriteLine($"Description is: {desc.Description}");
            }

            Console.ReadLine();
        }
    }
}
