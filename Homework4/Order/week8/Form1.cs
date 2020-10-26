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
    public partial class Form1 : Form
    {
        public Order currentOrder;//当前正在操作的Order对象

        public Form1()
        {
            InitializeComponent();

            //绑定orderList
            orderBindingSource.DataSource = OrderService.orderList;

            //在OrderListBox中显示订单号
            OrdersListBox.DisplayMember = "订单号";
            

        }
        private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderService.orderList.Count == 0)
            {
                OrderInfoLable.Text = "empty";
                return;
            }
            currentOrder=(Order)OrdersListBox.SelectedItem;
            OrderInfoLable.Text = currentOrder.ToString();
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            DetailForm form2 = new DetailForm(currentOrder);
            form2.forForm = this;
            form2.ShowDialog();
            orderBindingSource.ResetBindings(false);
        }

        private void ChangeOrder_Click(object sender, EventArgs e)
        {
            DetailForm form2 = new DetailForm(currentOrder);
            form2.forForm = this;
            form2.ShowDialog();
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            OrderService.DelOrder(currentOrder.ID);
            orderBindingSource.ResetBindings(false);//这里巨坑！

            new FormDelScuccess().ShowDialog();
        }

        private void SearchOrder_Click(object sender, EventArgs e)
        {
            new FormSearch().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
