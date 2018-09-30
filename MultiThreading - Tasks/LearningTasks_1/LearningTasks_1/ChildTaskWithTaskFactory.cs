using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTasks_1
{
    class ChildTaskWithTaskFactory
    {

        /// <summary>
        /// When we need to create multiple tasks with same Task Creation and Task Continuation options, we use Task Factory;
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    Task<int[]> parent = Task.Run(() => {   //Note the declaration of the Task variable.
        //        var results = new int[3];

        //        TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously); 
        //        tf.StartNew(() =>  results[0] = 100 );
        //        tf.StartNew(() => results[1] = 200);
        //        tf.StartNew(() => results[2] = 300);
        //        return results;
        //    });

        //    var finalTask = parent.ContinueWith((parentTask) =>
        //    {
        //        foreach (var item in parentTask.Result)
        //        {
        //            Console.WriteLine("The result is: "+ item);
        //        }

        //    });

        //    finalTask.Wait();
        //}
    }
}
