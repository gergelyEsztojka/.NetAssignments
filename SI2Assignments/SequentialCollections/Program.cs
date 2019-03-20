using System.Collections;



namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var Queue = new Queue();

            Queue.Enqueue("First");
            Queue.Enqueue("Second");
            Queue.Enqueue("Third");
            Queue.Enqueue("Fourth");

            while (Queue.Count > 0)
            {
                try
                {
                    System.Console.WriteLine(Queue.Peek());
                    Queue.Dequeue();
                }
                catch (System.InvalidOperationException e)
                {
                    System.Console.WriteLine($"Queue is empty : {e}");
                    break;
                }
            }

            var Stack = new Stack();

            Stack.Push("First");
            Stack.Push("Second");
            Stack.Push("Third");
            Stack.Push("Fourth");

            while(Stack.Count > 0)
            {
                try
                {
                    System.Console.WriteLine(Stack.Peek());
                    Stack.Pop();
                } catch (System.InvalidOperationException e)
                {
                    System.Console.WriteLine($"Stack is empty : {e}");
                    break;
                }
            }

            System.Console.ReadLine();
        }
    }
}
