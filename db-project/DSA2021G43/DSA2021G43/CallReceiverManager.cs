using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.IO.File;


namespace DSA2021G43
{
    internal class CallReceiverManager
    {
        public static string FilePath { get; set; }
        public Dictionary<string, CallReceiver> callReceivers;
        private static CallReceiverManager callReceiverManager = null;
        private CallReceiverManager() { }
        public static CallReceiverManager getInstance()
        {
            if (callReceiverManager == null)
                callReceiverManager = new CallReceiverManager();
            return callReceiverManager;
        }

        public void loadCallReceiverData()
        {
            callReceivers = new Dictionary<string, CallReceiver>();
            string[] lines = ReadAllLines(FilePath);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(',');
                CallReceiver callReceiver = new CallReceiver(words[0], words[1], (words[2]), words[3], long.Parse(words[4]), words[5], words[6], words[7], words[11]);
                callReceiver.CallsReceived = int.Parse(words[8]);
                callReceiver.Rating = int.Parse(words[9]);
                callReceiver.AvgResponseTime = int.Parse(words[10]);

                callReceivers.Add(words[0], callReceiver);
            }
        }

        public void WriteCallReceiverData()
        {
            List<string> lines = new List<string>();
            lines.Add("ID,Name,Password,Gender,Phone,Shift,Address,CallCenterID,CallsReceived,Rating,AverageResponseTime,Date");
            foreach (KeyValuePair<string, CallReceiver> c in callReceivers)
            {
                CallReceiver callReceiver = c.Value;
                string line = callReceiver.ID + "," + callReceiver.Name + "," + callReceiver.Password + "," + callReceiver.Gender + "," + callReceiver.Phone + "," + callReceiver.Shift + "," + callReceiver.HomeAddress + "," + callReceiver.CallCenterID + "," + callReceiver.CallsReceived + "," + callReceiver.Rating + "," + callReceiver.AvgResponseTime + "," + callReceiver.Date;
                lines.Add(line);
            }
            WriteAllLines(FilePath, lines);
        }

        public CallReceiver getCallReceiver(string id)
        {
            try
            {
                return callReceivers[id];
            }
            catch
            {
                return null;
            }
        }
    }
}
