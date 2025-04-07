using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUnit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnWeight.Region = new Region(new System.Drawing.Drawing2D.GraphicsPath());
            var pathRed = new System.Drawing.Drawing2D.GraphicsPath();
            pathRed.AddEllipse(0, 0, btnWeight.Width, btnWeight.Height);
            btnWeight.Region = new Region(pathRed);

            panel1.Region = new Region(new System.Drawing.Drawing2D.GraphicsPath());
            var pathRed2 = new System.Drawing.Drawing2D.GraphicsPath();
            pathRed2.AddEllipse(0, 0, panel1.Width, panel1.Height);
            panel1.Region = new Region(pathRed2);

            
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
