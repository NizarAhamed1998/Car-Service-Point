using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_service_point
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 0;
            int total = 0;
            int LC = 300;
            string vehicleType = " ";


            listBox1.Items.Clear();
            listBox1.Items.Add("Razin Car Service Point");
            listBox1.Items.Add("Customer Name :"+textBox1.Text);
            listBox1.Items.Add("Customer Vehicle Number :"+textBox2.Text);
            if (comboBox1.SelectedItem.ToString()=="HatchBack")
            {
                vehicleType = "HatchBack";
                listBox1.Items.Add("Vehicle Type :"+vehicleType);
            }
            else if (comboBox1.SelectedItem.ToString()=="SUV")
            {
                vehicleType = "SUV";
                listBox1.Items.Add("Vehicle Type :"+vehicleType);
            }

            if (checkBox1.Checked)
            {
                int temp = 800;
                listBox1.Items.Add("Cost of Air Filter :"+temp);
                total = temp;
            }
            if (checkBox2.Checked)
            {
                int temp = 20;
                listBox1.Items.Add("Cost of Air checkup :"+temp);
                total += temp;
            }
            if (checkBox3.Checked)
            {
                int temp = 300;
                int oil = (int)numericUpDown1.Value * temp;
                listBox1.Items.Add("Cost of Oil :"+oil);
                total += oil;
            }
            if (checkBox4.Checked)
            {
                int wash = 400;
                listBox1.Items.Add("Cost of Water Wash :"+wash);
                total += wash;
            }
            if (checkBox5.Checked)
            {
                if (comboBox2.SelectedItem.ToString()=="Petrol Filter")
                {
                     price = 200;
                     listBox1.Items.Add("cost of oil filter :"+price);
                     total += price;
                }
                else if (comboBox2.SelectedItem.ToString()=="Diesel Filter")
                {
                    price = 400;
                    listBox1.Items.Add("cost of oil filter"+price);
                    total += price;
                }
            }
            if (checkBox6.Checked)
            {
                if (comboBox3.SelectedItem.ToString()=="Petrol")
                {
                    price = 200;
                    listBox1.Items.Add("cost of fuel filter :"+price);
                    total += price;
                }
                else if (comboBox3.SelectedItem.ToString()=="Diesel")
                {
                    price = 400;
                    listBox1.Items.Add("cost of fuel filter :"+price);
                    total += price;
                }
            }
            listBox1.Items.Add("Labour Charge :"+LC);
            total += LC;
            listBox1.Items.Add("Total Amount is :"+total);
        }
    }
}
