using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms;

namespace MainHall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
           try
            {
                string calculatorPath = @"D:\Programmer\C# Course\khoshabian\MainHall\MainHall\Resources\Calculator.exe";

                Process.Start(calculatorPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا : " + ex.Message);
            }
        
        }

        private void btnRedLight_Click(object sender, EventArgs e)
        {
            try
            {
                string calculatorPath = @"D:\Programmer\C# Course\khoshabian\MainHall\MainHall\Resources\Red Light.exe";

                Process.Start(calculatorPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا : " + ex.Message);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                string calculatorPath = @"D:\Programmer\C# Course\khoshabian\MainHall\MainHall\Resources\ToDoList.exe";

                Process.Start(calculatorPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا : " + ex.Message);
            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            try
            {
                string calculatorPath = @"D:\Programmer\C# Course\khoshabian\MainHall\MainHall\Resources\Rock.exe";

                Process.Start(calculatorPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا : " + ex.Message);
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            try
            {
                string calculatorPath = @"D:\Programmer\C# Course\khoshabian\MainHall\MainHall\Resources\Guess the Number.exe";

                Process.Start(calculatorPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا : " + ex.Message);
            }
        }


    }
}
