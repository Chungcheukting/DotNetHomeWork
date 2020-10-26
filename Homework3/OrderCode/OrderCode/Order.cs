using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCode
{
    public class Order
    {
        //订单号
        public string ID { set; get; }
        //总金额
        public double totalMoney { set; get; }
        //顾客
        public Customer customer;
        public List<OrderItem> orderItemList;

        public Order(string ID, Customer customer, List<OrderItem> orderList)
        {
            this.ID = ID;
            this.customer = customer;
            this.totalMoney = 0;
            this.orderItemList = orderList;
            foreach (OrderItem oi in orderList)
                this.totalMoney += oi.quantity * oi.unitPrice;
        }

        public void AddOrderItem(OrderItem oi)
        {
            this.orderItemList.Add(oi);
            this.totalMoney += oi.quantity * oi.unitPrice;
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            if (order == null || order.ID != this.ID)
                return false;
            else return true;
        }

        public override string ToString()
        {
            string commodityStr = "";
            foreach (OrderItem order in orderItemList)
                commodityStr += order.ToString() + "   ";
            return $"customer information:{this.customer.ToString()} \n"
                + $"commodity information:{commodityStr}\n"
                + $"total price:{this.totalMoney}\n"
                + $"date:{DateTime.Now.ToString()}\n";
        }

        public override int GetHashCode()
        {
            return 1;
        }
    }
    public class Customer
    {
        public string name { set; get; }
        public string IDNumber { set; get; }

        public Customer(string name, string IDNumber)
        {
            this.IDNumber = IDNumber;
            this.name = name;
        }

        //重写ToString()方法
        override public string ToString()
        {
            return $"name:{this.name}, IDNumber:{this.IDNumber}";
        }
    }
}
