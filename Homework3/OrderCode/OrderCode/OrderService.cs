using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCode
{
    public class OrderService
    {
        public List<Order> orderList = new List<Order>();

        public void AddOrder(Order o)
        {
            foreach (Order od in orderList)            //判断是否重复
                if (od.Equals(o))
                    throw new Exception("该订单不存在！");
            orderList.Add(o);
        }

        //（按照订单号）查询订单
        public static string Find1(string ID)
        {
            OrderService os = new OrderService();
            var o = from order in os.orderList where order.ID == ID select order;
            Order od = o.First();
            if (od!=null)
                return od.ToString();
            else
                throw new Exception("该订单不存在！");
        }

        //（按商品名称）查询订单
        public static string Find2(string Name)
        {
            OrderService os = new OrderService();
            string info= "";
            foreach (Order order in os.orderList)
            {
                var o = from ord in order.orderItemList where ord.name == Name select order;
                Order od = o.FirstOrDefault();
                if (od != null)
                    info += od.ToString();
            }
            if (info == "")
                throw new Exception("该订单不存在！");
            return info;
        }

        //(按客户)查询订单
        public static string Find3(string customerName)
        {
            OrderService os = new OrderService();
            var o = from order in os.orderList where order.customer.name == customerName select order;
            Order od = o.First();
            if (od != null)
                return od.ToString();
            else
                throw new Exception("该订单不存在!");
        }
        public static string Find4(string customerID)
        {
            OrderService os = new OrderService();
            var o = from order in os.orderList where order.customer.IDNumber == customerID select order;
            Order od = o.First();
            if (od != null)
                return od.ToString();
            else
                throw new Exception("该订单不存在！");
        }
        //（根据订单号）删除订单
        public static void DelOrder(string ID)
        {
            Order del = null;
            OrderService os = new OrderService();
            foreach (Order od in os.orderList)//查找该订单
                if (od.ID == ID)
                    del = od;
            if (del != null)
                os.orderList.Remove(del);
        }

        //（根据订单号）修改订单
        public static void Change(string ID, Order newOrder)
        {
            OrderService os = new OrderService();
            var o = from order in os.orderList where order.ID == ID select order;
            Order od = o.First();
            os.orderList.Remove(od);
            os.orderList.Add(newOrder);
        }


        //(照订单号)排序
        public static void Sort()
        {
            OrderService os = new OrderService();
            var orders = from order in os.orderList orderby order.ID select order;
            os.orderList = orders.ToList();
        }
    }
}
