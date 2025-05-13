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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // مقدار اولیه ComboBoxها

    cmbUnitSelection.Items.AddRange(new string[] { "دما", "طول", "وزن" });
    cmbUnitSelection.SelectedIndex = -1; // هیچ کمیتی پیش‌فرض انتخاب نشده


        }

       

       
        private void button1_Click_1(object sender, EventArgs e)
        {
             try
            {
                double value = double.Parse(comboBox1.Text);
                string from = comboBox2.Text;
                string to = comboBox3.Text;

                if (from == to)
                {
                    MessageBox.Show("واحدهای تبدیل مشابه هستند.");
                    return;
                }

                double result = 0;

                // دما
                if (cmbUnitSelection.Text == "دما")
                {
                    if (from == "سلسیوس" && to == "فارنهایت")
                        result = (value * 9 / 5) + 32;
                    else if (from == "فارنهایت" && to == "سلسیوس")
                        result = (value - 32) * 5 / 9;
                }

                // طول
                else if (cmbUnitSelection.Text == "طول")
                {
                    if (from == "متر" && to == "سانتی‌متر") result = value * 100;
                    else if (from == "سانتی‌متر" && to == "متر") result = value / 100;
                    else if (from == "متر" && to == "اینچ") result = value * 39.37;
                    else if (from == "اینچ" && to == "متر") result = value / 39.37;
                    else if (from == "سانتی‌متر" && to == "اینچ") result = value / 2.54;
                    else if (from == "اینچ" && to == "سانتی‌متر") result = value * 2.54;
                }

                // وزن
                else if (cmbUnitSelection.Text == "وزن")
                {
                    if (from == "کیلوگرم" && to == "پوند") result = value * 2.20462;
                    else if (from == "پوند" && to == "کیلوگرم") result = value / 2.20462;
                }

                MessageBox.Show(string.Format("نتیجه: {0:F2}", result), "تبدیل موفق");
                Clipboard.SetText(result.ToString("F2")); // کپی به کلیپ‌بورد
            }
            catch (FormatException)
            {
                MessageBox.Show("مقدار عددی وارد کنید.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا: " + ex.Message);
            }
        }

        private void cmbUnitSelection_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            if (cmbUnitSelection.SelectedItem.ToString() == "دما")
            {
                comboBox2.Items.AddRange(new string[] { "سلسیوس", "فارنهایت" });
                comboBox3.Items.AddRange(new string[] { "سلسیوس", "فارنهایت" });
            }
            else if (cmbUnitSelection.SelectedItem.ToString() == "طول")
            {
                comboBox2.Items.AddRange(new string[] { "متر", "سانتی‌متر", "اینچ" });
                comboBox3.Items.AddRange(new string[] { "متر", "سانتی‌متر", "اینچ" });
            }
            else if (cmbUnitSelection.SelectedItem.ToString() == "وزن")
            {
                comboBox2.Items.AddRange(new string[] { "کیلوگرم", "پوند" });
                comboBox3.Items.AddRange(new string[] { "کیلوگرم", "پوند" });
            }

            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

        }


        
    }
}


