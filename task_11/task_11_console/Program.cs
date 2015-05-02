using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeLib;
using StudentTestLib;

namespace task_11_console
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<Student> tree = new BinaryTree<Student>();

            Student std = new Student("Ilusha");
            Student std2 = new Student("Sonia");
            Student std3 = new Student("Pavel");
            Student std4 = new Student("Bob");
            Student std5 = new Student("Peter");

            string nameTest = "FirstTest";
            std.AddTest(nameTest, 10);
            std2.AddTest(nameTest, 5);
            std3.AddTest(nameTest, 4);
            std4.AddTest(nameTest, 9);
            std5.AddTest(nameTest, 2);

            nameTest = "SecondTest";
            std.AddTest(nameTest, 8);
            std2.AddTest(nameTest, 3);
            std3.AddTest(nameTest, 2);
            std4.AddTest(nameTest, 7);
            std5.AddTest(nameTest, 0);

            nameTest = "ThirdTest";
            std.AddTest(nameTest, 9);
            std2.AddTest(nameTest, 4);
            std3.AddTest(nameTest, 3);
            std4.AddTest(nameTest, 8);
            std5.AddTest(nameTest, 1);

            tree.Add(std);
            tree.Add(std2);
            tree.Add(std3);
            tree.Add(std4);
            tree.Add(std5);

            foreach (Student item in tree)
            {
                Console.WriteLine(item.NameOfStudent + "\t" + item.AverageMarkOfStudent + "\n");
            }
        }
    }
}
