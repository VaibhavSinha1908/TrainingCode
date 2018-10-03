using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTasks_1
{
    class TaskContinuation
    {
        //static void Main()
        //{
        //    Task t = Task.Run(()=> {
        //        Console.WriteLine("The task starts");
        //    });

        //   Task t2= t.ContinueWith((i) => { Console.WriteLine("The task ends..."); });

        //   t2.Wait(); //Note: Remember to call Wait on Task t2 and not on t.

        //}


        public static void Main()
        {
            int a = 0;
            Task<int> t = Task.Run(() => {
                a = 10;
                Console.WriteLine("The task starts");
                return a;
            });

            Task t2 =Task.Delay(5000).ContinueWith((ant) => { var temp = t.Result + 10;  Console.WriteLine("The result after the delay is: " + temp); });

            t2.Wait();
            
        }
    }
}
