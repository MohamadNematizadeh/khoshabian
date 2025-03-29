using System;
using System.Drawing;
using System.Windows.Forms;

namespace Red_Light
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Timer carTimer;
        private int lightIndex = 0;
        private bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
            InitializeTrafficLights();
            InitializeTimer();
            InitializeCarMovement();
        }

        private void InitializeTrafficLights()
        {
            RedLight.BackColor = Color.Red;
            OrangeLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 2000; 
            timer.Tick += Timer_Tick;
        }

        private void InitializeCarMovement()
        {
            carTimer = new Timer();
            carTimer.Interval = 100;
            carTimer.Tick += CarTimer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            switch (lightIndex)
            {
                case 0: 
                    RedLight.BackColor = Color.Gray;
                    OrangeLight.BackColor = Color.Orange;
                    GreenLight.BackColor = Color.Gray;
                    break;
                case 1: 
                    RedLight.BackColor = Color.Gray;
                    OrangeLight.BackColor = Color.Gray;
                    GreenLight.BackColor = Color.Green;
                    break;
                case 2: 
                    RedLight.BackColor = Color.Red;
                    OrangeLight.BackColor = Color.Gray;
                    GreenLight.BackColor = Color.Gray;
                    break;
            }
            lightIndex = (lightIndex + 1) % 3;

            if (GreenLight.BackColor == Color.Green)
            {
                carTimer.Start();
            }
            else
            {
                carTimer.Stop();
            }
        }

        private void CarTimer_Tick(object sender, EventArgs e)
        {
            if (Car.Left < this.Width - Car.Width)
            {
                Car.Left += 5; 
            }
            else
            {
                Car.Left = 0; 
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                timer.Start();
                isRunning = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            carTimer.Stop();
            isRunning = false;
        }
       

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
