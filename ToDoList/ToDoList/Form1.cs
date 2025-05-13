using System;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            StyleAddButton();
        }


        private void StyleAddButton()
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnAdd.Width, btnAdd.Height);
            btnAdd.Region = new Region(path);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateAddTaskForm();
        }

        private void CreateAddTaskForm()
        {
            Form addTaskForm = new Form
            {
                Text = "افزودن تسک جدید",
                Size = new Size(300, 250),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent
            };

            Label lblTitle = new Label { Text = "نام تسک:", Left = 10, Top = 20 };
            TextBox txtTitle = new TextBox { Left = 10, Top = 40, Width = 250 };

            Label lblDesc = new Label { Text = "توضیحات:", Left = 10, Top = 80 };
            TextBox txtDesc = new TextBox { Left = 10, Top = 100, Width = 250, Height = 60, Multiline = true };

            Button btnSubmit = new Button { Text = "افزودن", Left = 100, Top = 170, Width = 80 };
            btnSubmit.Click += (s, ev) =>
            {
                if (!string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    AddTask(txtTitle.Text, txtDesc.Text);
                    addTaskForm.Close();
                }
                else
                {
                    MessageBox.Show("نام تسک را وارد کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            addTaskForm.Controls.Add(lblTitle);
            addTaskForm.Controls.Add(txtTitle);
            addTaskForm.Controls.Add(lblDesc);
            addTaskForm.Controls.Add(txtDesc);
            addTaskForm.Controls.Add(btnSubmit);
            addTaskForm.ShowDialog();
        }

        private void AddTask(string title, string description)
        {
            Panel taskPanel = CreateTaskPanel(title, description);
            taskContainer.Controls.Add(taskPanel);
            taskContainer.ScrollControlIntoView(taskPanel);
        }

        private Panel CreateTaskPanel(string title, string description)
        {
            Panel taskPanel = new Panel
            {
                Width = taskContainer.Width - 20,
                Height = 60,
                Padding = new Padding(5),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            CheckBox chkComplete = new CheckBox { Left = 5, Top = 20, Width = 20 };
            Label lblTask = new Label { Text = title, Left = 30, Top = 10, Width = 200, Font = new Font("Tahoma", 10, FontStyle.Regular) };
            Label lblDesc = new Label { Text = description, Left = 30, Top = 30, Width = 200, Font = new Font("Tahoma", 8, FontStyle.Italic), ForeColor = Color.Gray };

            chkComplete.CheckedChanged += (s, e) =>
            {
                if (chkComplete.Checked)
                {
                    lblTask.Font = new Font(lblTask.Font, FontStyle.Strikeout);
                    lblTask.ForeColor = Color.Gray;
                    taskPanel.BackColor = Color.LightGray;
                }
                else
                {
                    lblTask.Font = new Font(lblTask.Font, FontStyle.Regular);
                    lblTask.ForeColor = Color.Black;
                    taskPanel.BackColor = Color.White;
                }
            };

            taskPanel.Controls.Add(chkComplete);
            taskPanel.Controls.Add(lblTask);
            taskPanel.Controls.Add(lblDesc);
            return taskPanel;
        }

        private void Form1_Load(object sender, EventArgs e) { }
    }
}
