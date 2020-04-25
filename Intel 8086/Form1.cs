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
        private string rax;
        private string rbx;
        private string rcx;
        private string rdx;
        private string x;


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

            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                MessageBox.Show("Wybierz poprawny rejestr");
            }

            //if ((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 1))
            //{
            //    textBox1.Text = textBox2.Text;
            //}

            if (comboBox2.SelectedIndex == 0)
            {
                textBox1.Text = x;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                textBox2.Text = x;
            }

            if (comboBox2.SelectedIndex == 2)
            {
                textBox3.Text = x;
            }

            if (comboBox2.SelectedIndex == 3)
            {
                textBox4.Text = x;
            }
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                x = textBox1.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                x = textBox2.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 2)
            {
                x = textBox3.Text.ToString();
            }

            if (comboBox1.SelectedIndex == 3)
            {
                x = textBox4.Text.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rax = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            rbx = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            rcx = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            rdx = textBox4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("8086 – 16-bitowy mikroprocesor wprowadzony na rynek 8 czerwca 1978 roku");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paweł Sałata Informatyka i Ekonomteria 2019/2020");
        }
    }
}
