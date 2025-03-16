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
        double firstNumber;
        double secondNumber;
        bool isMultiplication = false;
        bool isSum = false;
        bool isMinus = false;
        bool isDivide = false;
        bool isTavan = false;
        bool isPercent = false;


        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (textResultShow.Text == "0" && button.Text != "-")
                textResultShow.Text = button.Text;
            else
                textResultShow.Text += button.Text;
        }
        public Form1()
        {
            InitializeComponent();
            btn0.Click += NumberButton_Click;
            btn1.Click += NumberButton_Click;
            btn2.Click += NumberButton_Click;
            btn3.Click += NumberButton_Click;
            btn4.Click += NumberButton_Click;
            btn5.Click += NumberButton_Click;
            btn6.Click += NumberButton_Click;
            btn7.Click += NumberButton_Click;
            btn8.Click += NumberButton_Click;
            btn9.Click += NumberButton_Click;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (!textResultShow.Text.Contains(".")) {
                if (textResultShow.Text == "")
                    textResultShow.Text = "0.";
                else
                    textResultShow.Text += ".";
            }
        }
        private void btnNegetive_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "")
            {
                textResultShow.Text = "-";
            }
            else if (textResultShow.Text == "-")
            {
                textResultShow.Text = "";
            }
            else
            {
                textResultShow.Text = (double.Parse(textResultShow.Text) * -1).ToString();
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "") return;
            firstNumber = double.Parse(textResultShow.Text);
            textResultShow.Text = "";
            isDivide = true;
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "") return;
            firstNumber = double.Parse(textResultShow.Text);
            textResultShow.Text = "";
            isSum = true;
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "") return;
            firstNumber = double.Parse(textResultShow.Text);
            textResultShow.Text = "";
            isMinus = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "") return;
            firstNumber = double.Parse(textResultShow.Text);
            textResultShow.Text = "";
            isTavan = true;
        }
        private void btnTan_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "") return;
            firstNumber = double.Parse(textResultShow.Text);
            if ((firstNumber % 180 == 90))
                textResultShow.Text = "Error";
            else
                textResultShow.Text = Math.Tan(firstNumber * Math.PI / 180).ToString();
        }
        private void btnFactorial_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "") return;
            firstNumber = double.Parse(textResultShow.Text);

            if (textResultShow.Text == "-") return;

            int num = int.Parse(textResultShow.Text);
            if (num < 0)
            {
                textResultShow.Text = "Error";
                return;
            }

            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            textResultShow.Text = factorial.ToString();
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "" || textResultShow.Text == "-") return;
            firstNumber = double.Parse(textResultShow.Text);
            textResultShow.Text = Math.Log10(firstNumber).ToString();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "") return;
            firstNumber = double.Parse(textResultShow.Text);
            textResultShow.Clear();
            isMultiplication = true;
        }
        private void btnSqr_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "") return;
            firstNumber = double.Parse(textResultShow.Text);
            textResultShow.Clear();
            textResultShow.Text = Math.Sqrt(firstNumber).ToString();
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "") return;
            firstNumber = double.Parse(textResultShow.Text);
            textResultShow.Clear();
            isPercent = true;
        }
        private void btnSin_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "") return;
            double num = double.Parse(textResultShow.Text);
            textResultShow.Text = Math.Sin(num * Math.PI / 180).ToString();
        }
        private void btnCos_Click(object sender, EventArgs e)
        {
            if (textResultShow.Text == "") return;
            double num = double.Parse(textResultShow.Text);
            textResultShow.Text = Math.Cos(num * Math.PI / 180).ToString();
        }
        private void btnResult_Click(object sender, EventArgs e)
        {

            secondNumber = double.Parse(textResultShow.Text);


            if (isDivide)
                textResultShow.Text = (firstNumber / secondNumber).ToString();

            if(isMinus)
                textResultShow.Text = (firstNumber - secondNumber).ToString();

            if (isMultiplication)
                textResultShow.Text = (firstNumber * secondNumber).ToString();

            if (isTavan)
                textResultShow.Text = Math.Pow(firstNumber, secondNumber).ToString();
            if(isPercent)
                textResultShow.Text = ((firstNumber * secondNumber) / 100).ToString();

            else if (isSum)
                textResultShow.Text = (firstNumber + secondNumber).ToString();

            isMultiplication = false;
            isSum = false;
            isMinus = false;
            isDivide = false;
            isTavan = false;
            isPercent = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textResultShow.Clear();
        }







    }
}
