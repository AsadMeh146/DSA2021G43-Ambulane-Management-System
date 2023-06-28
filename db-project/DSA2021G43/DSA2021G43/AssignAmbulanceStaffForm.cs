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
    public partial class AssignAmbulanceStaffForm : Form
    {
        public static bool IsAssigned { get; set; }
        public AssignAmbulanceStaffForm()
        {
            InitializeComponent();
        }

        public AssignAmbulanceStaffForm(string name, string city):this()
        {
            label1.Text = name + " from";
            label2.Text = city;
            label2.Left = label1.Left + label1.Width;
        }

        private void assign_ambulance_staff_btn_Click(object sender, EventArgs e)
        {
            if (AnswerCallStaffForm.IsReceived && StaffForm.callerName != "")
            {
                assign_ambulance_staff_btn.Enabled = false;
                assign_ambulance_staff_btn.BackColor = Color.LightGray;
                MakeCallCallerForm.label.Text = $"Ambulance Assigned to you!\n{MakeCallCallerForm.Details}";
                AnswerCallStaffForm.IsReceived = false;
                CallerManager callerManager = CallerManager.getInstance();
                callerManager.assignedCallers.Add(callerManager.callers.First());
                callerManager.callers.Clear();
                StaffForm.callerName = "";
                StaffForm.callerCity = "";
                IsAssigned = true;
            }
        }
    }
}
