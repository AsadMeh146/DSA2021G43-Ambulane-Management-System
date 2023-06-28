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
    public partial class StaffDashboardForm : Form
    {
        public StaffDashboardForm()
        {
            InitializeComponent();
        }

        public StaffDashboardForm(string id):this()
        {
            CallReceiverManager callReceiverManager = CallReceiverManager.getInstance();
            CallReceiver callReceiver = callReceiverManager.getCallReceiver(id);
            name_lb.Text = callReceiver.Name;
            id_lb.Text = callReceiver.ID;
            phone_lb.Text = callReceiver.Phone.ToString();
            shift_lb.Text = callReceiver.Shift;
            job_city_lb.Text = callReceiver.CallCenterID;
        }
    }
}
