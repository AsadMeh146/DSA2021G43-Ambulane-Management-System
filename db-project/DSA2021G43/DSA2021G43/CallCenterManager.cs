using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.IO.File;

namespace DSA2021G43
{
    internal class CallCenterManager
    {
        public static string FilePath { get; set; }
        public Dictionary<string , CallCenter> callCenters;
        private static CallCenterManager callCenterManager = null;
        private CallCenterManager() { }

        public static CallCenterManager getInstance()
        {
            if (callCenterManager == null)
                callCenterManager = new CallCenterManager();
            return callCenterManager;
        }

        public void loadCallCentersData()
        {
            callCenters = new Dictionary<string, CallCenter>();
            string [] lines = ReadAllLines(FilePath);
            for(int i = 1; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(',');
                CallCenter callCenter = new CallCenter(words[0], words[1], words[2],words[3], words[4], words[5],int.Parse(words[6]));
                callCenters.Add(words[0], callCenter);
            }
        }

        public CallCenter getCallCenter(string id)
        {
            try
            {
                return callCenters[id];
            }
            catch
            {
                return null;
            }
        }
        public void WriteCallCentersData()
        {
            List<string> lines = new List<string>();
            lines.Add("ID,Name,City,Ambulances,CallReceivers,Drivers,Beds");
            foreach (KeyValuePair<string, CallCenter> c in callCenters)
            {
                CallCenter callCentre = c.Value;
                string id_1 = callCentre.ID;
                string name = callCentre.Name;
                string city = callCentre.City;
                int beds = callCentre.beds;
                string ambulancesId = "";
                string callReceiversID = "";
                string drivers = "";
                foreach(string s in callCentre.AmbulancesIds)
                {
                    if(s != "")
                        ambulancesId += s + ";";
                }
                foreach (string s1 in callCentre.CallRecieiversIds)
                {
                    if (s1 != "")
                        callReceiversID += s1 + ";";
                }
                foreach (string s2 in callCentre.DriversIds)
                {
                    if (s2 != "")
                        drivers += s2 + ";";
                }
                string line = id_1 + "," + name + "," + city + "," + ambulancesId + "," + callReceiversID + "," + drivers+ "," + beds;
                lines.Add(line);
            }

            WriteAllLines(FilePath, lines);
        }
    }
}
