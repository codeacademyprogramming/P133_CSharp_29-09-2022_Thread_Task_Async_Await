using System;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronAsynchronThread
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Main Method {Thread.CurrentThread.ManagedThreadId}");

            Thread thread1 = new Thread(Loop1);
            Thread thread2 = new Thread(Loop2);

            thread1.Start();
            thread2.Start();

            //thread1.Join();

            //Loop1();
            //Loop2();
        }

        static void Loop1()
        {
            //Thread.Sleep(0);
            //Thread.Yield();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Loop 1 {i} {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        static void Loop2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Loop 2 {i} {Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
