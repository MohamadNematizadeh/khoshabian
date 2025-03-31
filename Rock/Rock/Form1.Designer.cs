namespace Rock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.scissors = new System.Windows.Forms.Button();
            this.rock = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.Button();
            this.Computer = new System.Windows.Forms.Button();
            this.computer_scor = new System.Windows.Forms.Label();
            this.player_scor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.White;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPlayAgain.Location = new System.Drawing.Point(24, 443);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(254, 38);
            this.btnPlayAgain.TabIndex = 13;
            this.btnPlayAgain.Text = "Play Again!";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // paper
            // 
            this.paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paper.Image = global::Rock.Properties.Resources.paper;
            this.paper.Location = new System.Drawing.Point(115, 366);
            this.paper.Margin = new System.Windows.Forms.Padding(4);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(73, 68);
            this.paper.TabIndex = 12;
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // scissors
            // 
            this.scissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scissors.Image = global::Rock.Properties.Resources.scissors;
            this.scissors.Location = new System.Drawing.Point(24, 366);
            this.scissors.Margin = new System.Windows.Forms.Padding(4);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(73, 68);
            this.scissors.TabIndex = 11;
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // rock
            // 
            this.rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rock.Image = global::Rock.Properties.Resources.rock;
            this.rock.Location = new System.Drawing.Point(205, 366);
            this.rock.Margin = new System.Windows.Forms.Padding(4);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(73, 68);
            this.rock.TabIndex = 10;
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click_1);
            // 
            // player
            // 
            this.player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player.Location = new System.Drawing.Point(82, 182);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(122, 122);
            this.player.TabIndex = 17;
            this.player.UseVisualStyleBackColor = true;
            // 
            // Computer
            // 
            this.Computer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Computer.Location = new System.Drawing.Point(82, 52);
            this.Computer.Margin = new System.Windows.Forms.Padding(4);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(122, 122);
            this.Computer.TabIndex = 18;
            this.Computer.UseVisualStyleBackColor = true;
            // 
            // computer_scor
            // 
            this.computer_scor.AutoSize = true;
            this.computer_scor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.computer_scor.ForeColor = System.Drawing.Color.White;
            this.computer_scor.Location = new System.Drawing.Point(70, 9);
            this.computer_scor.Name = "computer_scor";
            this.computer_scor.Size = new System.Drawing.Size(147, 32);
            this.computer_scor.TabIndex = 19;
            this.computer_scor.Text = "Computer";
            // 
            // player_scor
            // 
            this.player_scor.AutoSize = true;
            this.player_scor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.player_scor.ForeColor = System.Drawing.Color.White;
            this.player_scor.Location = new System.Drawing.Point(85, 318);
            this.player_scor.Name = "player_scor";
            this.player_scor.Size = new System.Drawing.Size(102, 32);
            this.player_scor.TabIndex = 20;
            this.player_scor.Text = "Player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(300, 494);
            this.Controls.Add(this.player_scor);
            this.Controls.Add(this.computer_scor);
            this.Controls.Add(this.Computer);
            this.Controls.Add(this.player);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.rock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button player;
        private System.Windows.Forms.Button Computer;
        private System.Windows.Forms.Label computer_scor;
        private System.Windows.Forms.Label player_scor;
    }
}

