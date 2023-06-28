using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.IO.File
    ;
namespace DSA2021G43
{
    internal class CityManager
    {
        public static string FilePath { get; set; }
        public Dictionary<string, City> cityList;
        private static CityManager cityManager = null;
        private CityManager() { }

        public static CityManager getInstance()
        {
            if (cityManager == null)
            {
                cityManager = new CityManager();
            }
            return cityManager;
        }

        public City getCity(string id)
        {
            try
            {
                return cityList[id];
            }
            catch
            {
                return null;
            }
        }

        public void LoadCitiesData()
        {
            cityList = new Dictionary<string, City>();
            string[] lines = ReadAllLines(FilePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(',');
                City city = new City(words[0], words[1]);
                cityList.Add(words[0], city);
            }
        }
        public void WriteCitiesData()
        {
            List<string> lines = new List<string>();
            lines.Add("Name,CallCenter");
            foreach(KeyValuePair<string, City> c in cityList)
            {
                City city = c.Value;
                string line = city.Name + "," + city.CallCenterID;
                lines.Add(line);
            }
            WriteAllLines(FilePath, lines);
        }
    }
}
