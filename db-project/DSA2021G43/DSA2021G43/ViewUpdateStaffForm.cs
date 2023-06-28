using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.IO.File;
using System.Text.RegularExpressions;

namespace DSA2021G43
{
    public partial class ViewUpdateStaffForm : Form
    {
        public ViewUpdateStaffForm()
        {
            InitializeComponent();
        }

        private void loadDataToTable(string category)
        {
            string filePath = "";
            if (category == "Call Reciever")
            {
                filePath = CallReceiverManager.FilePath;
            }
            else if (category == "Driver")
            {
                filePath = DriverManager.FilePath;
            }

            string[] lines = ReadAllLines(filePath);
            DataTable dataTable = new DataTable();
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headers = firstLine.Split(',');
                foreach (string word in headers)
                {
                    dataTable.Columns.Add(word);
                    if (word == "CallCenterID")
                        break;
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] rowWords = lines[i].Split(',');
                    DataRow dataRow = dataTable.NewRow();
                    int idx = 0;
                    foreach (string word in headers)
                    {
                        dataRow[word] = rowWords[idx];
                        idx++;
                        if (word == "CallCenterID")
                            break;
                    }
                    dataTable.Rows.Add(dataRow);
                }

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView.DataSource = dataTable;
                }
            }
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            if (category_cb.Text != "--select-category--")
            {
                loadDataToTable(category_cb.Text);
            }
            else
            {
                MessageBox.Show("Please select category first");
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            int colIndex = dataGridView.CurrentCell.ColumnIndex;
            string phone = dataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            int count = Regex.Matches(phone, @"[a-zA-Z]").Count;

            if(count == 0 && phone.Length >= 10)
            {
                if (colIndex == 1 || colIndex == 2 || colIndex == 4 || colIndex == 6)
                {
                    string address = dataGridView.Rows[rowIndex].Cells[6].Value.ToString();
                    string id = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                    if (category_cb.Text == "Call Reciever")
                    {
                        CallReceiverManager callReceiverManager = CallReceiverManager.getInstance();
                        CallReceiver callReceiver = callReceiverManager.getCallReceiver(id);
                        callReceiver.Name = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                        callReceiver.Password = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
                        callReceiver.Phone = long.Parse(phone);
                        
                        if (!address.Contains(","))
                            callReceiver.HomeAddress = address;
                        callReceiverManager.WriteCallReceiverData();
                        callReceiverManager.loadCallReceiverData();
                        loadDataToTable(category_cb.Text);
                    }
                    else if (category_cb.Text == "Driver")
                    {
                        DriverManager driverManager = DriverManager.getInstance();
                        Driver driver = driverManager.getDriver(id);
                        driver.Name = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                        driver.Password = dataGridView.Rows[rowIndex].Cells[2].Value.ToString();
                        driver.Phone = long.Parse(phone);
                        
                        if (!address.Contains(","))
                            driver.HomeAddress = address;
                        driverManager.WriteDriversData();
                        driverManager.loadDriversData();
                        loadDataToTable(category_cb.Text);
                    }
                }
                else
                {
                    MessageBox.Show("You can only update name, password, phone or address");
                }
            }
            else
            {
                MessageBox.Show("incorrect phone number format");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            int colIndex = dataGridView.CurrentCell.ColumnIndex;
            string id = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            if (category_cb.Text == "Call Reciever")
            {
                CallReceiverManager callReceiverManager = CallReceiverManager.getInstance();
                CallReceiver callReceiver = callReceiverManager.getCallReceiver(id);
                string callCenterId = callReceiver.CallCenterID;
                CallCenterManager callCenterManager = CallCenterManager.getInstance();
                CallCenter callCenter = callCenterManager.getCallCenter(callCenterId);
                callCenter.CallRecieiversIds.Remove(callReceiver.ID);
                callReceiverManager.callReceivers.Remove(id);
                callReceiverManager.WriteCallReceiverData();
                callReceiverManager.loadCallReceiverData();
                callCenterManager.WriteCallCentersData();
                callCenterManager.loadCallCentersData();
                loadDataToTable(category_cb.Text);
            }
            else if(category_cb.Text == "Driver")
            {
                DriverManager driverManager = DriverManager.getInstance();
                Driver driver = driverManager.getDriver(id);
                string callCenterId = driver.CallCenterID;
                CallCenterManager callCenterManager = CallCenterManager.getInstance();
                CallCenter callCenter = callCenterManager.getCallCenter(callCenterId);
                callCenter.DriversIds.Remove(driver.ID);
                driverManager.drivers.Remove(id);
                driverManager.WriteDriversData();
                driverManager.loadDriversData();
                callCenterManager.WriteCallCentersData();
                callCenterManager.loadCallCentersData();
                loadDataToTable(category_cb.Text);
            }
        }
    }
}
