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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Violet;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox3.Location = new System.Drawing.Point(94, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "Time Left:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Violet;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(62, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Choose Your Weapon!";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(94, 230);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(101, 23);
            this.btnPlayAgain.TabIndex = 13;
            this.btnPlayAgain.Text = "Play Again!";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Violet;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Purple;
            this.textBox1.Location = new System.Drawing.Point(6, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(273, 31);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Rock Paper Scissors";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Violet;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(95, 204);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "Your Score:";
            // 
            // btnPaper
            // 
            this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaper.Image = global::Rock.Properties.Resources.Screenshot_2025_03_17_155437;
            this.btnPaper.Location = new System.Drawing.Point(111, 57);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(55, 55);
            this.btnPaper.TabIndex = 12;
            this.btnPaper.UseVisualStyleBackColor = true;
            // 
            // btnRock
            // 
            this.btnRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRock.Image = global::Rock.Properties.Resources.Screenshot_2025_03_17_154848;
            this.btnRock.Location = new System.Drawing.Point(6, 57);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(55, 55);
            this.btnRock.TabIndex = 11;
            this.btnRock.UseVisualStyleBackColor = true;
            // 
            // btnScissor
            // 
            this.btnScissor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScissor.Image = global::Rock.Properties.Resources.Screenshot_2025_03_17_174449;
            this.btnScissor.Location = new System.Drawing.Point(224, 57);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(55, 55);
            this.btnScissor.TabIndex = 10;
            this.btnScissor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
    }
}

