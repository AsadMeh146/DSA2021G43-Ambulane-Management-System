using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.IO.File;

namespace DSA2021G43
{
    internal class DriverManager
    {
        public static string FilePath { get; set; }
        public Dictionary<string, Driver> drivers;
        private static DriverManager driverManager = null;
        private DriverManager() { }

        public static  DriverManager getInstance()
        {
            if (driverManager == null)
                driverManager = new DriverManager();
            return driverManager;
        }

        public void loadDriversData()
        {
            drivers = new Dictionary<string, Driver>();
            string[] lines = ReadAllLines(FilePath);
            for (int i = 1; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(',');
                Driver driver = new Driver(words[0], words[1], (words[2]), words[3], long.Parse(words[4]), words[5], words[6], words[7], words[8]);
                drivers.Add(words[0], driver);
            }
        }
        public void WriteDriversData()
        {
            List<string> lines = new List<string>();
            lines.Add("ID,Name,Password,Gender,Phone,Shift,Address,CallCenterID,Date");
            foreach (KeyValuePair<string, Driver> c in drivers)
            {
                Driver driver = c.Value;
                string line = driver.ID + "," + driver.Name + "," + driver.Password + "," + driver.Gender + "," + driver.Phone + "," + driver.Shift + "," + driver.HomeAddress + "," + driver.CallCenterID + "," + driver.Date;
                lines.Add(line);
            }
            WriteAllLines(FilePath, lines);
        }

        public Driver getDriver(string id)
        {
            try
            {
                return drivers[id];
            }
            catch
            {
                return null;
            }
        }
    }
}
