using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeLib;

namespace StudentTestLib
{
    [Serializable]
    public class Test
    {
        public string NameOfTest { get; private set; }
        public int Mark { get; set; }

        public Test(string name, int mark)
        {
            NameOfTest = name;
            Mark = mark;
        }        
    }
}
