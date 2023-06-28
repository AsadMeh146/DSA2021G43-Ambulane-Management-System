using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.IO.File;
using System.Threading.Tasks;

namespace DSA2021G43
{
    class Graph
    {
        public Dictionary<CityVertex, List<CityEdge>> adjLists;
        public Dictionary<string, CityVertex> vertices;
        public List<CityVertex> set;
        private static Graph graph = null;
        public static string FilePath { get; set; }

        private Graph()
        {
            adjLists = new Dictionary<CityVertex, List<CityEdge>>();
            CityVertexManager cityVertexManager = CityVertexManager.getInstance();
            vertices = cityVertexManager.cityVertices;
        }

        public void loadCityEdges() 
        {
            string[] lines = ReadAllLines(FilePath);
            foreach(string line in lines) 
            {
                string[] words = line.Split(',');
                addEdge(words[0], words[1], int.Parse(words[2]));
            }
        }

        public static Graph getInstance()
        {
            if (graph == null)
            {
                graph = new Graph();
            }
            return graph;
        }

        public void addEdge(string src,string dest,int weight)
        {
            CityVertex srcV;
            CityVertex destV;

            try // to check if the src already exists
            {
                srcV = vertices[src];
            }
            catch // if src not found
            {
                srcV = new CityVertex(src);
                vertices.Add(src, srcV);
            }

            try // to check if the src already exists
            {
                destV = vertices[dest];
            }
            catch // if dest not found
            {
                destV = new CityVertex(dest);
                vertices.Add(dest, destV);
            }

            CityEdge edge_srcV_destV = new CityEdge(srcV, destV, weight);
            CityEdge edge_destV_srcV = new CityEdge(destV, srcV, weight);
            try
            {
                adjLists[srcV].Add(edge_srcV_destV);
            }
            catch
            {
                adjLists.Add(srcV, new List<CityEdge>());
                adjLists[srcV].Add(edge_srcV_destV);
            }

            try
            {
                adjLists[destV].Add(edge_destV_srcV);
            }
            catch
            {
                adjLists.Add(destV, new List<CityEdge>());
                adjLists[destV].Add(edge_destV_srcV);
            }
        }

        /// <summary>
        /// Shortes path algorithm
        /// </summary>
        /// <param name="start">starting name of city</param>
        public void Dijkstra(string start)
        {
            initializeVertices(start);
            
            List<CityVertex> queue = new List<CityVertex>();
            set = new List<CityVertex>();
            foreach (CityVertex cityVertex in vertices.Values)
            {
                queue.Add(cityVertex);
            }

            while(queue.Count > 0)
            {
                CityVertex cityVertex = queue[0];
                foreach(CityVertex c in queue)
                {
                    if (c.Distance < cityVertex.Distance)
                    {
                        cityVertex = c;
                    }
                }
                queue.Remove(cityVertex);
                set.Add(cityVertex);
                foreach (CityEdge cityEdge in adjLists[cityVertex])
                {
                    relax(cityVertex, cityEdge.Dest, cityEdge.Weight);
                }
            }
        }

        private void relax(CityVertex u, CityVertex v, int w)
        {
            if (v.Distance > u.Distance + w)
            {
                v.Distance = u.Distance + w;
                v.Parent = u;
            }
        }

        private void initializeVertices(string start)
        {
            foreach (CityVertex cityVertex in vertices.Values)
            {
                if(cityVertex.Name != start)
                {
                    cityVertex.Distance = Int32.MaxValue;
                    cityVertex.Parent = null;
                }
                else
                {
                    cityVertex.Distance = 0;
                }
            }
        }
    }
}
