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
    public partial class StaffForm : Form
    {
        public static string CallReceiverID { get; set; }
        public string AmbulanceID { get; set; }
        public static string callerName = "";
        public static string callerCity = "";
        public StaffForm()
        {
            InitializeComponent();
            
        }

        public StaffForm(string id):this()
        {
            CallReceiverID = id;
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            this.staffPanel.Controls.Clear();
            StaffDashboardForm staff = new StaffDashboardForm(CallReceiverID){ Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            staff.FormBorderStyle = FormBorderStyle.None;
            this.staffPanel.Controls.Add(staff);
            staff.Show();
        }

        private void answer_call_btn_Click(object sender, EventArgs e)
        {
            //answer_call_btn.Enabled = false;
            this.staffPanel.Controls.Clear();

            CallerManager callerManager = CallerManager.getInstance();
            CallCenterManager callCenterManager = CallCenterManager.getInstance();
            CallCenter callCenter = null;

            foreach (Caller caller in callerManager.callers)
            {
                if (caller.CallReceiverID == CallReceiverID)
                {
                    callCenter = callCenterManager.getCallCenter(caller.CallCenterID);
                    AmbulanceID = callCenter.AmbulancesIds.Last();
                    callerName = caller.Name;
                    callerCity = caller.City;
                }
            }

            AnswerCallStaffForm answerCall = new AnswerCallStaffForm(callerName, callerCity) { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            answerCall.FormBorderStyle = FormBorderStyle.None;
            this.staffPanel.Controls.Add(answerCall);
            answerCall.Show();
        }

        private void assign_ambulance_btn_Click(object sender, EventArgs e)
        {
            this.staffPanel.Controls.Clear();
            AssignAmbulanceStaffForm assign;
            if (AnswerCallStaffForm.IsReceived)
            {
                assign = new AssignAmbulanceStaffForm(callerName, callerCity) { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            }
            else
            {
                assign = new AssignAmbulanceStaffForm() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            }
            assign.FormBorderStyle = FormBorderStyle.None;
            this.staffPanel.Controls.Add(assign);
            assign.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
