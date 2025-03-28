namespace Red_Light
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RedLight = new System.Windows.Forms.Button();
            this.OrangeLight = new System.Windows.Forms.Button();
            this.GreenLight = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RedLight
            // 
            this.RedLight.BackColor = System.Drawing.Color.Red;
            this.RedLight.Enabled = false;
            this.RedLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedLight.Location = new System.Drawing.Point(222, 8);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(75, 63);
            this.RedLight.TabIndex = 0;
            this.RedLight.UseVisualStyleBackColor = false;
            this.RedLight.Click += new System.EventHandler(this.RedLight_Click);
            // 
            // OrangeLight
            // 
            this.OrangeLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OrangeLight.Enabled = false;
            this.OrangeLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrangeLight.Location = new System.Drawing.Point(222, 77);
            this.OrangeLight.Name = "OrangeLight";
            this.OrangeLight.Size = new System.Drawing.Size(75, 64);
            this.OrangeLight.TabIndex = 1;
            this.OrangeLight.UseVisualStyleBackColor = false;
            // 
            // GreenLight
            // 
            this.GreenLight.BackColor = System.Drawing.Color.Lime;
            this.GreenLight.Enabled = false;
            this.GreenLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenLight.Location = new System.Drawing.Point(222, 147);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(75, 63);
            this.GreenLight.TabIndex = 2;
            this.GreenLight.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(377, 89);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(377, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 40);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(0, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(544, 13);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 20);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(247, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 222);
            this.panel2.TabIndex = 10;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(377, 50);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 40);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 277);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.OrangeLight);
            this.Controls.Add(this.RedLight);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Red Light";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RedLight;
        private System.Windows.Forms.Button OrangeLight;
        private System.Windows.Forms.Button GreenLight;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStop;


    }
}

