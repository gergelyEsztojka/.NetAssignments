using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Counting));
            Thread thread2 = new Thread(new ThreadStart(Counting));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            System.Console.ReadLine();
        }

        static void Counting()
        {
            for(int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine($"Current loop : {i}, current thread : {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
        }
    }
}
