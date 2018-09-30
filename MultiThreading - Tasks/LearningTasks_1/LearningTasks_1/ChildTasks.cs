using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTasks_1
{
    class ChildTasks
    {
        //static void Main(string[] args)
        //{
        //    Task<int[]> task = Task.Run(()=> { //Inside the Task we are doing 2 things.
        //        var results = new int[3]; //1. Declaring a local integer array variable.
        //        new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start(); //2. Defining a series of task.
        //        new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
        //        new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();

        //        return results;
        //    });

        //    var finalTask = task.ContinueWith((parentTask) =>
        //    {
        //        foreach (var i in parentTask.Result)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    });

        //    finalTask.Wait();

        //}
    }
}
