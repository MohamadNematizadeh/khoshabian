using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red_Light
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
            RedLight.Region = new Region(new System.Drawing.Drawing2D.GraphicsPath());
            var pathRed = new System.Drawing.Drawing2D.GraphicsPath();
            pathRed.AddEllipse(0, 0, RedLight.Width, RedLight.Height);
            RedLight.Region = new Region(pathRed);

            OrangeLight.Region = new Region(new System.Drawing.Drawing2D.GraphicsPath());
            var pathOrange = new System.Drawing.Drawing2D.GraphicsPath();
            pathOrange.AddEllipse(0, 0, OrangeLight.Width, OrangeLight.Height);
            OrangeLight.Region = new Region(pathOrange);

            GreenLight.Region = new Region(new System.Drawing.Drawing2D.GraphicsPath());
            var pathGreen = new System.Drawing.Drawing2D.GraphicsPath();
            pathGreen.AddEllipse(0, 0, GreenLight.Width, GreenLight.Height);
            GreenLight.Region = new Region(pathGreen);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RedLight_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }



    }
}
