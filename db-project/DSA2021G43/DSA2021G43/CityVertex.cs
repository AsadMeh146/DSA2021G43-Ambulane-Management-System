using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2021G43
{
    class CityVertex
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Distance { get; set; }
        public CityVertex Parent { get; set; }
        public CityVertex(string name)
        {
            Name = name;
            Color = "White";
            Distance = 0;
        }
    }
}
