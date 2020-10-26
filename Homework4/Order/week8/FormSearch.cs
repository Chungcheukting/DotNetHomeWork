using OrderCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week8
{
    public partial class FormSearch : Form
    {
        public string keys;

        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            keys = textBoxSearchKey.Text;

            try
            {
                switch (tabControlShow.SelectedIndex)
                {
                    case 0:
                        label1.Text = OrderService.Find1(keys);
                        return;
                    case 1:
                        label2.Text = OrderService.Find2(keys);
                        return;
                    case 2:
                        label3.Text = OrderService.Find3(keys);
                        return;
                    case 3:
                        label4.Text = OrderService.Find4(keys);
                        return;
                }
            }
            catch (Exception excption)
            {
                label1.Text = label2.Text = label3.Text = label4.Text = "没有找到对应的订单";
            }
        }

        private void tabControlShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (tabControlShow.SelectedIndex)
                {
                    case 0:
                        label1.Text = OrderService.Find1(keys);
                        return;
                    case 1:
                        label2.Text = OrderService.Find2(keys);
                        return;
                    case 2:
                        label3.Text = OrderService.Find3(keys);
                        return;
                    case 3:
                        label4.Text = OrderService.Find4(keys);
                        return;
                }
            }
            catch (Exception excption)
            {
                label1.Text = label2.Text = label3.Text = label4.Text = "没有找到对应的订单";
            }
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
