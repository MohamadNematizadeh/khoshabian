using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace ToDoList
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnAdd.Width, btnAdd.Height);
            btnAdd.Region = new Region(path);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
