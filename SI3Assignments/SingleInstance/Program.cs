using System.Threading;

namespace SingleInstance
{
    class Program
    {
        const string RUNMEONLYONCE = "Mutex";

        static void Main(string[] args)
        {

            Mutex Mutex = null;

            try
            {
                Mutex = Mutex.OpenExisting(RUNMEONLYONCE);
            }
            catch (WaitHandleCannotBeOpenedException)
            {
                Mutex = Mutex.OpenExisting(RUNMEONLYONCE);
            }

            Mutex.Close();
        }
    }
}
