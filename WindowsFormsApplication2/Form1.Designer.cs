namespace WindowsFormsApplication2
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tiaomalkx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tiaomaycx = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tiaomalkx
            // 
            this.tiaomalkx.Location = new System.Drawing.Point(25, 36);
            this.tiaomalkx.Name = "tiaomalkx";
            this.tiaomalkx.Size = new System.Drawing.Size(143, 21);
            this.tiaomalkx.TabIndex = 0;
            this.tiaomalkx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button1.Location = new System.Drawing.Point(185, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tiaomaycx
            // 
            this.tiaomaycx.Location = new System.Drawing.Point(25, 93);
            this.tiaomaycx.Name = "tiaomaycx";
            this.tiaomaycx.Size = new System.Drawing.Size(230, 105);
            this.tiaomaycx.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tiaomaycx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tiaomalkx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tiaomalkx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel tiaomaycx;
    }
}

