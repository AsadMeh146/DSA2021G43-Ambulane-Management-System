using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2021G43
{
    internal class CallReceiver:Staff
    {
        public int CallsReceived { get; set; }
        public int Rating { get; set; }
        public int AvgResponseTime { get; set; }

        public CallReceiver(string id, string name, string password, string gender, long phone, string shift, string address, string callCenterId, string date)
        {
            this.ID = id;
            this.Name = name;
            this.Password = password;
            this.Gender = gender;
            this.Phone = phone;
            this.Shift = shift;
            this.HomeAddress = address;
            this.CallCenterID = callCenterId;
            this.Date = date;
            this.CallsReceived = 0;
            this.Rating = 0;
            this.AvgResponseTime = 0;
        }
    }
}
