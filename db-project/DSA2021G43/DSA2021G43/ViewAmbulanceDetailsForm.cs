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

namespace DSA2021G43
{
    public partial class ViewAmbulanceDetailsForm : Form
    {
        public ViewAmbulanceDetailsForm()
        {
            InitializeComponent();
            loadDatatoTable();
        }
        private void loadDatatoTable()
        {
            string filePath = AmbulanceManager.FilePath;
            string[] lines = ReadAllLines(filePath);
            string[] headerLabels = lines[0].Split(',');
            DataTable dataTable = new DataTable();
            foreach(String word in headerLabels)
            {
                dataTable.Columns.Add(word);
            }
            for (int i = 1; i < lines.Length; i++)
            {
                string[] dataWords = lines[i].Split(',');
                DataRow dataRow = dataTable.NewRow();
                int colIdx = 0;
                foreach (string word in headerLabels)
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
    }
    
}
