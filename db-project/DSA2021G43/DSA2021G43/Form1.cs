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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressbar.Width = 0;
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            if (progressbar.Width <= panel1.Width)
            {
                progressbar.Width += 2;
            }
            else
            {
                timer1.Stop();
                //this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
        }
    }
}
