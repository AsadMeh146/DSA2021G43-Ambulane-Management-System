using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2021G43
{
    static internal class RandomID
    {
        public static string getRandomId()
        {
            string id = "";
            Random rand = new Random();
            for (int y = 0; y < 10; y++)
            {
                char c = (char)rand.Next(65, 90);
                id += c;
            }
            return id;
        }
    }
}
