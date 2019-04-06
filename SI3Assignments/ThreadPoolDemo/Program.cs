using System.Threading;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = null;
        }

        static void ShowMyText(object state)
        {
            string textToShow = (string)state;

            System.Console.WriteLine(textToShow + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
