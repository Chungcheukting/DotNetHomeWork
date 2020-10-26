using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCode
{
    //订单明细项
    public class OrderItem
    {
        public string name;         //商品名称
        public double unitPrice;    //单价
        public int quantity;       //数量
        public string Name { get; set; }

        public OrderItem(string name, int quantity, double unitPrice)
        {
            this.Name = name;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (value > 0)
                    unitPrice = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                    quantity = value;
            }
        }
        override public string ToString()
        {
            return $"{this.name.ToString()} × {this.quantity}";
        }

        //重写Equals()方法
        public override bool Equals(object obj)
        {
            OrderItem oi = obj as OrderItem;
            if (oi == null || oi.name == this.name || oi.quantity == this.quantity)
                return false;
            else return true;
        }
        public override int GetHashCode()
        {
            return 1;
        }
        
    }
    public class Commodity
    {
        public string name { set; get; }   //商品名称
        public double price { set; get; }  //单价

        //构造方法
        public Commodity(string orderName, double price)
        {
            this.name = orderName;
            this.price = price;
        }

        //重写ToString()方法
        override public string ToString()
        {
            return $"name:{this.name}, price:{this.price}元/件";
        }
    }
}
