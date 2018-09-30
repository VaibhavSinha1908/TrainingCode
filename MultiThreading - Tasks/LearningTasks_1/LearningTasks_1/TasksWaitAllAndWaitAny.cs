using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LearningTasks_1
{
    class TasksWaitAllAndWaitAny
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[3];

            tasks[0] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
                return 1;
            });

            tasks[1] = Task.Run(()=> {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
                return 2;

            });

            tasks[2] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
                return 3;

            });

            Task.WaitAll(tasks); //note the WaitAll function is called on Task and not on variable 'tasks'
        }
    }
}
