using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string str01 = num1.Text.Trim();
            string str02 = num2.Text.Trim();
            try
            {
                int num01 = Convert.ToInt32(str01);
                int num02 = Convert.ToInt32(str02);

                switch (comboBox.Text)
                {
                    case "+":
                        result.Text = ((num01 + num02).ToString()); break;
                    case "-":
                        result.Text = ((num01 - num02).ToString()); break;
                    case "*":
                        result.Text = ((num01 * num02).ToString()); break;
                    case "/":
                        result.Text = ((num01 / num02).ToString()); break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("没有输入有效的数字", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.num1.Text = string.Empty;
                this.num2.Text = string.Empty;
                this.num1.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("输入的数字溢出", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.num1.Text = string.Empty;
                this.num1.Focus();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.num1.Text = string.Empty;
            this.num2.Text = string.Empty;
            this.result.Text = string.Empty; 
            this.num1.Focus();
        }

    }
}
