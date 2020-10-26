using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
        }

        private Graphics graphics;
        int n = 10;                         //递归深度
        int leng = 100;                     //主干长度
        double th1 = 30 * Math.PI / 180;    //右分支角度
        double th2 = 20 * Math.PI / 180;    //左分支角度
        double per1 = 0.6;                  //右分支长度
        double per2 = 0.7;                  //左分支长度
        Pen pen = Pens.Black;                //画笔颜色

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0)
                return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void recursion_depth_Scroll(object sender, EventArgs e)
        {
            label1.Text = $"递归深度:{recursion_depth.Value}";
            n = recursion_depth.Value;
        }

        private void Length_Scroll(object sender, EventArgs e)
        {
            label2.Text = $"主干长度:{Length.Value}";
            leng = Length.Value;
        }

        private void RightL_Scroll(object sender, EventArgs e)
        {
            label3.Text = $"右分支长度比:{((double)RightL.Value) / 100}";
            per1 = ((double)RightL.Value) / 100;
        }

        private void LeftL_Scroll(object sender, EventArgs e)
        {
            label4.Text = $"左分支长度比:{((double)LeftL.Value) / 100}";
            per2 = ((double)LeftL.Value) / 100;
        }

        private void RightA_Scroll(object sender, EventArgs e)
        {
            label5.Text = $"右分支角度:{LeftA.Value}°";
            th1 = ((double)LeftA.Value) * Math.PI / 180;
        }

        private void LeftA_Scroll(object sender, EventArgs e)
        {
            label6.Text = $"左分支角度:{LeftA.Value}°";
            th2 = ((double)LeftA.Value) * Math.PI / 180;
        }

        private void PenColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string[] pencolor = new[] { "红色", "橙色", "黄色", "绿色", "蓝色", "紫色", "灰色", "黑色" };
            //PenColor.DataSource = pencolor;
            string color = PenColor.SelectedItem.ToString();
            switch(color)
            {
                case "红色": pen = Pens.Red;break;
                case "橙色": pen = Pens.Orange;break;
                case "黄色": pen = Pens.Yellow;break;
                case "绿色": pen = Pens.Green;break;
                case "蓝色": pen = Pens.Blue;break;
                case "紫色": pen = Pens.Purple; break;
                case "灰色": pen = Pens.Gray; break;
                case "黑色": pen = Pens.Black; break;
            }
        }    
    }
}
