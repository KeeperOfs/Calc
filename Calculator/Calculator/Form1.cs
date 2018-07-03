using System;
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
            string firstArgumentString = textBoxFirstIn.Text;
            double firstArgument = Convert.ToDouble(firstArgumentString);
            string secondArgumentString = textBoxSecondIn.Text;
            double secondArgument = Convert.ToDouble(secondArgumentString);
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstArgument, secondArgument);
            textBoxOut.Text = result.ToString();
        }

        private void ln_Click(object sender, EventArgs e)
        {
            string ArgumentString = textBoxFirstIn.Text;
            double Argument = Convert.ToDouble(ArgumentString);
            ISingleArgumentCalculatorcs singlecalculator = SingleArgumentFactory.CreateSingleCalculate(((Button)sender).Name);
            double result = singlecalculator.SingleCalculate(Argument);
            textBoxOut.Text = result.ToString();
        }
    }
}
