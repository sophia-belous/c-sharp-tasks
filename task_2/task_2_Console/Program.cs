using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using MyMathLibrary;

namespace task_2_Console
{
    class Program
    {   
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            var stopwatch2 = new Stopwatch();

            stopwatch.Start();
            Console.WriteLine(MyMath.GetRootOfNumber(81, 2));
            stopwatch.Stop();

            stopwatch2.Start();
            Console.WriteLine(Math.Pow(81, 0.5));
            stopwatch2.Stop();

            Console.WriteLine("Method #1 Total seconds: {0}", stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine("Method #2 Total seconds: {0}", stopwatch2.Elapsed.TotalSeconds);
            Console.WriteLine(new string('-', 20));
            //string BinaryCode = Convert.ToString(255, 2);
            //Console.WriteLine(BinaryCode);




        }
    }
}
