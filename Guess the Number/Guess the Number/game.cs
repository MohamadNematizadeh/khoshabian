using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_the_Number
{
    public partial class game : Form
    {
        public game()
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

        int computerrandom = 0;
        int score = 5;  
        int attempts = 0; 

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (text_label.Text == "0" && button.Text != "-")
                text_label.Text = button.Text;
            else
                text_label.Text += button.Text;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (computerrandom == 0)
            {
                MessageBox.Show("please click on start button");
                return;
            }
            int userNumber = 0;
            if (int.TryParse(text_label.Text, out userNumber) == false)
            {
                MessageBox.Show("input was incorrect");
                return;
            }
            attempts++; 

            if (userNumber > computerrandom)
            {
                help_label.Text = "<";
                text_label.Text = "";
                score--; 
            }
            else if (userNumber < computerrandom)
            {
                help_label.Text = ">";
                text_label.Text = "";
                score--;  
            }
            else
            {
                MessageBox.Show(string.Format("🎉 تبریک! شما برنده شدید 🎉\n🔢 تعداد حدس‌های شما: {0}\n🏆 امتیاز شما به ۵ بازگردانده شد.", attempts));
                btnStart.Enabled = true;
                computerrandom = 0;
                text_label.Text = "";
                help_label.Text = "";
                score = 5; 
                attempts = 0; 
            }

            UpdateScoreLabel();

            if (score == 0)
            {
                MessageBox.Show("متأسفم! امتیاز شما تمام شد. بازی را از ابتدا شروع کنید.");
                btnStart.Enabled = true;
                computerrandom = 0;
                score = 5;
                attempts = 0;

                UpdateScoreLabel();
            }
        }
   

       

        private void button1_Click(object sender, EventArgs e)
        {
            Random rendom = new Random();
            computerrandom = rendom.Next(1, 100);
            MessageBox.Show("Start new game");
            attempts = 0; 
            btnStart.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if (score > 0)
            {
                score--; 
                int lowerBound = computerrandom - 5;
                int upperBound = computerrandom + 5;

                lowerBound = Math.Max(1, lowerBound);
                upperBound = Math.Min(100, upperBound);

                MessageBox.Show(string.Format("راهنمایی: عدد بین {0} و {1} است.", lowerBound, upperBound));
                UpdateScoreLabel();
            }
            else
            {
                MessageBox.Show("امتیاز کافی ندارید!");
            }

        }
        private void UpdateScoreLabel()
        {
            score_label.Text = "امتیاز:" + score.ToString();
        }

    
    }
}
