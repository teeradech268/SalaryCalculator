using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class addemployee : Form
    {
        string name;
        const string filename = "I:/employee/employee.txt";

        public addemployee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string fname = Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string lname = Console.ReadLine();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string byear = Console.ReadLine();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string salary = Console.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            string byear = textBox3.Text;
            string salary = textBox4.Text;
            StreamWriter sw = new StreamWriter(filename, true);
            sw.WriteLine("{0} {1}*{2}*{3}", fname, lname, byear, salary);
            sw.Close();
            MessageBox.Show("บันทึกเรียบร้อย");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
