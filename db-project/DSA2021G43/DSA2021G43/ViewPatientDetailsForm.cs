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
    public partial class ViewPatientDetailsForm : Form
    {
        public ViewPatientDetailsForm()
        {
            InitializeComponent();
            loadDataToTable();
        }

        private void loadDataToTable()
        {
            string filePath = PatientManager.FilePath;

            string[] lines = ReadAllLines(filePath);
            DataTable dataTable = new DataTable();
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headers = firstLine.Split(',');
                foreach (string word in headers)
                {
                    dataTable.Columns.Add(word);
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
}
