namespace week8
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
            this.components = new System.ComponentModel.Container();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.OrdersListBox = new System.Windows.Forms.ListBox();
            this.OrderInfoLable = new System.Windows.Forms.Label();
            this.AddOrder = new System.Windows.Forms.Button();
            this.ChangeOrder = new System.Windows.Forms.Button();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.SearchOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(9, 57);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.OrdersListBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.OrderInfoLable);
            this.splitContainer2.Size = new System.Drawing.Size(887, 407);
            this.splitContainer2.SplitterDistance = 295;
            this.splitContainer2.TabIndex = 4;
            // 
            // OrdersListBox
            // 
            this.OrdersListBox.DataSource = this.orderBindingSource;
            this.OrdersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersListBox.FormattingEnabled = true;
            this.OrdersListBox.ItemHeight = 15;
            this.OrdersListBox.Location = new System.Drawing.Point(0, 0);
            this.OrdersListBox.Name = "OrdersListBox";
            this.OrdersListBox.Size = new System.Drawing.Size(295, 407);
            this.OrdersListBox.TabIndex = 2;
            this.OrdersListBox.SelectedIndexChanged += new System.EventHandler(this.OrdersListBox_SelectedIndexChanged);
            // 
            // OrderInfoLable
            // 
            this.OrderInfoLable.AutoSize = true;
            this.OrderInfoLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderInfoLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderInfoLable.Location = new System.Drawing.Point(0, 0);
            this.OrderInfoLable.Name = "OrderInfoLable";
            this.OrderInfoLable.Size = new System.Drawing.Size(89, 20);
            this.OrderInfoLable.TabIndex = 0;
            this.OrderInfoLable.Text = "订单信息";
            this.OrderInfoLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(10, 12);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(123, 33);
            this.AddOrder.TabIndex = 5;
            this.AddOrder.Text = "添加订单";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // ChangeOrder
            // 
            this.ChangeOrder.Location = new System.Drawing.Point(184, 12);
            this.ChangeOrder.Name = "ChangeOrder";
            this.ChangeOrder.Size = new System.Drawing.Size(120, 31);
            this.ChangeOrder.TabIndex = 6;
            this.ChangeOrder.Text = "修改订单";
            this.ChangeOrder.UseVisualStyleBackColor = true;
            this.ChangeOrder.Click += new System.EventHandler(this.ChangeOrder_Click);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(350, 13);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(119, 31);
            this.DeleteOrder.TabIndex = 7;
            this.DeleteOrder.Text = "删除订单";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            this.DeleteOrder.Click += new System.EventHandler(this.DeleteOrder_Click);
            // 
            // SearchOrder
            // 
            this.SearchOrder.Location = new System.Drawing.Point(520, 13);
            this.SearchOrder.Name = "SearchOrder";
            this.SearchOrder.Size = new System.Drawing.Size(112, 30);
            this.SearchOrder.TabIndex = 8;
            this.SearchOrder.Text = "查找订单";
            this.SearchOrder.UseVisualStyleBackColor = true;
            this.SearchOrder.Click += new System.EventHandler(this.SearchOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 476);
            this.Controls.Add(this.SearchOrder);
            this.Controls.Add(this.DeleteOrder);
            this.Controls.Add(this.ChangeOrder);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.splitContainer2);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox OrdersListBox;
        private System.Windows.Forms.Label OrderInfoLable;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button ChangeOrder;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Button SearchOrder;
    }
}

