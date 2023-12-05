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
            label1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "student") || (textBox1.Text == "instructor") || (textBox1.Text == "simteam"))
            {
                privlages = textBox1.Text;
                Home homeScreen = new Home();
                homeScreen.Location = this.Location;
                homeScreen.StartPosition = FormStartPosition.Manual;
                homeScreen.FormClosing += delegate { this.Show(); };
                homeScreen.Show();
                this.Hide();
            }
            else
            {
                label1.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
