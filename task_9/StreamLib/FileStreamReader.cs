using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamLib
{
    public class FileStreamReader: FileStream
    {
        string excptNegative = "Value must be aqual zero or more!";//
        public FileStreamReader(string path) :
            base(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
        {
        }

        public void ChangeTextInFile(string text, int offset, int removedLength, int addedLength)
        {
            if (offset < 0 || removedLength < 0 || addedLength < 0)
                throw new ArgumentException(excptNegative);

            this.Seek(offset, SeekOrigin.Begin);
            this.SetLength(this.Length - removedLength + addedLength);

            using (StreamWriter sw = new StreamWriter(this))
            {
                sw.Write(text);
            }
        }
    }
}
