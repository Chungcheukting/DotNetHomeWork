using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eratosthenes;
using calculate;

namespace printNum
{
    class Question1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("第一个问题：输出指定数据的所有素数因子");
            int num = getNum();
            getResult(num);

            Console.WriteLine("第二个问题：求一个整数数组的最大值、最小值和平均值");
            problem2 p2 = new problem2();
            p2.second();

            Console.WriteLine("第三个问题：用埃氏筛法找出2~100以内的素数");
            problem3 p3 = new problem3();
            p3.third();
            Console.ReadKey();
        }
        public static int getNum()
        {
            int num = 0;
            try
            {
                Console.WriteLine("请输入一个整数：");
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入整数格式错误！请重新输入");
            }

            return num;
        }
        public static void getResult(int num)
        {
            Console.WriteLine("该数的素数因子包括：");
            if (num == 0)
                Console.WriteLine("0没有素数因子！");
            for(int i=2;i<=num;i++)
            {
                if(num % i==0)
                {
                    Console.WriteLine(i + "");
                    do
                    {
                        num /= i;
                    } while (num % i == 0);
                }
            }
        }
    }
}
