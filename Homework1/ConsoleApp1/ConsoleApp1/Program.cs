using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            try
            {
                Console.WriteLine("请输入第一个整数");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("请输入第二个整数");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("输入格式错误！");
                
            }
            catch(OverflowException)
            {
                Console.WriteLine("整数溢出！");
            }

                Console.WriteLine("请输入运算符：+-*/");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"结果为: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"结果为: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"结果为: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    if (num2 == 0)
                        Console.WriteLine($"被除数不能为0");
                    else 
                    Console.WriteLine($"结果为: {num1} / {num2} = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("输入格式有问题！");
                    break;
            }
            Console.Write("按任意键关闭程序...");
            Console.ReadKey();
        }
    }
}
