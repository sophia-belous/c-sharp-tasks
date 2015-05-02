using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorAndPolinomLibrary;

namespace task_5_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(1, 2, 3);
            vector.Сoordinates[1] = 5;
            double actual = vector.Сoordinates[1];
            Console.WriteLine(actual);
        }
    }
}
