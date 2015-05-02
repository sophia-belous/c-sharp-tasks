using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeLib;

namespace StudentTestLib
{
    [Serializable]
    public class Student : IComparable<Student>
    {
        private List<Test> _tests = new List<Test>();

        public string NameOfStudent { get; private set; }
        public double AverageMarkOfStudent { get { return _tests.Average(x => x.Mark); } }        

        public Student(string name)
        {
            NameOfStudent = name;
        }

        public void AddTest(string nameOfTest, int mark)
        {
            _tests.Add(new Test(nameOfTest, mark));
        }

        public int CompareTo(Student otherStudent)
        {
            if (otherStudent == null)
                throw new ArgumentNullException();

            return AverageMarkOfStudent.CompareTo(otherStudent.AverageMarkOfStudent);
        }
    }
}
