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
            this.Car = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RedLight
            // 
            this.RedLight.BackColor = System.Drawing.Color.Red;
            this.RedLight.Enabled = false;
            this.RedLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedLight.Location = new System.Drawing.Point(296, 10);
            this.RedLight.Margin = new System.Windows.Forms.Padding(4);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(100, 78);
            this.RedLight.TabIndex = 0;
            this.RedLight.UseVisualStyleBackColor = false;
            // 
            // OrangeLight
            // 
            this.OrangeLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OrangeLight.Enabled = false;
            this.OrangeLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrangeLight.Location = new System.Drawing.Point(296, 95);
            this.OrangeLight.Margin = new System.Windows.Forms.Padding(4);
            this.OrangeLight.Name = "OrangeLight";
            this.OrangeLight.Size = new System.Drawing.Size(100, 79);
            this.OrangeLight.TabIndex = 1;
            this.OrangeLight.UseVisualStyleBackColor = false;
            // 
            // GreenLight
            // 
            this.GreenLight.BackColor = System.Drawing.Color.Lime;
            this.GreenLight.Enabled = false;
            this.GreenLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenLight.Location = new System.Drawing.Point(296, 181);
            this.GreenLight.Margin = new System.Windows.Forms.Padding(4);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(100, 78);
            this.GreenLight.TabIndex = 2;
            this.GreenLight.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(503, 110);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 49);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(503, 10);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 49);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.Color.Transparent;
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(0, -23);
            this.Car.Margin = new System.Windows.Forms.Padding(4);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(129, 64);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 7;
            this.Car.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(0, 326);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(725, 15);
            this.textBox1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Car);
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 25);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(329, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 273);
            this.panel2.TabIndex = 10;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(503, 62);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 49);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 341);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Red Light";
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
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
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStop;


    }
}

