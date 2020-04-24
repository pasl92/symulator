using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel_8086
{
    public partial class Form1 : Form
    {

        string rax;
        string rbx;
        string rcx;
        string rdx;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }


        private void button2_Click(object sender, EventArgs e)
        {

            string x = comboBox1.Items[0].ToString();


            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                MessageBox.Show("Wybierz poprawny rejestr");
            }

            if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 2))
            {

            }

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string rax = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string rbx = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string rcx = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string rdx = textBox4.Text;
        }
    }
}
