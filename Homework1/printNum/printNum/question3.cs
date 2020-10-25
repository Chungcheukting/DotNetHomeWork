using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eratosthenes
{
     public class problem3
    {
        public void third()
        {
            int [] confirm = new int[101];           //创立一个数组表示一个数是否为素数
            confirm[0] = confirm[1] = 0;          //0和1既不是素数也不是合数
            confirm[2] = 1;                        //2为素数
            int m = 2, n = 0;
            for (int i = 3; i < confirm.Length; i++)
                confirm[i] = 1;
            while(n<101)
            { 
                for (int i = 3; i < confirm.Length; i++)
                {
                    if (i % m == 0 && i != m)
                        confirm[i] = 0;          //不为素数置为0
                    else
                        confirm[i] = confirm[i]*1;
                }
                for (int i = m; i < confirm.Length; i++)
                {
                    if (i>m&&confirm[i]==1)             //将筛选后第一个数作为筛子
                    {
                        m = i;break;
                    }
                }
                n++;
            }
            Console.WriteLine("2-100内的素数为：");
            for (int i = 1; i < confirm.Length; i++)
            {
                if (confirm[i] == 1)
                    Console.Write(i + "  ");
            }
        }
    }
}