using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Margin = new Padding(0);
            panel1.Padding = new Padding(0);
            cmbUnitSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnitSelection.FlatStyle = FlatStyle.Flat;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUnitSelection.DrawMode = DrawMode.OwnerDrawFixed;
            cmbUnitSelection.BackColor = Color.LightSkyBlue;
            cmbUnit1.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbUnit1.FlatStyle = FlatStyle.Flat;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbUnit2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUnitSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
