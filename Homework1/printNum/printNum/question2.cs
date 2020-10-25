using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    public class problem2
    {
        public void second()
        {
            int[] getNum = new int[5];
            Console.WriteLine("请输入五个整数：");
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    String str = Console.ReadLine();
                    getNum[i] = int.Parse(str);
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                }
            }
            int max = getNum[0];
            int min = getNum[0];
            int add = 0;
            double average = 0;
            for(int i=0;i<5;i++)
            {
                if (getNum[i] > max)
                    max = getNum[i];
                if (getNum[i] < min)
                    min = getNum[i];
                add += getNum[i];
            }
            average = add / 5;
            Console.WriteLine("最小值为：" + min);
            Console.WriteLine("最大值为：" + max);
            Console.WriteLine("平均值为：" + average);
        }
    }
}