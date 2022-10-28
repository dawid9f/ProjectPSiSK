using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectPSiSK
{
    public class FileClass
    {
        public string fileUrl { get; set; }
        public FileClass()
        {
            UpdateFileUrl();
            WriteFIle("test");
        }

        public void UpdateFileUrl()
        {
            fileUrl = @".\logs\" + DateTime.Now.ToString("d") + ".txt";
        }

        public void WriteFIle(string data)
        {
            if (!System.IO.Directory.Exists(@".\logs"))
            {
                System.IO.Directory.CreateDirectory(@".\logs");
            }

            StreamWriter sw = new StreamWriter(fileUrl, true, Encoding.ASCII);
            sw.Write(data);
            sw.Close();
        }
    }
}
