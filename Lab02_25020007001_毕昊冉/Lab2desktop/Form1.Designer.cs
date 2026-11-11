namespace Lab2desktop
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
            this.button1 = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.borderLabel = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtBorder = new System.Windows.Forms.TextBox();
            this.lbdisplayarea = new System.Windows.Forms.Label();
            this.lbedgearea = new System.Windows.Forms.Label();
            this.lbedgecircle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(180, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.widthLabel.Location = new System.Drawing.Point(77, 94);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(170, 28);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "width (cm)";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.heightLabel.Location = new System.Drawing.Point(77, 157);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(170, 28);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "height (cm)";
            // 
            // borderLabel
            // 
            this.borderLabel.AutoSize = true;
            this.borderLabel.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.borderLabel.Location = new System.Drawing.Point(77, 215);
            this.borderLabel.Name = "borderLabel";
            this.borderLabel.Size = new System.Drawing.Size(170, 28);
            this.borderLabel.TabIndex = 3;
            this.borderLabel.Text = "border (cm)";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWidth.Location = new System.Drawing.Point(285, 91);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(142, 39);
            this.txtWidth.TabIndex = 4;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeight.Location = new System.Drawing.Point(285, 157);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(142, 39);
            this.txtHeight.TabIndex = 5;
            // 
            // txtBorder
            // 
            this.txtBorder.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBorder.Location = new System.Drawing.Point(285, 215);
            this.txtBorder.Name = "txtBorder";
            this.txtBorder.Size = new System.Drawing.Size(142, 39);
            this.txtBorder.TabIndex = 6;
            // 
            // lbdisplayarea
            // 
            this.lbdisplayarea.AutoSize = true;
            this.lbdisplayarea.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbdisplayarea.Location = new System.Drawing.Point(77, 426);
            this.lbdisplayarea.Name = "lbdisplayarea";
            this.lbdisplayarea.Size = new System.Drawing.Size(152, 28);
            this.lbdisplayarea.TabIndex = 7;
            this.lbdisplayarea.Text = "展示面积为";
            // 
            // lbedgearea
            // 
            this.lbedgearea.AutoSize = true;
            this.lbedgearea.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbedgearea.Location = new System.Drawing.Point(77, 496);
            this.lbedgearea.Name = "lbedgearea";
            this.lbedgearea.Size = new System.Drawing.Size(208, 28);
            this.lbedgearea.TabIndex = 8;
            this.lbedgearea.Text = "边缘材料面积为";
            // 
            // lbedgecircle
            // 
            this.lbedgecircle.AutoSize = true;
            this.lbedgecircle.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbedgecircle.Location = new System.Drawing.Point(77, 565);
            this.lbedgecircle.Name = "lbedgecircle";
            this.lbedgecircle.Size = new System.Drawing.Size(180, 28);
            this.lbedgecircle.TabIndex = 9;
            this.lbedgecircle.Text = "外边缘周长为";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 790);
            this.Controls.Add(this.lbedgecircle);
            this.Controls.Add(this.lbedgearea);
            this.Controls.Add(this.lbdisplayarea);
            this.Controls.Add(this.txtBorder);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.borderLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "计算数值";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label borderLabel;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtBorder;
        private System.Windows.Forms.Label lbdisplayarea;
        private System.Windows.Forms.Label lbedgearea;
        private System.Windows.Forms.Label lbedgecircle;
    }
}

