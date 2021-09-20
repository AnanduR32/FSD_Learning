using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultithreadingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread_1 = new Thread(Task_1);
            Thread thread_2 = new Thread(Task_2);
            Thread thread_3 = new Thread(Task_3);
            thread_1.Start();
            thread_2.Start();
            thread_3.Start();
            Console.ReadKey();


        }
        private static void printTask(string task, int iter)
        {
            Console.WriteLine("Task {0}: Iteration: {1}",task, iter);
        }

        public static void sleepThread(string task)
        {
            Console.WriteLine("Task {0}: Sleeping",task);
            Thread.Sleep(300);
            Console.WriteLine("Task {0}: Waking up",task);

        }
        
        public static void Task_1()
        {
            for (int i = 0; i < 50; i++)
            {
                printTask("1", i);
            }
        }

        public static void Task_2()
        {
            for (int i = 0; i < 50; i++)
            {
                printTask("2", i);
                if(i == 25)
                {
                    sleepThread("2");
                }
            }
        }
        public static void Task_3()
        {
            for (int i = 0; i < 50; i++)
            {
                printTask("3", i);
            }
        }

    }
}
