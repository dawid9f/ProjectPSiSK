using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using ProjectPSiSK.Models;
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
        public bool IsEnable { get; set; }
        private DeviceClient _deviceClient { get; set; }
        private DeviceAuthenticationWithRegistrySymmetricKey _deviceAuthenticationKey { get; set; }

        public IoTHubService()
        {
            IsEnable = false;
        }

        public bool StartSendIoT(string devId, string devKey, string hostName)
        {
            DevId = devId;
            DevKey = devKey;
            HostName = hostName;

            try
            {
                _deviceAuthenticationKey = new DeviceAuthenticationWithRegistrySymmetricKey(DevId, DevKey);
                _deviceClient = DeviceClient.Create(HostName, _deviceAuthenticationKey, Microsoft.Azure.Devices.Client.TransportType.Mqtt);
                IsEnable = true;
                Send(new MessageModel("Start sending to IoT"));
                return true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public async void StopSendIoT()
        {
            if (IsEnable)
            {
                Send(new MessageModel("Stop sending to IoT"));
                IsEnable = false;
                await _deviceClient.CloseAsync();
                _deviceClient.Dispose();
            }
        }

        public async void Send(MessageModel messageModel)
        {
            if (IsEnable)
            {
                string messageString = JsonConvert.SerializeObject(messageModel);
                Microsoft.Azure.Devices.Client.Message message = new Microsoft.Azure.Devices.Client.Message(Encoding.ASCII.GetBytes(messageString));
                await _deviceClient.SendEventAsync(message);
            }
        }
    }
}
