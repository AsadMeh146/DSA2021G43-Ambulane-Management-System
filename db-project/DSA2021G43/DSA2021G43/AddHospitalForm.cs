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
    public partial class AddHospitalForm : Form
    {
        public AddHospitalForm()
        {
            InitializeComponent();
            CityManager cityManager = CityManager.getInstance();
            Dictionary<string, City> cityList = cityManager.cityList;
            foreach(KeyValuePair<string,City> c in cityList)
            {
                if(c.Value.CallCenterID == "0")
                {
                    city_cb.Items.Add(c.Key);
                }
            }
            city_cb.SelectedValue = null;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string name = name_input.Text;
            string beds = beds_input.Text;
            string city = city_cb.Text;
            if(name != "" && beds != "" && city != "--select--")
            {
                string id = RandomID.getRandomId();
                CallCenter callCenter = new CallCenter(id, name, city, "0", "0", "0",int.Parse(beds));
                CallCenterManager callCenterManager = CallCenterManager.getInstance();
                callCenterManager.callCenters.Add(id, callCenter);
                callCenterManager.WriteCallCentersData();
                CityManager cityManager = CityManager.getInstance();
                cityManager.cityList[city].CallCenterID = id;
                cityManager.WriteCitiesData();
                city_cb.Items.Remove(city);
                MessageBox.Show("Record is added successfully");
            }
            else
            {
                MessageBox.Show("All fields are required!");
            }
            name_input.Text = "";
            beds_input.Text = "";
            city_cb.Text = "--select--";
        }
    }
}
