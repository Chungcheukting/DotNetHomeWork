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
    public partial class ItemForm : Form
    {
        public OrderItem oi=new OrderItem();
        public DetailForm forForm;//上一级界面
        public int kind;//取值为0或1，0表示当前正在添加，1表示当前正在修改

        public ItemForm()
        {
            InitializeComponent();
        }

        public ItemForm(OrderItem orderItem)
        {
            this.oi = orderItem;
            InitializeComponent();

            textBoxCN.DataBindings.Add("Text",this.oi.cname,"name");
            textBoxCP.DataBindings.Add("Text", this.oi.unitPrice, "unitPrice");
            textBoxCC.DataBindings.Add("Text", this.oi.quantity, "quantity");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnsure_Click(object sender, EventArgs e)
        {
            if (this.kind == 0)//当前正在新建
            {
                this.oi = null;
                this.oi = new OrderItem(textBoxCN.Text, double.Parse(textBoxCP.Text), int.Parse(textBoxCC.Text));
            }
            else//当前正在修改
            {
                this.oi.cname = textBoxCN.Text;
                this.oi.unitPrice = double.Parse(textBoxCP.Text);
                this.oi.quantity = int.Parse(textBoxCC.Text);
            }
            this.Close();
            new FormChangeSuccess().ShowDialog();
            
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
