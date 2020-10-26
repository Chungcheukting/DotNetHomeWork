namespace week8
{
    partial class FormDelScuccess
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnsure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "删除成功，即将回到主页面以便保存更改";
            // 
            // buttonEnsure
            // 
            this.buttonEnsure.Location = new System.Drawing.Point(89, 174);
            this.buttonEnsure.Name = "buttonEnsure";
            this.buttonEnsure.Size = new System.Drawing.Size(75, 23);
            this.buttonEnsure.TabIndex = 1;
            this.buttonEnsure.Text = "确定";
            this.buttonEnsure.UseVisualStyleBackColor = true;
            this.buttonEnsure.Click += new System.EventHandler(this.buttonEnsure_Click);
            // 
            // FormDelScuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.buttonEnsure);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormDelScuccess";
            this.Text = "FormDel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnsure;
    }
}