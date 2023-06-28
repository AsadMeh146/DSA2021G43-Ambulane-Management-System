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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            adminDashboardForm.FormBorderStyle = FormBorderStyle.None;
            this.adminPanel.Controls.Add(adminDashboardForm);
            adminDashboardForm.Show();
        }

        private void add_staff_btn_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            AddStaffForm addStaffForm = new AddStaffForm() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            addStaffForm.FormBorderStyle = FormBorderStyle.None;
            this.adminPanel.Controls.Add(addStaffForm);
            addStaffForm.Show();
        }

        private void view_update_staff_btn_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            ViewUpdateStaffForm viewUpdateStaffForm = new ViewUpdateStaffForm() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            viewUpdateStaffForm.FormBorderStyle = FormBorderStyle.None;
            this.adminPanel.Controls.Add(viewUpdateStaffForm);
            viewUpdateStaffForm.Show();
        }

        private void add_hospital_btn_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            AddHospitalForm addHospitalForm = new AddHospitalForm() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            addHospitalForm.FormBorderStyle = FormBorderStyle.None;
            this.adminPanel.Controls.Add(addHospitalForm);
            addHospitalForm.Show();
        }

        private void view_update_hospital_btn_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            ViewUpdateHospitalForm viewUpdateHospitalForm = new ViewUpdateHospitalForm() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            viewUpdateHospitalForm.FormBorderStyle = FormBorderStyle.None;
            this.adminPanel.Controls.Add(viewUpdateHospitalForm);
            viewUpdateHospitalForm.Show();
        }

        private void view_patient_details_btn_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            ViewPatientDetailsForm viewPatientDetailsForm = new ViewPatientDetailsForm() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            viewPatientDetailsForm.FormBorderStyle = FormBorderStyle.None;
            this.adminPanel.Controls.Add(viewPatientDetailsForm);
            viewPatientDetailsForm.Show();
        }

        private void add_ambulance_btn_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            AddAmbulanceForm addAmbulanceForm = new AddAmbulanceForm() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            addAmbulanceForm.FormBorderStyle = FormBorderStyle.None;
            this.adminPanel.Controls.Add(addAmbulanceForm);
            addAmbulanceForm.Show();
        }

        private void view_update_ambulance_btn_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            ViewAmbulanceDetailsForm viewAmbulanceDetailsForm = new ViewAmbulanceDetailsForm() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            viewAmbulanceDetailsForm.FormBorderStyle = FormBorderStyle.None;
            this.adminPanel.Controls.Add(viewAmbulanceDetailsForm);
            viewAmbulanceDetailsForm.Show();
        }

        private void view_reports_btn_Click(object sender, EventArgs e)
        {
            this.adminPanel.Controls.Clear();
            ViewAdminReportsForm viewAdminReportsForm = new ViewAdminReportsForm() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            viewAdminReportsForm.FormBorderStyle = FormBorderStyle.None;
            this.adminPanel.Controls.Add(viewAdminReportsForm);
            viewAdminReportsForm.Show();
        }
    }
}
