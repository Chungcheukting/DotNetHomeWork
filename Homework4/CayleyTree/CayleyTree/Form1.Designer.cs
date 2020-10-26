namespace CayleyTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.recursion_depth = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.RightL = new System.Windows.Forms.TrackBar();
            this.LeftL = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RightA = new System.Windows.Forms.TrackBar();
            this.LeftA = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PenColor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recursion_depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftA)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(537, 485);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "draw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // recursion_depth
            // 
            this.recursion_depth.Location = new System.Drawing.Point(650, 18);
            this.recursion_depth.Maximum = 20;
            this.recursion_depth.Minimum = 1;
            this.recursion_depth.Name = "recursion_depth";
            this.recursion_depth.Size = new System.Drawing.Size(130, 56);
            this.recursion_depth.TabIndex = 2;
            this.recursion_depth.Value = 10;
            this.recursion_depth.Scroll += new System.EventHandler(this.recursion_depth_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(500, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "递归深度：10";
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(650, 80);
            this.Length.Maximum = 200;
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(130, 56);
            this.Length.SmallChange = 10;
            this.Length.TabIndex = 4;
            this.Length.Value = 100;
            this.Length.Scroll += new System.EventHandler(this.Length_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(500, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "分支长度:100";
            // 
            // RightL
            // 
            this.RightL.Location = new System.Drawing.Point(650, 142);
            this.RightL.Maximum = 100;
            this.RightL.Minimum = 1;
            this.RightL.Name = "RightL";
            this.RightL.Size = new System.Drawing.Size(131, 56);
            this.RightL.TabIndex = 6;
            this.RightL.Value = 70;
            this.RightL.Scroll += new System.EventHandler(this.RightL_Scroll);
            // 
            // LeftL
            // 
            this.LeftL.Location = new System.Drawing.Point(650, 204);
            this.LeftL.Maximum = 100;
            this.LeftL.Minimum = 1;
            this.LeftL.Name = "LeftL";
            this.LeftL.Size = new System.Drawing.Size(132, 56);
            this.LeftL.TabIndex = 7;
            this.LeftL.Value = 60;
            this.LeftL.Scroll += new System.EventHandler(this.LeftL_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(500, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "右分支长度比：0.7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(500, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "左分支长度比：0.6";
            // 
            // RightA
            // 
            this.RightA.Location = new System.Drawing.Point(650, 255);
            this.RightA.Maximum = 180;
            this.RightA.Name = "RightA";
            this.RightA.Size = new System.Drawing.Size(132, 56);
            this.RightA.TabIndex = 10;
            this.RightA.Value = 30;
            this.RightA.Scroll += new System.EventHandler(this.RightA_Scroll);
            // 
            // LeftA
            // 
            this.LeftA.Location = new System.Drawing.Point(650, 339);
            this.LeftA.Maximum = 180;
            this.LeftA.Name = "LeftA";
            this.LeftA.Size = new System.Drawing.Size(132, 56);
            this.LeftA.TabIndex = 11;
            this.LeftA.Value = 20;
            this.LeftA.Scroll += new System.EventHandler(this.LeftA_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(500, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "右分支角度：30°";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(500, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "左分支角度：20°";
            // 
            // PenColor
            // 
            this.PenColor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PenColor.FormattingEnabled = true;
            this.PenColor.Items.AddRange(new object[] {
            "红色",
            "橙色",
            "黄色",
            "绿色",
            "蓝色",
            "紫色",
            "灰色",
            "黑色"});
            this.PenColor.Location = new System.Drawing.Point(650, 404);
            this.PenColor.Name = "PenColor";
            this.PenColor.Size = new System.Drawing.Size(120, 28);
            this.PenColor.TabIndex = 14;
            this.PenColor.Text = "黑色";
            this.PenColor.SelectedIndexChanged += new System.EventHandler(this.PenColor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(508, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "画笔颜色";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 559);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PenColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LeftA);
            this.Controls.Add(this.RightA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LeftL);
            this.Controls.Add(this.RightL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recursion_depth);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.recursion_depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar recursion_depth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar Length;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar RightL;
        private System.Windows.Forms.TrackBar LeftL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar RightA;
        private System.Windows.Forms.TrackBar LeftA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PenColor;
        private System.Windows.Forms.Label label7;
    }
}

