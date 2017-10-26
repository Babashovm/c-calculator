using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public double number1;
        public double number2;
        public string input;
        String operation;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "1";
            textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "2";
            textBox1.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "3";
            textBox1.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "4";
            textBox1.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "5";
            textBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "6";
            textBox1.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "7";
            textBox1.Text = input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "8";
            textBox1.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += "9";
            textBox1.Text = input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out number1);
            input += "+";
            textBox1.Text = input;
            input = "";
            operation = button10.Text;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out number2);

            MessageBox.Show(Convert.ToString(number1) + "  " + Convert.ToString(number2));

            switch (operation)
            {
                case "+":
                    textBox1.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    textBox1.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    textBox1.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    textBox1.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
