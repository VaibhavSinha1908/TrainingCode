using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_AsyncAndAwait
{
    class NonParallelTask
    {
        //static void Main(string[] args)
        //{
        //    DisplayPrimesCount();
        //    //var t = Task.Run(async () => { await DisplayPrimesCount(); });
        //    //t.Wait();

        //}

        private static void  DisplayPrimesCount()//Note the void here does not work. Read Article: https://msdn.microsoft.com/en-us/magazine/jj991977.aspx
        {
            for (int i = 0; i < 100; i++)
            {
                // Console.WriteLine(await GetPrimesCountAsync(i * 100000 + 2, 100000));
                Console.WriteLine( GetPrimesCount(i * 100000 + 2, 100000) + " primes between " + (i * 100000) + " and " + ((i + 1) * 100000 - 1));
            }
            Console.WriteLine("Done!");
        }

        private static int GetPrimesCount(int v1, int v2)
        {

          return  ParallelEnumerable.Range(v1, v2).Count(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0));
        }
    }
}
