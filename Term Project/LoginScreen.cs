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
    public partial class LoginScreen : Form
    {
        public static String privlages = "";
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            privlages = textBox1.Text;
            Home newHomeScreen = new Home();
            newHomeScreen.Show();
            this.Hide();
        }
    }
}
