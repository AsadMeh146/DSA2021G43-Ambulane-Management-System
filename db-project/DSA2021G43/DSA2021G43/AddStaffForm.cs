using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DSA2021G43
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
            CityManager cityManager = CityManager.getInstance();
            Dictionary<string, City> cities = cityManager.cityList;
            foreach(KeyValuePair<string,City> c in cities)
            {
                City city = c.Value;
                if(city.CallCenterID != "0")
                {
                    job_city_cb.Items.Add(c.Key);
                }
            }
            id_input.Text = RandomID.getRandomId();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string name = name_input.Text;
            string number = phone_input.Text;
            string gender = gender_cb.Text;
            string category = category_cb.Text;
            string shift = shift_cb.Text;
            string jobCity = job_city_cb.Text;
            string address = home_address_input.Text;
            string pass = password_input.Text;
            int count = 0;
            count = Regex.Matches(number, @"[a-zA-Z]").Count;
            if(name != "" && count == 0 && number.Length >= 11 && gender !=  "--select--" && pass != "" && category != "--select--" && shift != "--select--" && jobCity != "--select--" && address != "")
            {
                // to get the id of the call center from the city
                CityManager cityManager = CityManager.getInstance();
                string callCenterId = cityManager.cityList[jobCity].CallCenterID;

                // to get the object of call center
                CallCenterManager callCenterManager = CallCenterManager.getInstance();
                CallCenter callCenter = callCenterManager.callCenters[callCenterId];

                DateTimePicker dateTimePicker = new DateTimePicker();
                dateTimePicker.Value = DateTime.Now;
                string date = dateTimePicker.Value.ToString().Replace(", ", "-");
                if(category == "Call Reciever")
                {
                    CallReceiverManager callReceiverManager = CallReceiverManager.getInstance();
                    CallReceiver callReceiver = new CallReceiver(id_input.Text, name, pass, gender, long.Parse(number), shift, address, callCenterId, date);
                    callReceiverManager.callReceivers.Add(id_input.Text, callReceiver);
                    callCenter.CallRecieiversIds.Add(id_input.Text);

                    // to write data to file
                    callReceiverManager.WriteCallReceiverData();
                    callCenterManager.WriteCallCentersData();

                    // to load data from file
                    callReceiverManager.loadCallReceiverData();
                    callCenterManager.loadCallCentersData();
                }
                else if(category == "Driver")
                {
                    DriverManager driverManager = DriverManager.getInstance();
                    Driver driver = new Driver(id_input.Text, name, pass, gender, long.Parse(number), shift, address, callCenterId, date);
                    driverManager.drivers.Add(id_input.Text, driver);
                    callCenter.DriversIds.Add(id_input.Text);

                    // to write data to file
                    driverManager.WriteDriversData();
                    callCenterManager.WriteCallCentersData();

                    // to load data from file
                    driverManager.loadDriversData();
                    callCenterManager.loadCallCentersData();
                }

                // to reset all the feilds
                name_input.Text = "";
                phone_input.Text = "";
                home_address_input.Text = "";
                password_input.Text = "";
                gender_cb.Text = "--select--";
                category_cb.Text = "--select--";
                shift_cb.Text = "--select--";
                job_city_cb.Text = "--select--";
                MessageBox.Show("Data recorded successfully");
            }
            else
            {
                string message = "All fields are required!";
                if(count != 0)
                {
                    message += " and number cannot contain alphabets";
                }
                if(number.Length < 11)
                {
                    message += " number should be 11 digit or more";
                }
                MessageBox.Show(message);
            }
            // to reset the id
            id_input.Text = RandomID.getRandomId();
        }
    }
}
