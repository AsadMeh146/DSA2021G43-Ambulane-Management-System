using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2021G43
{
    internal class Caller
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Date { get; set; }
        public string CallReceiverID { get; set; }
        public string CallCenterID { get; set; }
        public string AmbulanceID { get; set; }

        public Caller(string name, string city, string date, string callReceiverID, string callCenterID)
        {
            Name = name;
            City = city;
            Date = date;
            CallReceiverID = callReceiverID;
            CallCenterID = callCenterID;
            AmbulanceID = "";
        }
    }
}
