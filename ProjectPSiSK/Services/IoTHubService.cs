using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPSiSK.Services
{
    public class IoTHubService
    {
        public string DevId { get; set; }
        public string DevKey { get; set; }
        public string HostName { get; set; }

        public IoTHubService()
        {

        }

        public bool StartSendIoT(string devId, string devKey, string hostName)
        {
            DevId = devId;
            DevKey = devKey;
            HostName = hostName;

            return true;
        }

        public void StopSendIoT()
        {
            
        }
    }
}
