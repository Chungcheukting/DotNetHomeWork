namespace week8
{
    partial class DetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEnsure = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.totalMoneyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addOrderItemButton = new System.Windows.Forms.Button();
            this.listBoxOI = new System.Windows.Forms.ListBox();
            this.bindingSourceOIL = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOIL)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonEnsure, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(242, 446);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(141, 38);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonEnsure
            // 
            this.buttonEnsure.AutoSize = true;
            this.buttonEnsure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEnsure.Location = new System.Drawing.Point(3, 3);
            this.buttonEnsure.Name = "buttonEnsure";
            this.buttonEnsure.Size = new System.Drawing.Size(135, 32);
            this.buttonEnsure.TabIndex = 1;
            this.buttonEnsure.Text = " 确 认 ";
            this.buttonEnsure.UseVisualStyleBackColor = true;
            this.buttonEnsure.Click += new System.EventHandler(this.buttonEnsure_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 487);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.orderIDTextBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.totalMoneyTextBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.customerIDTextBox, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.customerNameTextBox, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.timeTextBox, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.addOrderItemButton, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.listBoxOI, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.buttonDel, 2, 6);
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(632, 437);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderIDTextBox.Location = new System.Drawing.Point(319, 3);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(310, 25);
            this.orderIDTextBox.TabIndex = 1;
            // 
            // totalMoneyTextBox
            // 
            this.totalMoneyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalMoneyTextBox.Location = new System.Drawing.Point(319, 47);
            this.totalMoneyTextBox.Name = "totalMoneyTextBox";
            this.totalMoneyTextBox.ReadOnly = true;
            this.totalMoneyTextBox.Size = new System.Drawing.Size(310, 25);
            this.totalMoneyTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(161, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "订单号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(161, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "总金额";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(161, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 38);
            this.label7.TabIndex = 9;
            this.label7.Text = "下单时间";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.tableLayoutPanel2.SetRowSpan(this.label2, 3);
            this.label2.Size = new System.Drawing.Size(152, 126);
            this.label2.TabIndex = 4;
            this.label2.Text = "订单信息";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(161, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "顾客名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(161, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 38);
            this.label8.TabIndex = 10;
            this.label8.Text = "顾客ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerIDTextBox.Location = new System.Drawing.Point(319, 179);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(310, 25);
            this.customerIDTextBox.TabIndex = 11;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerNameTextBox.Location = new System.Drawing.Point(319, 135);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(310, 25);
            this.customerNameTextBox.TabIndex = 12;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeTextBox.Location = new System.Drawing.Point(319, 91);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(310, 25);
            this.timeTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.tableLayoutPanel2.SetRowSpan(this.label3, 2);
            this.label3.Size = new System.Drawing.Size(152, 82);
            this.label3.TabIndex = 5;
            this.label3.Text = "顾客信息";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 223);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.tableLayoutPanel2.SetRowSpan(this.label9, 2);
            this.label9.Size = new System.Drawing.Size(152, 211);
            this.label9.TabIndex = 14;
            this.label9.Text = "订单项";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addOrderItemButton
            // 
            this.addOrderItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addOrderItemButton.Location = new System.Drawing.Point(161, 401);
            this.addOrderItemButton.Name = "addOrderItemButton";
            this.addOrderItemButton.Size = new System.Drawing.Size(152, 33);
            this.addOrderItemButton.TabIndex = 17;
            this.addOrderItemButton.Text = "添加新商品项";
            this.addOrderItemButton.UseVisualStyleBackColor = true;
            this.addOrderItemButton.Click += new System.EventHandler(this.addOrderItemButton_Click);
            // 
            // listBoxOI
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.listBoxOI, 2);
            this.listBoxOI.DataSource = this.bindingSourceOIL;
            this.listBoxOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOI.FormattingEnabled = true;
            this.listBoxOI.ItemHeight = 15;
            this.listBoxOI.Location = new System.Drawing.Point(161, 223);
            this.listBoxOI.Name = "listBoxOI";
            this.listBoxOI.Size = new System.Drawing.Size(468, 172);
            this.listBoxOI.TabIndex = 18;
            this.listBoxOI.DoubleClick += new System.EventHandler(this.listBoxOI_DoubleClick);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(319, 401);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(148, 30);
            this.buttonDel.TabIndex = 19;
            this.buttonDel.Text = "删除该订单项";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(662, 511);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DetailForm_FormClosed);
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOIL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonEnsure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalMoneyTextBox;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addOrderItemButton;
        private System.Windows.Forms.ListBox listBoxOI;
        private System.Windows.Forms.BindingSource bindingSourceOIL;
        private System.Windows.Forms.Button buttonDel;
    }
}