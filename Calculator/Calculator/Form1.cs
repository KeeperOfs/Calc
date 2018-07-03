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
        
      
        
        private void button4_Click_1(object sender, EventArgs e)
        {
            double Result;
            string FirstNumString = textBoxFirstIn.Text;
            double FirstNum = Convert.ToDouble(FirstNumString);
            string SecondNumString = textBoxSecondIn.Text;
            double SecondNum = Convert.ToDouble(SecondNumString);
            switch (((Button)sender).Name)
            {
                case "button1":
                    Result = FirstNum + SecondNum;
                    textBoxOut.Text = Result.ToString();
                    break;
                case "button2":
                    Result = FirstNum - SecondNum;
                    textBoxOut.Text = Result.ToString();
                    break;
                case "button3":
                    Result = FirstNum * SecondNum;
                    textBoxOut.Text = Result.ToString();
                    break;
                case "button4":
                    Result = FirstNum / SecondNum;
                    textBoxOut.Text = Result.ToString();
                    break;
                default:
                    throw new Exception("Неизвестная операция");

            }
           
        }
    }
}
