using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.IO.File;
namespace DSA2021G43
{
    class AmbulanceManager
    {
        public static string FilePath { get; set; }
        public Dictionary<string, Ambulance> ambulances;
        private static AmbulanceManager ambulanceManager = null;

        private AmbulanceManager() { }

        public static AmbulanceManager getinstance()
        {
            if(ambulanceManager == null)
            {
                ambulanceManager = new AmbulanceManager();
            }
            return ambulanceManager;
        }

        public void loadAmbulancesData()
        {
            ambulances = new Dictionary<string, Ambulance>();
            string[] lines = ReadAllLines(FilePath);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(',');
                Ambulance ambulance = new Ambulance(words[0], words[1], words[2],words[3]);
                ambulances.Add(words[0], ambulance);
            }
        }
        public void WriteAmbulancesData()
        {
            List<string> lines = new List<string>();
            lines.Add("Name,EngineNo,CallCenter,PurchaseDate");
            foreach (KeyValuePair<string, Ambulance> c in ambulances)
            {
                Ambulance ambulance = c.Value;
                string line = ambulance.ID + "," + ambulance.EngineNo + ","+ ambulance.CallCenter + "," + ambulance.PurchaseDate;
                lines.Add(line);
            }
            WriteAllLines(FilePath, lines);
        }
    }
}
