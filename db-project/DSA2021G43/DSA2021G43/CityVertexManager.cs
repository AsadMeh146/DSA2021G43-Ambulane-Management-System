using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2021G43
{
    class CityVertexManager
    {
        public Dictionary<string,CityVertex> cityVertices = new Dictionary<string, CityVertex>();
        private static CityVertexManager cityVertexManager = null;

        private CityVertexManager() 
        {
            CityManager cityManager = CityManager.getInstance();
            foreach(KeyValuePair<string,City> c in cityManager.cityList)
            {
                string city = c.Key;
                CityVertex cityVertex = new CityVertex(city);
                cityVertices.Add(city, cityVertex);
            }
        }

        public static CityVertexManager getInstance()
        {
            if(cityVertexManager == null)
            {
                cityVertexManager = new CityVertexManager();
            }
            return cityVertexManager;
        }


    }
}
