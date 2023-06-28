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
    public partial class ViewAdminReportsForm : Form
    {
        public ViewAdminReportsForm()
        {
            InitializeComponent();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            string start_Date = startDate.Value.ToString();
            string end_date = lastDate.Value.ToString();
            string type = type_cb.Text;
            if (type != "--type--")
            {
                if (type == "Call Receiver")
                {
                    CallReceiverManager callReceiverManager = CallReceiverManager.getInstance();
                    List<string> lines = new List<string>();
                    start_Date = start_Date.Split(' ')[0];
                    end_date = end_date.Split(' ')[0];
                    string[] sdate = start_Date.Split('/');
                    string[] edate = end_date.Split('/');

                    lines.Add("ID,Name,Password,Gender,Phone,Shift,Address,CallCenterID");
                    //MessageBox.Show("Hello!!!!!!");
                    foreach (KeyValuePair<string, CallReceiver> c in callReceiverManager.callReceivers)
                    {
                        CallReceiver callReceiver = c.Value;
                        string[] callReceiverDate = (callReceiver.Date.Split(' ')[0]).Split('/');
                        // comparing the years 
                        if (int.Parse(callReceiverDate[2]) >= int.Parse(sdate[2]) && int.Parse(callReceiverDate[2]) <= int.Parse(edate[2]))
                        {
                            //MessageBox.Show("Hello!!!!!! yearrrrrr");
                            if (int.Parse(callReceiverDate[1]) >= int.Parse(sdate[1]) && int.Parse(callReceiverDate[1]) <= int.Parse(edate[1]))
                            {
                                //MessageBox.Show("Hello!!!!!! monthhhhhh");
                                if (int.Parse(callReceiverDate[0]) >= int.Parse(sdate[0]) && int.Parse(callReceiverDate[0]) <= int.Parse(edate[0]))
                                {
                                    //MessageBox.Show("Hello!!!!!! dayyyyyyy");
                                    lines.Add(callReceiver.ID+","+callReceiver.Name+","+callReceiver.Password+","+callReceiver.Gender+","+callReceiver.Phone+","+callReceiver.Shift+","+callReceiver.HomeAddress+","+ callReceiver.CallCenterID);
                                }
                            }
                        }
                    }
                    loadDataToTable(lines);
                }
                else if (type == "Driver")
                {
                    DriverManager driverManager = DriverManager.getInstance();
                    List<string> lines = new List<string>();
                    start_Date = start_Date.Split(' ')[0];
                    end_date = end_date.Split(' ')[0];
                    string[] sdate = start_Date.Split('/');
                    string[] edate = end_date.Split('/');

                    lines.Add("ID,Name,Password,Gender,Phone,Shift,Address,CallCenterID");
                    //MessageBox.Show("Hello!!!!!!");
                    foreach (KeyValuePair<string, Driver> c in driverManager.drivers)
                    {
                        Driver driver = c.Value;
                        string[] callReceiverDate = (driver.Date.Split(' ')[0]).Split('/');
                        // comparing the years 
                        if (int.Parse(callReceiverDate[2]) >= int.Parse(sdate[2]) && int.Parse(callReceiverDate[2]) <= int.Parse(edate[2]))
                        {
                            //MessageBox.Show("Hello!!!!!! yearrrrrr");
                            if (int.Parse(callReceiverDate[1]) >= int.Parse(sdate[1]) && int.Parse(callReceiverDate[1]) <= int.Parse(edate[1]))
                            {
                                //MessageBox.Show("Hello!!!!!! monthhhhhh");
                                if (int.Parse(callReceiverDate[0]) >= int.Parse(sdate[0]) && int.Parse(callReceiverDate[0]) <= int.Parse(edate[0]))
                                {
                                    //MessageBox.Show("Hello!!!!!! dayyyyyyy");
                                    lines.Add(driver.ID + "," + driver.Name + "," + driver.Password + "," + driver.Gender + "," + driver.Phone + "," + driver.Shift + "," + driver.HomeAddress + "," + driver.CallCenterID);
                                }
                            }
                        }
                    }
                    loadDataToTable(lines);
                }
                else if (type == "Ambulance")
                {
                    AmbulanceManager ambulanceManager = AmbulanceManager.getinstance();
                    List<string> lines = new List<string>();
                    start_Date = start_Date.Split(' ')[0];
                    end_date = end_date.Split(' ')[0];
                    string[] sdate = start_Date.Split('/');
                    string[] edate = end_date.Split('/');

                    lines.Add("ID,EngineNo,CallCenter,PurchaseDate");
                    //MessageBox.Show("Hello!!!!!!");
                    foreach (KeyValuePair<string, Ambulance> c in ambulanceManager.ambulances)
                    {
                        Ambulance ambulance = c.Value;
                        string[] callReceiverDate = (ambulance.PurchaseDate.Split(' ')[0]).Split('/');
                        // comparing the years 
                        if (int.Parse(callReceiverDate[2]) >= int.Parse(sdate[2]) && int.Parse(callReceiverDate[2]) <= int.Parse(edate[2]))
                        {
                            //MessageBox.Show("Hello!!!!!! yearrrrrr");
                            if (int.Parse(callReceiverDate[1]) >= int.Parse(sdate[1]) && int.Parse(callReceiverDate[1]) <= int.Parse(edate[1]))
                            {
                                //MessageBox.Show("Hello!!!!!! monthhhhhh");
                                if (int.Parse(callReceiverDate[0]) >= int.Parse(sdate[0]) && int.Parse(callReceiverDate[0]) <= int.Parse(edate[0]))
                                {
                                    //MessageBox.Show("Hello!!!!!! dayyyyyyy");
                                    lines.Add(ambulance.ID + "," + ambulance.EngineNo + "," + ambulance.CallCenter + "," + ambulance.PurchaseDate);
                                }
                            }
                        }
                    }
                    loadDataToTable(lines);
                }
                else if (type == "Patient")
                {

                }
            }
        }

        public void loadDataToTable(List<string> lines)
        {
            DataTable dataTable = new DataTable();
            if (lines.Count > 0)
            {
                string firstLine = lines[0];
                string[] headers = firstLine.Split(',');
                foreach (string word in headers)
                {
                    dataTable.Columns.Add(word);
                }

                for (int i = 1; i < lines.Count; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dataRow = dataTable.NewRow();
                    int colIdx = 0;
                    foreach (string word in headers)
                    {
                        dataRow[word] = dataWords[colIdx];
                        colIdx++;
                    }
                    dataTable.Rows.Add(dataRow);
                }

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Data not found!");
            }
        }
    }
}
