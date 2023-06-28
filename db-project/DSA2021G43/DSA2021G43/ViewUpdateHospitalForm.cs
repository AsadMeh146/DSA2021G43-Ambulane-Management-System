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
    public partial class ViewUpdateHospitalForm : Form
    {
        public ViewUpdateHospitalForm()
        {
            InitializeComponent();
            loadDataToTable();
        }

        private void loadDataToTable()
        {
            string path = CallCenterManager.FilePath;
            string[] lines = System.IO.File.ReadAllLines(path);
            DataTable dataTable = new DataTable();
            if(lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headers = firstLine.Split(',');
                foreach(string word in headers)
                {
                    dataTable.Columns.Add(word);
                }

                for(int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dataRow = dataTable.NewRow();
                    int colIdx = 0;
                    foreach(string word in headers)
                    {
                        dataRow[word] = dataWords[colIdx];
                        colIdx++;
                    }
                    dataTable.Rows.Add(dataRow);
                }

                if(dataTable.Rows.Count > 0)
                {
                    dataGridView.DataSource = dataTable;
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            int colIndex = dataGridView.CurrentCell.ColumnIndex;
            //MessageBox.Show(dataGridView.Rows[rowIndex].Cells[0].Value.ToString(), dataGridView.Rows[rowIndex].Cells[colIndex].Value.ToString());
            string id = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            CallCenterManager callCenterManager = CallCenterManager.getInstance();
            CallCenter callCenter = callCenterManager.getCallCenter(id);

            // to remove all rferences of ambulances from the deleted call center
            AmbulanceManager ambulanceManager = AmbulanceManager.getinstance();
            for (int i = 0; i < callCenter.AmbulancesIds.Count; i++)
            {
                string ambulanceID = callCenter.AmbulancesIds[i];
                if (ambulanceID != "0" && ambulanceID != "")
                    ambulanceManager.ambulances.Remove(ambulanceID);
            }

            // to remove all rferences of call receivers from the deleted call center
            CallReceiverManager callReceiverManager = CallReceiverManager.getInstance();
            for (int i = 0; i < callCenter.CallRecieiversIds.Count; i++)
            {
                string callReceiverID = callCenter.CallRecieiversIds[i];
                if (callReceiverID != "0" && callReceiverID != "")
                    callReceiverManager.callReceivers.Remove(callReceiverID);
            }

            // to remove all rferences of Drivers from the deleted call center
            DriverManager driverManager = DriverManager.getInstance();
            for (int i = 0; i < callCenter.DriversIds.Count; i++)
            {
                string driverID = callCenter.DriversIds[i];
                if (driverID != "0" && driverID != "")
                    driverManager.drivers.Remove(driverID);
            }

            // to remove call center
            string city = callCenter.City;
            callCenterManager.callCenters.Remove(id);

            // to remove rference of call center from the city
            CityManager cityManager = CityManager.getInstance();
            City city1 = cityManager.getCity(city);
            city1.CallCenterID = "0";

            // to save changed data to files
            ambulanceManager.WriteAmbulancesData();
            callReceiverManager.WriteCallReceiverData();
            driverManager.WriteDriversData();
            callCenterManager.WriteCallCentersData();
            cityManager.WriteCitiesData();

            // to load data from files
            ambulanceManager.loadAmbulancesData();
            callReceiverManager.loadCallReceiverData();
            driverManager.loadDriversData();
            callCenterManager.loadCallCentersData();
            cityManager.LoadCitiesData();
            loadDataToTable();

            MessageBox.Show("Data deleted successfully");
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView.CurrentCell.RowIndex;
            int colIndex = dataGridView.CurrentCell.ColumnIndex;
            if (colIndex == 1 || colIndex == 6)
            {
                string id = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                //MessageBox.Show(id);
                CallCenterManager callCenterManager = CallCenterManager.getInstance();
                CallCenter callCenter = callCenterManager.getCallCenter(id);
                //MessageBox.Show(callCenter.Name);
                callCenter.Name = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                callCenter.beds = int.Parse(dataGridView.Rows[rowIndex].Cells[6].Value.ToString());
                callCenterManager.WriteCallCentersData();
                callCenterManager.loadCallCentersData();
                loadDataToTable();
                MessageBox.Show("Data updated successfully");
            }
            else
            {
                MessageBox.Show("You can only update name and numbers of beds");
            }
        }
    }
}
