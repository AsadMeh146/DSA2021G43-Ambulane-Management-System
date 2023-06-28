using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2021G43
{
    internal class City
    {
        public string Name { get; set; }
        public string CallCenterID { get; set; }

        public City(string name, string callCenterID)
        {
            Name = name;
            CallCenterID = callCenterID;
        }
    }
}
