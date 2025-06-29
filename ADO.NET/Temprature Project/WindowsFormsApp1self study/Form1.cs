using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1self_study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fahrenheitradiobutton.Checked == true)
            {
                double input = double.Parse(textBox1.Text);
                double result = (input * 1.8) + 32;
                //MessageBox.Show("result =" +result);
                textBox_result.Text = result.ToString();
            }
            if (celsiusradiobutton.Checked == true)
            {
                double input = double .Parse(textBox1.Text);
                double result = (input - 32) * 0.5555;
                textBox_result.Text = result.ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void fahrenheitradiobutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void celsiusradiobutton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
