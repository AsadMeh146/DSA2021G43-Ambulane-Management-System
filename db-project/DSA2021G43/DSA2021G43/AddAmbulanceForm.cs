using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA2021G43
{
    public partial class AddAmbulanceForm : Form
    {
        public AddAmbulanceForm()
        {
            InitializeComponent();
            CityManager cityManager = CityManager.getInstance();
            foreach(KeyValuePair<string,City> c in cityManager.cityList)
            {
                City city = c.Value;
                if(city.CallCenterID != "0")
                {
                    hospital_cb.Items.Add(c.Key);
                }
            }
            id_input.Text = RandomID.getRandomId();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string id = id_input.Text;
            string engine_no = engine_input.Text;
            string city = hospital_cb.Text;
            string purchase_date = purchaseDate.Value.ToString();
            purchase_date = purchase_date.Replace(", ", "-");
            
            if(engine_no != "" && city != "--select--")
            {
                CityManager cityManager = CityManager.getInstance();
                string callCenterID = cityManager.cityList[city].CallCenterID; 
                AmbulanceManager ambulanceManager = AmbulanceManager.getinstance();
                Ambulance ambulance = new Ambulance(id,engine_no,callCenterID,purchase_date);
                ambulanceManager.ambulances.Add(id, ambulance);
                CallCenterManager callCenterManager = CallCenterManager.getInstance();
                CallCenter callCenter = callCenterManager.getCallCenter(callCenterID);
                callCenter.AmbulancesIds.Add(id);
                ambulanceManager.WriteAmbulancesData();
                ambulanceManager.loadAmbulancesData();
                callCenterManager.WriteCallCentersData();
                callCenterManager.loadCallCentersData();
                engine_input.Text = "";
                hospital_cb.Text = "--select--";
                MessageBox.Show("Data added successfully");
            }
            else 
            {
                MessageBox.Show("All fields are required");
            }
            id_input.Text = RandomID.getRandomId();
        }
    }
}
