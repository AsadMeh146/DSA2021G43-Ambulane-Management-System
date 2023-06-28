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
    public partial class AnswerCallStaffForm : Form
    {
        public static bool IsReceived { get; set; }
        public AnswerCallStaffForm()
        {
            InitializeComponent();
            if (IsReceived)
            {
                receive_call_staff_btn.Enabled = false;
                receive_call_staff_btn.BackColor = Color.LightGray;
            }
        }

        public AnswerCallStaffForm(string name, string city):this()
        {
            if (name != "")
            {
                label1.Text = name + " from";
                label2.Text = city;
                label2.Left = label1.Left + label1.Width;
            }
        }

        private void receive_call_staff_btn_Click(object sender, EventArgs e)
        {
            if (StaffForm.callerCity != "")
            {
                receive_call_staff_btn.Enabled = false;
                receive_call_staff_btn.BackColor = Color.LightGray;
                MakeCallCallerForm.label.Text = "Your call received!";
                IsReceived = true;
            }
        }
    }
}
