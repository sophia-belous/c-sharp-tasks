using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleLibrary;

namespace task_4_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PointOfTriangle A = new PointOfTriangle() { X = 5, Y = 10 };

            PointOfTriangle B = new PointOfTriangle() { X = 2, Y = 3 };

            PointOfTriangle C = new PointOfTriangle() { X = 7, Y = 5 };

            Triangle tr1 = new Triangle(A, B, C);
            Triangle tr2 = new Triangle(10, 11, 10);

            Console.WriteLine(tr1.SideFirst);
            Console.WriteLine(tr1.SideSecond);
            Console.WriteLine(tr1.SideThird);

            

        }
    }
}
