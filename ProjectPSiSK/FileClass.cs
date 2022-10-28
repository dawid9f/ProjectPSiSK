using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPSiSK
{
    public class FileClass
    {
        public string fileUrl { get; set; }

        public FileClass()
        {
            UpdateFileUrl();
        }

        public void UpdateFileUrl()
        {
            fileUrl = "/logs/" + DateTime.Now.ToString("d") + ".txt";
        }
    }
}
