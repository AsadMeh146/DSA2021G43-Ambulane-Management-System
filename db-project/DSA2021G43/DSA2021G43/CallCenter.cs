using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2021G43
{
    internal class CallCenter
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public int beds { get; set; }
        public List<string> AmbulancesIds { get; set; }
        public List<string> CallRecieiversIds { get; set; }
        public List<string> DriversIds { get; set; }

        public CallCenter(string ID,string name,string city, string ambulances, string callReceivers, string drivers,int beds)
        {
            this.ID = ID;
            this.Name = name;
            this.City = city;
            this.beds = beds;
            AmbulancesIds = ambulances.Split(';').ToList();
            CallRecieiversIds = callReceivers.Split(';').ToList();
            DriversIds = drivers.Split(';').ToList();
        }
    }
}
