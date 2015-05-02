using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixLib;

namespace task_7_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(3, 3);

            matrix[0, 0] = 2.0;
            matrix[0, 1] = 5.0;
            matrix[0, 2] = 7.0;

            matrix[1, 0] = 6.0;
            matrix[1, 1] = 3.0;
            matrix[1, 2] = 4.0;

            matrix[2, 0] = 5.0;
            matrix[2, 1] = -2.0;
            matrix[2, 2] = -3.0;

            Matrix m = new Matrix(3, 3);
            m = matrix.GetInverseMatrix();

            Console.WriteLine(m.ToString());
        }
    }
}
