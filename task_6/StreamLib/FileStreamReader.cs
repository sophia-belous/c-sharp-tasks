using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamLib
{
    public class FileStreamReader : FileStream
    {
        private int _bytesReaded;
        string Password {private get; private set; }

        public FileStreamReader(string path, string password) :
            base (path, FileMode.Open, FileAccess.Read)
        {
            if (path == null || password == null)
                throw new ArgumentNullException(ResourceExp.NullExp);

            _bytesReaded = 0;
            Password = password;
        }


                //      //                                      //%
        public string ReadString(byte[] array, int offset, int count)
        {
            if (offset == null || count == null)
                throw new ArgumentNullException(ResourceExp.NullExp);

            _bytesReaded += count;
            base.Read(array, offset, count);
            return Encoding.ASCII.GetString(array);
        }

        public override int ReadByte()
        {
            _bytesReaded++;
            return base.ReadByte();
        }

        public int ReadedPercent
        {
            get
            {
                return (int)(Math.Round(_bytesReaded / (double)Length, 2) * 100);
            }
        }
       

    }
}
