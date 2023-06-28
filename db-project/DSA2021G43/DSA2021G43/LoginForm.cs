using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace DSA2021G43
{
    public partial class LoginForm : Form
    {
        private const string Admin_Name = "admin";
        private const string Admin_Pin = "admin";
        public LoginForm()
        {
            InitializeComponent();

            // setting up the file paths and loading the data from the csv files
            CityManager citymanager =  CityManager.getInstance();
            //CityManager.FilePath = @"C:\Users\MUBASHAR AHMAD\Documents\GitHub\dsa2021g43\CSV Files\cities.csv";
            CityManager.FilePath = @"C:\Users\Asad Mehmood\Documents\GitHub\dsa2021g43\CSV Files\cities.csv";
            //CityManager.FilePath = @"C:\Users\Sohail_Comp\Documents\GitHub\dsa2021g43\CSV Files\cities.csv";
            citymanager.LoadCitiesData();

            CallCenterManager callCenterManager = CallCenterManager.getInstance();
            //CallCenterManager.FilePath = @"C:\Users\MUBASHAR AHMAD\Documents\GitHub\dsa2021g43\CSV Files\callCenters.csv";
            CallCenterManager.FilePath = @"C:\Users\Asad Mehmood\Documents\GitHub\dsa2021g43\CSV Files\callCenters.csv";
            //CallCenterManager.FilePath = @"C:\Users\Sohail_Comp\Documents\GitHub\dsa2021g43\CSV Files\callCenters.csv";
            callCenterManager.loadCallCentersData();

            AmbulanceManager ambulanceManager = AmbulanceManager.getinstance();
            //AmbulanceManager.FilePath = @"C:\Users\MUBASHAR AHMAD\Documents\GitHub\dsa2021g43\CSV Files\ambulances.csv";
            AmbulanceManager.FilePath = @"C:\Users\Asad Mehmood\Documents\GitHub\dsa2021g43\CSV Files\ambulances.csv";
            //AmbulanceManager.FilePath = @"C:\Users\Sohail_Comp\Documents\GitHub\dsa2021g43\CSV Files\ambulances.csv";
            ambulanceManager.loadAmbulancesData();

            CallReceiverManager callReceiverManager = CallReceiverManager.getInstance();
            //CallReceiverManager.FilePath = @"C:\Users\MUBASHAR AHMAD\Documents\GitHub\dsa2021g43\CSV Files\callReceivers.csv";
            CallReceiverManager.FilePath = @"C:\Users\Asad Mehmood\Documents\GitHub\dsa2021g43\CSV Files\callReceivers.csv";
            //CallReceiverManager.FilePath = @"C:\Users\Sohail_Comp\Documents\GitHub\dsa2021g43\CSV Files\callReceivers.csv";
            callReceiverManager.loadCallReceiverData();

            DriverManager driverManager = DriverManager.getInstance();
            //DriverManager.FilePath = @"C:\Users\MUBASHAR AHMAD\Documents\GitHub\dsa2021g43\CSV Files\drivers.csv";
            DriverManager.FilePath = @"C:\Users\Asad Mehmood\Documents\GitHub\dsa2021g43\CSV Files\drivers.csv";
            //DriverManager.FilePath = @"C:\Users\Sohail_Comp\Documents\GitHub\dsa2021g43\CSV Files\drivers.csv";
            driverManager.loadDriversData();

            Graph graph = Graph.getInstance();
            //Graph.FilePath = @"C:\Users\MUBASHAR AHMAD\Documents\GitHub\dsa2021g43\CSV Files\cityEdges.csv";
            Graph.FilePath = @"C:\Users\Asad Mehmood\Documents\GitHub\dsa2021g43\CSV Files\cityEdges.csv";
            //Graph.FilePath = @"C:\Users\Sohail_Comp\Documents\GitHub\dsa2021g43\CSV Files\cityEdges.csv";
            graph.loadCityEdges();
            //graph.Dijkstra("Jhang");

            CallerManager callerManager = CallerManager.getInstance();
            //CallerManager.FilePath = @"C:\Users\MUBASHAR AHMAD\Documents\GitHub\dsa2021g43\CSV Files\callers.csv";
            CallerManager.FilePath = @"C:\Users\Asad Mehmood\Documents\GitHub\dsa2021g43\CSV Files\callers.csv";
            //CallerManager.FilePath = @"C:\Users\Sohail_Comp\Documents\GitHub\dsa2021g43\CSV Files\callers.csv";

            PatientManager patientManager = PatientManager.getInstance();
            //PatientManager.FilePath = @"C:\Users\MUBASHAR AHMAD\Documents\GitHub\dsa2021g43\CSV Files\patients.csv";
            PatientManager.FilePath = @"C:\Users\Asad Mehmood\Documents\GitHub\dsa2021g43\CSV Files\patients.csv";
            //PatientManager.FilePath = @"C:\Users\Sohail_Comp\Documents\GitHub\dsa2021g43\CSV Files\patients.csv";
            //foreach (KeyValuePair<CityVertex,  List<CityEdge>> l in graph.adjLists)
            //{
            //    List<CityEdge> cityEdge = l.Value;
            //    string s = l.Key.Name + "=> ";
            //    foreach (CityEdge edge in cityEdge)
            //    {
            //        s += edge.Dest.Name + ",";
            //    }
            //    MessageBox.Show(s);
            //}

            //string s = "";
            //foreach (CityVertex l in graph.set)
            //{
            //    s += l.Name + "=> " + l.Distance + "\n";
            //}
            //MessageBox.Show(s);
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = username_input.Text;
            string password = password_input.Text;
            username_input.Text = "";
            password_input.Text = "";

            if (username != "" && password != "")
            {
                if (admin_rb.Checked)
                {
                    if (username == Admin_Name && password == Admin_Pin)
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.ShowDialog();
                        //var thread = new Thread(() => { Application.Run(adminForm); });
                        //thread.Start();
                    }
                    else
                    {
                        MessageBox.Show("Invalid admin name and password");
                    }
                }
                else if(staff_rb.Checked)
                {
                    CallReceiverManager callReceiverManager = CallReceiverManager.getInstance();
                    bool isVerified = false;
                    string id = "";
                    foreach(CallReceiver callReceiver in callReceiverManager.callReceivers.Values)
                    {
                        if(callReceiver.Name == username && callReceiver.Password == password)
                        {
                            isVerified = true;
                            id = callReceiver.ID;
                            break;
                        }
                    }
                    if (isVerified)
                    {
                        StaffForm staffForm = new StaffForm(id);
                        staffForm.ShowDialog();
                        //var thread = new Thread(() => { Application.Run(staffForm); });
                        //thread.Start();
                    }
                    else
                    {
                        MessageBox.Show("invalid staff name and password");
                    }
                }
            }
            else
            {
                MessageBox.Show("username and password both are required");
            }
        }

        private void call_btn_Click(object sender, EventArgs e)
        {
            CallerForm callerForm = new CallerForm();
            var thread = new Thread(() => { Application.Run(callerForm); });
            thread.Start();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
