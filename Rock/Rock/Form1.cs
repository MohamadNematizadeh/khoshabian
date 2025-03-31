using System;
using System.Windows.Forms;
using System.Drawing;

namespace Rock
{
    public partial class Form1 : Form
    {
        private int userScore = 0;
        private int computerScore = 0;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            userScore = 0;
            computerScore = 0;
            player.Image = null;  
            Computer.Image = null;  
            UpdateScore();
           
        }

        private void PlayGame(string userChoice)
        {
            string[] choices = { "rock", "paper", "scissors" };
            string computerChoice = choices[random.Next(choices.Length)];

            player.Image = Image.FromFile(@"D:\Programmer\C# Course\khoshabian\Rock\Rock\image\" + userChoice.ToLower() + ".png");
            Computer.Image = Image.FromFile(@"D:\Programmer\C# Course\khoshabian\Rock\Rock\image\" + computerChoice.ToLower() + ".png");


            if (userChoice == computerChoice)
            {
                MessageBox.Show("🤝 مساوی!");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "paper" && computerChoice == "rock") ||
                     (userChoice == "scissors" && computerChoice == "paper"))
            {
                MessageBox.Show("🎉 شما بردید!");
                userScore++;
            }
            else
            {
                MessageBox.Show("💻 کامپیوتر برد!");
                computerScore++;
            }

            UpdateScore();
        }

        private void UpdateScore()
        {
            player_scor.Text = string.Format("امتیاز شما: {0}", userScore);
            computer_scor.Text = string.Format("امتیاز کامپیوتر: {0}", computerScore);
        }

        private void rock_Click_1(object sender, EventArgs e)
        {
            PlayGame("rock");
        }

        private void paper_Click(object sender, EventArgs e)
        {
            PlayGame("paper");
        }

        private void scissors_Click(object sender, EventArgs e)
        {
            PlayGame("scissors");
        }
    }
}
