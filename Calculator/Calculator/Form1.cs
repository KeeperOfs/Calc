using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
      
        double Result;
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //string FirstNumString = textBoxFirstIn.Text;
            //textBoxFirstIn.Text = FirstNumString;
            //double FirstNum = Convert.ToDouble(FirstNumString);
        }

        private void textBoxSecondIn_TextChanged(object sender, EventArgs e)
        {
            //string SecondNumString = textBoxSecondIn.Text;
            //textBoxSecondIn.Text = SecondNumString;
            //double SecondNum = Convert.ToDouble(SecondNumString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstNumString = textBoxFirstIn.Text;
            double FirstNum = Convert.ToDouble(FirstNumString);
            string SecondNumString = textBoxSecondIn.Text;
            double SecondNum = Convert.ToDouble(SecondNumString);
            Result = FirstNum + SecondNum;
            textBoxOut.Text = Result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FirstNumString = textBoxFirstIn.Text;
            double FirstNum = Convert.ToDouble(FirstNumString);
            string SecondNumString = textBoxSecondIn.Text;
            double SecondNum = Convert.ToDouble(SecondNumString);
            Result = FirstNum - SecondNum;
            textBoxOut.Text = Result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string FirstNumString = textBoxFirstIn.Text;
            double FirstNum = Convert.ToDouble(FirstNumString);
            string SecondNumString = textBoxSecondIn.Text;
            double SecondNum = Convert.ToDouble(SecondNumString);
            Result = FirstNum * SecondNum;
            textBoxOut.Text = Result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string FirstNumString = textBoxFirstIn.Text;
            double FirstNum = Convert.ToDouble(FirstNumString);
            string SecondNumString = textBoxSecondIn.Text;
            double SecondNum = Convert.ToDouble(SecondNumString);
            Result = FirstNum / SecondNum;
            textBoxOut.Text = Result.ToString();
        }
    }
}
