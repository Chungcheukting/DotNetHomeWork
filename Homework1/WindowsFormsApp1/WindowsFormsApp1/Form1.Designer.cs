namespace WindowsFormsApp1
{
    partial class Form1
    {
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(209, 264);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(423, 55);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "计算";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(210, 348);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(421, 59);
            this.clear.TabIndex = 1;
            this.clear.Text = "清零";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(63, 90);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(151, 30);
            this.num1.TabIndex = 2;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(417, 90);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(157, 30);
            this.num2.TabIndex = 3;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(657, 90);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(151, 30);
            this.result.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox.Location = new System.Drawing.Point(267, 92);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(97, 28);
            this.comboBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(854, 436);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

