using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCode
{
    //订单
   
        //Boolean DeleteOrderItem(params OrderItem[] item)
        //{
        //    Console.WriteLine("请输入要删除的订单号：");
        //    string d = Console.ReadLine();
        //    OrderItem[] delete = new OrderItem[] 
        //    {};
        //    HashSet<OrderItem> deleteList = new HashSet<OrderItem>(d);
        //}

        //Boolean AlertOrderItem(OrderItem wrong,OrderItem right)
        //{ }
  
    //顾客

    //订单服务
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OrderService os = new OrderService();
                //添加
                os.AddOrder(new Order(
                    "001",
                    new Customer("张三", "333"),
                new List<OrderItem>() { new OrderItem("pen", 5, 5.00), new OrderItem("pencil", 2, 2.5) }
                ));
                os.AddOrder(new Order(
                    "002",
                    new Customer("李四", "444"),
                    new List<OrderItem>() { new OrderItem("book", 5, 5.00) }
                    ));


                //排序
                OrderService.Sort();


                //查询
                System.Console.WriteLine(OrderService.Find1("333"));
                System.Console.WriteLine(OrderService.Find2("pen"));
                System.Console.WriteLine(OrderService.Find3("张三"));
                System.Console.WriteLine(OrderService.Find4("002"));


                //删除
                //OrderService.DelOrder("001");
                //System.Console.WriteLine(OrderService.FindByCustomerID("333"));


                //修改//修改001号订单
                OrderService.Change("001", new Order(
                "001", new Customer("张三", "333"),
                new List<OrderItem>() { new OrderItem("pen", 5, 6.00) }
                ));
                System.Console.WriteLine(OrderService.Find4("001"));
                Console.ReadKey();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
            
        }
    }
}
