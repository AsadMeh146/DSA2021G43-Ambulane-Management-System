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
    public partial class MakeCallCallerForm : Form
    {
        public static Label label;
        public static string Details { get; set; }
        public static List<string> AssignedPath = new List<string>();
        public static string AssignedCity { get; set; }
        public MakeCallCallerForm()
        {
            InitializeComponent();
            CityManager cityManager = CityManager.getInstance();
            foreach (City city in cityManager.cityList.Values)
            {
                city_cb.Items.Add(city.Name);
            }
            label = view_details_label;
        }

        private void call_btn_Click(object sender, EventArgs e)
        {
            AssignedPath = new List<string>();
            string name = name_input.Text;
            string city = city_cb.Text;
            if (name != "" && city != "--select--")
            {
                Graph graph = Graph.getInstance();
                graph.Dijkstra(city);
                string assignedCity = "";
                string route = "";
                int distance = 0;
                string callReceiverID = "";
                string callCenterID = "";

                CityManager cityManager = CityManager.getInstance();

                if (cityManager.getCity(city).CallCenterID =="0")
                {
                    foreach (CityVertex cityVertex in graph.set)
                    {
                        if (cityManager.getCity(cityVertex.Name).CallCenterID != "0")
                        {
                            assignedCity = cityVertex.Name;
                            distance = cityVertex.Distance;
                            callCenterID = cityManager.getCity(assignedCity).CallCenterID;
                            CallCenterManager callCenterManager = CallCenterManager.getInstance();
                            CallCenter callCenter = callCenterManager.getCallCenter(callCenterID);
                            if (callCenter.CallRecieiversIds.Count > 2 && callCenter.AmbulancesIds.Count > 2)
                            {
                                callReceiverID = callCenter.CallRecieiversIds[1];
                                DateTimePicker dateTimePicker = new DateTimePicker();
                                dateTimePicker.Value = DateTime.Now;
                                Caller caller = new Caller(name, city, dateTimePicker.Value.ToString(), callReceiverID, callCenterID);
                                CallerManager callerManager = CallerManager.getInstance();
                                callerManager.callers.Add(caller);
                                call_btn.Enabled = false;
                                call_btn.BackColor = Color.LightGray;

                                CallReceiverManager callReceiverManager = CallReceiverManager.getInstance();
                                call_receiver.Text = callReceiverManager.getCallReceiver(callReceiverID).Name;

                                List<string> list = new List<string>();
                                CityVertex cityVertex1 = graph.vertices[assignedCity];
                                while (cityVertex1.Name != city)
                                {
                                    list.Add(cityVertex1.Name);
                                    route += cityVertex1.Name + ",";
                                    cityVertex1 = cityVertex1.Parent;
                                }
                                route += city;
                                //MessageBox.Show(route);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    assignedCity = city;
                    
                    route = "in city";
                }

                Details = $"Assigned city: {assignedCity}\nRoute: {route}\nDistance: {distance}\nCallCenterID: {callCenterID}\nCallReceiverID: {callReceiverID}";
                string[] cities = route.Split(',');

                for (int i = cities.Count() -1; i >= 0; i--)
                {
                    AssignedPath.Add(cities[i]);
                }

                AssignedCity = assignedCity;
                view_details_label.Text = "calling...";
            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }

    }
}
