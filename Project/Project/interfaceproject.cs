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
    public partial class interfaceproject : Form
    {
        const string filename = "I:/employee/employee.txt";
        string name;
        string salary;
        double total;
        double ss;
        double vat;

        public interfaceproject()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(filename);
            string temp = "";
            while ((temp = sr.ReadLine()) != null)
            {
                string[] data = temp.Split('*');
                name = data[0];
                salary = data[2];

                if (comboBox1.Text == "Teeradech Kulsornnam")
                {
                    if (data[0] == "Teeradech Kulsornnam")
                    {
                        label16.Text = name;
                        label17.Text = salary;
                        label15.Text = salary;
                    }
                }

                if (comboBox1.Text == "Suthee Jansom")
                {
                    if (data[0] == "Suthee Jansom")
                    {
                        label16.Text = name;
                        label17.Text = salary;
                        label15.Text = salary;
                    }
                }
                if (comboBox1.Text == "Panapol Kitiapa")
                {
                    if (data[0] == "Panapol Kitiapa")
                    {
                        label16.Text = name;
                        label17.Text = salary;
                        label15.Text = salary;
                    }
                }
                if (comboBox1.Text == "Chonnipa Chakhatrakan")
                {
                    if (data[0] == "Chonnipa Chakhatrakan")
                    {
                        label16.Text = name;
                        label17.Text = salary;
                        label15.Text = salary;
                    }
                }
                if (comboBox1.Text == "Malee Aroina")
                {
                    if (data[0] == "Malee Aroina")
                    {
                        label16.Text = name;
                        label17.Text = salary;
                        label15.Text = salary;
                    }
                }
                if (comboBox1.Text == "Unif Greentea")
                {
                    if (data[0] == "Unif Greentea")
                    {
                        label16.Text = name;
                        label17.Text = salary;
                        label15.Text = salary;
                    }
                }
            }
            sr.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void interfaceproject_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addemployee addem = new addemployee();
            addem.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {
            
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double ss = double.Parse(label17.Text);
            ss = ss * 5 / 100;
            label7.Text = ss.ToString();

            double salary = double.Parse(label15.Text);
            total = salary - ss;
            label15.Text = total.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            vat = double.Parse(label17.Text);
            vat = vat * 7 / 100;
            label9.Text = vat.ToString();

            double salary = double.Parse(label15.Text);
            
            total = salary - vat;
            label15.Text = total.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double holiday = double.Parse(textBox1.Text);
            double salary = double.Parse(label15.Text);
            double h = 300;
            double totalh;
            totalh = holiday * h;
            total = salary - totalh;
            label15.Text = total.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double late = double.Parse(textBox2.Text);
            double salary = double.Parse(label15.Text);
            double l = 150;
            double totalL;
            totalL = late * l;
            total = salary - totalL;
            label15.Text = total.ToString();
        }
    }
}
