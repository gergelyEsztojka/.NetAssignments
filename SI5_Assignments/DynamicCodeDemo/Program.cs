using System;
using System.Reflection;

namespace DynamicCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Web.dll";

            // Get assembly from file
            Assembly assembly = Assembly.LoadFile(path);

            // HTTPUtility class type
            Type utilType = assembly.GetType("System.Web.HttpUtility");

            MethodInfo encode = utilType.GetMethod("HtmlEncode", new Type[] { typeof(string) });
            MethodInfo decode = utilType.GetMethod("HtmlDecode", new Type[] { typeof(string) });

            // String to encode
            string originalString = "This is Jack & Bob last movies <list>";

            Console.WriteLine(originalString);

            // encode and show the encoded value
            string encoded = (string)encode.Invoke(null, new object[] { originalString });

            Console.WriteLine(encoded);

            // decode
            string decoded = (string)decode.Invoke(null, new object[] { encoded });

            Console.WriteLine(decoded);

            Console.ReadLine();
        }
    }
}
