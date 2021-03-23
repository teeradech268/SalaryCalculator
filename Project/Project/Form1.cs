using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text, password = textBox2.Text;
            Login log = new Login();

            if (username == "admin")
            {
                if (password == "4321")
                {
                    this.Hide();
                    interfaceproject itf = new interfaceproject();
                    itf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("passwordไม่ถูกต้อง");
                }
            }
            else
            {
                MessageBox.Show("usernameไม่ถูกต้อง");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
