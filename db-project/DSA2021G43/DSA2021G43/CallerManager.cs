using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.IO.File;

namespace DSA2021G43
{
    internal class CallerManager
    {
        public List<Caller> callers = new List<Caller>();
        public List<Caller> assignedCallers = new List<Caller>();
        public static string FilePath { get; set; }
        private static CallerManager callerManager = null;

        private CallerManager() { }

        public static CallerManager getInstance()
        {
            if (callerManager == null)
                callerManager = new CallerManager();
            return callerManager;
        }

        //public void writeCallersData()
        //{
        //    List<string> lines = ReadAllLines(FilePath).ToList();
        //    foreach(Caller caller in callers)
        //    {
        //        bool isPresent = false;
        //        string line = $"{caller.Name},{caller.City},{caller.Date},{caller.CallReceiverID},{caller.CallCenterID}";
        //        for (int i=0; i<lines.Count; i++)
        //        {
        //            string[] words = lines[i].Split(',');
        //            if (words[0] == caller.Name)
        //                isPresent = true;
        //        }
        //        if (!isPresent)
        //            lines.Add(line);
        //    }
        //    WriteAllLines(FilePath, lines);
        //}
    }
}
