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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            CallReceiverManager callReceiverManager = CallReceiverManager.getInstance();
            DriverManager driverManager = DriverManager.getInstance();
            staff_members_lb.Text = (callReceiverManager.callReceivers.Count() + driverManager.drivers.Count()).ToString();
            CallCenterManager callCenterManager = CallCenterManager.getInstance();
            call_centers_lb.Text = callCenterManager.callCenters.Count().ToString();
            AmbulanceManager ambulanceManager = AmbulanceManager.getinstance();
            ambulances_lb.Text = ambulanceManager.ambulances.Count().ToString();
        }
    }
}
