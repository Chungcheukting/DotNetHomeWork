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
    public partial class DetailForm : Form
    {
        public Order order;//解析当前的文本框并生成一个Order对象
        public OrderItem currenOI = new OrderItem();

        public Form1 forForm;//上一级界面

        //public DetailForm(OrderCode.Order currentOrder)
        //{
        //    InitializeComponent();
        //    order = new Order();

        //    orderIDTextBox.DataBindings.Add("Text", this.order, "orderNumber");
        //    totalMoneyTextBox.DataBindings.Add("Text", this.order, "totalMoney");
        //    timeTextBox.DataBindings.Add("Text", this.order.date, "Date");
        //    addressTextBox.DataBindings.Add("Text", this.order, "address");
        //    customerIDTextBox.DataBindings.Add("Text", this.order.customer, "IDNumber");
        //    customerNameTextBox.DataBindings.Add("Text", this.order.customer, "name");

        //    bindingSourceOIL.DataSource = order.orderItemList;
        //}

        public DetailForm(Order o)
        {
            InitializeComponent();

            this.order = o;

            orderIDTextBox.DataBindings.Add("Text", this.order, "ID");
            totalMoneyTextBox.DataBindings.Add("Text", this.order, "totalMoney");
            timeTextBox.DataBindings.Add("Text", this.order.Time, "Date");
            customerIDTextBox.DataBindings.Add("Text", this.order.customer, "IDNumber");
            customerNameTextBox.DataBindings.Add("Text", this.order.customer, "name");

            bindingSourceOIL.DataSource = order.orderItemList;
        }

        private void buttonEnsure_Click(object sender, EventArgs e)
        {
            order.ID = orderIDTextBox.Text;
            order.customer.name = customerNameTextBox.Text;
            order.customer.IDNumber = customerIDTextBox.Text;
            order.Time = DateTime.Now;
            order.totalMoney = 0;
            foreach (OrderItem oi in this.order.orderItemList)
                this.order.totalMoney += oi.unitPrice * oi.quantity;
            OrderService.AddOrder(order);
            //bindingSourceOIL.ResetBindings(false);
            this.Close();
        }

        private void addOrderItemButton_Click(object sender, EventArgs e)//新建
        {
            ItemForm form3 = new ItemForm();
            form3.kind = 0;
            form3.forForm = this;
            form3.ShowDialog();
            this.order.orderItemList.Add(form3.oi);

            bindingSourceOIL.ResetBindings(false);
            //new FormAddSuccess().ShowDialog();
            
        }

        private void listBoxOI_DoubleClick(object sender, EventArgs e)//双击以修改
        {
            currenOI = (OrderItem)listBoxOI.SelectedItem;
            ItemForm form3 = new ItemForm(currenOI);
            form3.kind = 1;
            form3.forForm = this;
            form3.ShowDialog();

            bindingSourceOIL.ResetBindings(false);


        }

        private void listBoxOI_SelectedIndexChanged(object sender, EventArgs e)
        {
            currenOI = (OrderItem)listBoxOI.SelectedItem;
        }



        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (this.order.orderItemList.Count == 1)
                this.order.orderItemList.Clear();
            else
                this.order.orderItemList.Remove(currenOI);
            bindingSourceOIL.ResetBindings(false);

            new FormDelScuccess().ShowDialog();
            this.Close();
        }

        private void DetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //更新总金额
            this.order.totalMoney = 0;
            if (this.order.orderItemList.Count != 0)
                foreach (OrderItem oi in this.order.orderItemList)
                    this.order.totalMoney += oi.unitPrice * oi.quantity;
            bindingSourceOIL.ResetBindings(false);
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
