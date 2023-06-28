using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2021G43
{
    class CityEdge
    {
        public CityVertex Src { get; set; }
        public CityVertex Dest { get; set; }
        public int Weight { get; set; }
        public CityEdge(CityVertex src,CityVertex dest,int weight)
        {
            Src = src;
            Dest = dest;
            Weight = weight;
        }
    }
}
