using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTasks_1
{
    class TaskContinuation
    {
        //static void Main(string[] args)
        //{
        //    Task t = Task.Run(() => {
        //        return 43;
        //    });

        //    t.ContinueWith((i) => {
        //        Console.WriteLine("Only on Canceled");
        //    }, TaskContinuationOptions.OnlyOnCanceled); //Note the options

        //    t.ContinueWith((i) => {
        //        Console.WriteLine("Only on Faulted");
        //    }, TaskContinuationOptions.OnlyOnFaulted);
            
        //    var completedTask = t.ContinueWith((i) => {
        //        Console.WriteLine("Completed");
        //    }, TaskContinuationOptions.OnlyOnRanToCompletion);

        //    completedTask.Wait(); //Without completedTask.Wait() the main method exits without waiting for the tasks to complete.
        //}
    }
}
