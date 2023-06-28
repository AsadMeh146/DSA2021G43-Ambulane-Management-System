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
    public partial class ViewMapCallerForm : Form
    {
        Dictionary<string, PictureBox> pictureBoxes = new Dictionary<string, PictureBox>();
        public int X { get; set; }
        public int Y { get; set; }
        int Counter = 0;
        public ViewMapCallerForm()
        {
            InitializeComponent();
            
            timer1.Interval = 30;

            // getting all the picture boxes
            foreach (Control c in view_map_panel.Controls)
            {
                if (c is PictureBox)
                {
                    pictureBoxes.Add(c.Tag.ToString(), (PictureBox)c);
                }
            }
            try
            {
                location_picture.Visible = true;
                location_picture.Location = pictureBoxes[MakeCallCallerForm.AssignedPath[Counter]].Location;
                Counter++;
                Point point = pictureBoxes[MakeCallCallerForm.AssignedPath[Counter]].Location;
                X = point.X;
                Y = point.Y;
                Counter++;
                timer1.Enabled = true;
                timer1.Start();
            }
            catch
            {
                location_picture.Visible = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            string name = name_input.Text;
            string cnic = cnic_input.Text;
            string age = age_input.Text;
            string gender = gender_cb.Text;
            DateTimePicker date = new DateTimePicker();
            date.Value = DateTime.Now;
            if(name!="" && cnic!="" && age!="" && gender != "--select--")
            {
                PatientManager patientManager = PatientManager.getInstance();
                Patient patient = new Patient(name, cnic, age, gender, date.Value.ToString());
                patientManager.patients.Add(patient);
                patientManager.writePatientsData();
            }
            else 
            {
                MessageBox.Show("All fields are required");
            }
            name_input.Text = "";
            cnic_input.Text = "";
            age_input.Text = "";
            gender_cb.Text = "--select--";
            
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            int x = location_picture.Location.X;
            int y = location_picture.Location.Y;

            if (x < X)
            {
                x++;
            }
            if (y < Y)
            {
                y++;
            }
            if (x > X)
            {
                x--;
            }
            if ( y > Y)
            {
                y--;
            }
            location_picture.Location = new Point(x, y);
            if (MakeCallCallerForm.AssignedPath.Count() > Counter)
            {
                if (x == X && y==Y)
                {
                    Point point = pictureBoxes[MakeCallCallerForm.AssignedPath[Counter]].Location;
                    X = point.X;
                    Y = point.Y;
                
                    Counter++;
                }
            }
        }
    }
}
