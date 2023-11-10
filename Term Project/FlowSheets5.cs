using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Term_Project
{
    public partial class FlowSheets5 : Form
    {
        public FlowSheets5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlowSheets frm = new FlowSheets();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
