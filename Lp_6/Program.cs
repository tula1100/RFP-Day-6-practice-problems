using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lp_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Starting Time ");
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(5);
            }
            Console.WriteLine("Time stopped");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
    
