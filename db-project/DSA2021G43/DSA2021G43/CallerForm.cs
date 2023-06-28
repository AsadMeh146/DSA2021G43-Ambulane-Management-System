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
    public partial class CallerForm : Form
    {
        public CallerForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void makecall_btn_Click(object sender, EventArgs e)
        {
            this.callerPanel.Controls.Clear();
            MakeCallCallerForm makecallerForm = new MakeCallCallerForm() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            makecallerForm.FormBorderStyle = FormBorderStyle.None;
            this.callerPanel.Controls.Add(makecallerForm);
            makecallerForm.Show();
        }

        private void answer_call_btn_Click(object sender, EventArgs e)
        {
            this.callerPanel.Controls.Clear();
            ViewMapCallerForm answercallerForm = new ViewMapCallerForm() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            answercallerForm.FormBorderStyle = FormBorderStyle.None;
            this.callerPanel.Controls.Add(answercallerForm);
            answercallerForm.Show();
        }

        private void goback_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
