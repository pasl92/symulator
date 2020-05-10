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
        private string x; // combobox1
        private string y; // combomox2
        private string z;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            x = textBox1.Text;
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
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            x = "";
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
            if (comboBox2.SelectedIndex == 4)
            {
                textBox5.Text = x;
            }
            if (comboBox2.SelectedIndex == 5)
            {
                textBox6.Text = x;
            }
            if (comboBox2.SelectedIndex == 6)
            {
                textBox7.Text = x;
            }
            if (comboBox2.SelectedIndex == 7)
            {
                textBox8.Text = x;
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
            if (comboBox1.SelectedIndex == 4)
            {
                x = textBox5.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 5)
            {
                x = textBox6.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 6)
            {
                x = textBox7.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 7)
            {
                x = textBox8.Text.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                y = textBox1.Text.ToString();
            }

            if (comboBox2.SelectedIndex == 1)
            {
                y = textBox2.Text.ToString();
            }

            if (comboBox2.SelectedIndex == 2)
            {
                y = textBox3.Text.ToString();
            }

            if (comboBox2.SelectedIndex == 3)
            {
                y = textBox4.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 4)
            {
                y = textBox5.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 5)
            {
                y = textBox6.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 6)
            {
                y = textBox7.Text.ToString();
            }
            if (comboBox2.SelectedIndex == 7)
            {
                y = textBox8.Text.ToString();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("8086 – 16-bitowy mikroprocesor wprowadzony na rynek 8 czerwca 1978 roku");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paweł Sałata Informatyka i Ekonomteria 2019/2020");
        }

        private void button5_Click(object sender, EventArgs e)
        {

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
            if (comboBox2.SelectedIndex == 4)
            {
                textBox5.Text = x;
            }
            if (comboBox2.SelectedIndex == 5)
            {
                textBox6.Text = x;
            }
            if (comboBox2.SelectedIndex == 6)
            {
                textBox7.Text = x;
            }
            if (comboBox2.SelectedIndex == 7)
            {
                textBox8.Text = x;
            }


            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = y;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                textBox2.Text = y;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                textBox3.Text = y;
            }

            if (comboBox1.SelectedIndex == 3)
            {
                textBox4.Text = y;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                textBox5.Text = y;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                textBox6.Text = y;
            }
            if (comboBox1.SelectedIndex == 6)
            {
                textBox7.Text = y;
            }
            if (comboBox1.SelectedIndex == 7)
            {
                textBox8.Text = y;
            }
        


    }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
