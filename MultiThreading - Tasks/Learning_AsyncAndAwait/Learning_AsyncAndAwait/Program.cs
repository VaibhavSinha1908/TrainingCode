using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_AsyncAndAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Task.Run(async () => { await DisplayPrimesCount(); });
            t.Wait();
           
        }

        private static async Task DisplayPrimesCount()//Note the void here does not work. Read Article: https://msdn.microsoft.com/en-us/magazine/jj991977.aspx
        {
            for (int i = 0; i < 10; i++)
            {
               // Console.WriteLine(await GetPrimesCountAsync(i * 100000 + 2, 100000));
               Console.WriteLine(await GetPrimesCountAsync(i * 100000 + 2, 100000) + " primes between "+ (i*100000) + " and " + ((i+1)*100000-1));
            }
            Console.WriteLine("Done!");
        }

        private static Task<int> GetPrimesCountAsync(int v1, int v2)
        {
            return Task.Run(() => 
                ParallelEnumerable.Range(v1, v2).Count(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0)));
        }
    }
}
