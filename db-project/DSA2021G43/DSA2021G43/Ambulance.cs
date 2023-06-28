using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2021G43
{
    internal class Ambulance
    {
        public string ID { get; set; }
        public string EngineNo { get; set; }
        public string CallCenter { get; set; }
        public string PurchaseDate { get; set; }
        public Ambulance(string id,string engineNo,string callCenter,string purchaseDate)
        {
            this.ID = id;
            this.EngineNo = engineNo;
            this.CallCenter = callCenter;
            this.PurchaseDate = purchaseDate;
        }
    }
}
