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
    public partial class level : Form
    {
        public level()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            game game_form = new game();
            game_form.Show();
            this.Hide();
        }
    }
}
