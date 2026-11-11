namespace ExpoDesktop
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
            this.showName = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showName
            // 
            this.showName.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showName.Location = new System.Drawing.Point(294, 156);
            this.showName.Name = "showName";
            this.showName.Size = new System.Drawing.Size(164, 44);
            this.showName.TabIndex = 0;
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.generate.Location = new System.Drawing.Point(294, 283);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(164, 59);
            this.generate.TabIndex = 1;
            this.generate.Text = "生成提示";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result.Location = new System.Drawing.Point(288, 408);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(79, 33);
            this.result.TabIndex = 2;
            this.result.Text = "展区";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 750);
            this.Controls.Add(this.result);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.showName);
            this.Name = "Form1";
            this.Text = "Lab1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showName;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label result;
    }
}

