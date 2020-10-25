using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form
{
    interface Length
    {
        int getLength();
    }
    interface Width
    {
        int getWidth();
    }
    interface Height
    {
        int getHeight();
    }
    abstract class Action
    {
        abstract public void getArea();
        abstract public bool Judge(int a,int b, int c);
    }
//长方形
    class Rectangle : Action, Length, Width
    {
        private int setLength()
        {
            Console.WriteLine("请输入长方形的长：");
            int length = Convert.ToInt32(Console.ReadLine());
            return length;
        }
        public int getLength()
        {
            int l0 = setLength();
            return l0;
        }
        private int setWidth()
        {
            Console.WriteLine("请输入长方形的宽：");
            int width = Convert.ToInt32(Console.ReadLine());
            return width;
        }
        public int getWidth()
        {
            int w0 = setWidth();
            return w0;
        }
        public  override bool Judge(int l,int w,int t)
        {
            if (l != 0 && w != 0)
                return true;
            else
                return false;
        }
        public override void getArea()
        {
            int length = getLength();
            int width = getWidth();
            bool r = Judge(length,width,0);
            if (r)
            {

                int Rarea = length * width;
                Console.WriteLine("长方形的面积为：" + Rarea);
            }
            else
                Console.WriteLine("输入不合法！请重新输入");
        }

    }
//三角形
    class Triangle : Action, Width, Height
    {
        public override bool Judge(int s1,int s2,int s3)
        {
            bool result = true;
            if (s1 == 0 | s2 == 0 || s3 == 0)
                result = false;
            else if (s1 + s2 <= s3 || s1 + s3 <= s2 || s2 + s3 <= s1)
                result = false;
            return result;
        }
        private int setWidth()
        {
            Console.WriteLine("请输入三角形的底长：");
            int width = Convert.ToInt32(Console.ReadLine());
            return width;
        }
        public int getWidth()
        {
            int w0 = setWidth();
            return w0;
        }
        private int setHeight()
        {
            Console.WriteLine("请输入三角形的高：");
            int height = Convert.ToInt32(Console.ReadLine());
            return height;
        }
        public int getHeight()
        {
            int h0 = setHeight();
            return h0;
    }
        public override void getArea()
        {
            Console.WriteLine("请输入三角形的三边：");
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int s3 = Convert.ToInt32(Console.ReadLine());
            bool r = Judge(s1,s2,s3);
            if (r)
            {
                int Twidth = getWidth();
                int Theight = getHeight();
                double Tarea = 0.5 * Theight * Twidth;
                Console.WriteLine("三角形的面积为：" + Tarea);
            }
            else
            {
                Console.WriteLine("该图形不是一个三角形！");
            }
        }

    }
    //正方形
    class Square : Rectangle             
    {
        Rectangle rec0 = new Rectangle();
        private int setLength()
        {
            Console.WriteLine("请输入正方形的边长：");
            int length = Convert.ToInt32(Console.ReadLine());
            return length;
        }
        public int getLength()
        {
            int l0 = setLength();
            return l0;
        }
        public override bool Judge(int s,int r,int t )
        {
            if (s != 0)
                return true;
            else
                return false;
        }
        public override void getArea()
        {
            int length = getLength();
            bool r = Judge(length, 0, 0);
            if (r)
            {
                int Sarea = length * length;
                Console.WriteLine("正方形的面积为：" + Sarea);
            }
            else
                Console.WriteLine("输入不合法！请重新输入");
        }

    }
//圆形
class Circle : Action, Length
    {
        private int setLength()
        {
            Console.WriteLine("请输入圆形的半径：");
            int length = Convert.ToInt32(Console.ReadLine());
            return length;
        }
        public int getLength()
        {
            int l0 = setLength();
            return l0;
        }
        public override bool Judge(int s, int r, int t)
        {
            if (s != 0)
                return true;
            else
                return false;
        }
        public override void getArea()
        {
            int length = getLength();
            bool r = Judge(length, 0, 0);
            if (r)
            {
                double Sarea = 3.14*length * length;
                Console.WriteLine("圆形的面积为：" + Sarea);
            }
            else
                Console.WriteLine("输入不合法！请重新输入");
        }
    }
    class Program
    {
        public void Factory(int[] a)
        {
            Rectangle rec = new Rectangle();
            Triangle tri = new Triangle();
            Square sq = new Square();
            Circle cir = new Circle();
            for (int i=0; i<a.Length;i++)
            {
                switch(a[i]){
                    case 1:rec.getArea();break;
                    case 2:tri.getArea();break;
                    case 3:sq.getArea();break;
                    case 4:cir.getArea();break;
                }         
            }
        }
        static void Main(string[] args)
        {
            Program pro = new Program();
            Console.WriteLine("请输入10个要计算面积的图形：(1.长方形  2.三角形  3.正方形  4.圆形)");
            for(int j=0; j<10; j++)
            {
                int[] b = new int[10];
                b[j]= Convert.ToInt32(Console.ReadLine());
                pro.Factory(b);
            }
            Console.ReadKey();
        }
    }
}
