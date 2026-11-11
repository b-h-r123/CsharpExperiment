namespace Lab04
{
    partial class Calculation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            initialVarTxtbox = new TextBox();
            loadVarBt = new Button();
            SecondVarTxtbox = new TextBox();
            currentVarLb = new Label();
            calculateChoiceCmbox = new ComboBox();
            doCalculationBt = new Button();
            calculateChooseLb = new Label();
            resetBt = new Button();
            informationBox = new ListBox();
            initialVarLb = new Label();
            secondVarLb = new Label();
            SuspendLayout();
            // 
            // initialVarTxtbox
            // 
            initialVarTxtbox.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            initialVarTxtbox.Location = new Point(63, 103);
            initialVarTxtbox.Name = "initialVarTxtbox";
            initialVarTxtbox.Size = new Size(199, 43);
            initialVarTxtbox.TabIndex = 0;
            initialVarTxtbox.TextChanged += initialVarTxtbox_TextChanged;
            // 
            // loadVarBt
            // 
            loadVarBt.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            loadVarBt.Location = new Point(301, 103);
            loadVarBt.Name = "loadVarBt";
            loadVarBt.Size = new Size(186, 43);
            loadVarBt.TabIndex = 1;
            loadVarBt.Text = "载入初始值";
            loadVarBt.UseVisualStyleBackColor = true;
            loadVarBt.Click += loadVarBt_Click;
            // 
            // SecondVarTxtbox
            // 
            SecondVarTxtbox.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            SecondVarTxtbox.Location = new Point(253, 264);
            SecondVarTxtbox.Name = "SecondVarTxtbox";
            SecondVarTxtbox.Size = new Size(199, 43);
            SecondVarTxtbox.TabIndex = 2;
            SecondVarTxtbox.Visible = false;
            // 
            // currentVarLb
            // 
            currentVarLb.AutoSize = true;
            currentVarLb.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            currentVarLb.Location = new Point(522, 106);
            currentVarLb.Name = "currentVarLb";
            currentVarLb.Size = new Size(127, 36);
            currentVarLb.TabIndex = 3;
            currentVarLb.Text = "当前值：";
            // 
            // calculateChoiceCmbox
            // 
            calculateChoiceCmbox.DropDownStyle = ComboBoxStyle.DropDownList;
            calculateChoiceCmbox.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            calculateChoiceCmbox.FormattingEnabled = true;
            calculateChoiceCmbox.Items.AddRange(new object[] { "加法", "减法", "乘法", "除法", "平方", "平方根", "倒数" });
            calculateChoiceCmbox.Location = new Point(253, 187);
            calculateChoiceCmbox.Name = "calculateChoiceCmbox";
            calculateChoiceCmbox.Size = new Size(182, 39);
            calculateChoiceCmbox.TabIndex = 4;
            calculateChoiceCmbox.SelectedIndexChanged += calculateChoiceCmbox_SelectedIndexChanged;
            // 
            // doCalculationBt
            // 
            doCalculationBt.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            doCalculationBt.Location = new Point(63, 343);
            doCalculationBt.Name = "doCalculationBt";
            doCalculationBt.Size = new Size(122, 49);
            doCalculationBt.TabIndex = 5;
            doCalculationBt.Text = "执行";
            doCalculationBt.UseVisualStyleBackColor = true;
            doCalculationBt.Click += doCalculationBt_Click;
            // 
            // calculateChooseLb
            // 
            calculateChooseLb.AutoSize = true;
            calculateChooseLb.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            calculateChooseLb.Location = new Point(63, 186);
            calculateChooseLb.Name = "calculateChooseLb";
            calculateChooseLb.Size = new Size(155, 36);
            calculateChooseLb.TabIndex = 6;
            calculateChooseLb.Text = "运算选择：";
            // 
            // resetBt
            // 
            resetBt.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            resetBt.Location = new Point(253, 343);
            resetBt.Name = "resetBt";
            resetBt.Size = new Size(123, 49);
            resetBt.TabIndex = 7;
            resetBt.Text = "重置";
            resetBt.UseVisualStyleBackColor = true;
            resetBt.Click += resetBt_Click;
            // 
            // informationBox
            // 
            informationBox.FormattingEnabled = true;
            informationBox.ItemHeight = 24;
            informationBox.Location = new Point(63, 431);
            informationBox.Name = "informationBox";
            informationBox.Size = new Size(576, 196);
            informationBox.TabIndex = 8;
            // 
            // initialVarLb
            // 
            initialVarLb.AutoSize = true;
            initialVarLb.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            initialVarLb.Location = new Point(63, 48);
            initialVarLb.Name = "initialVarLb";
            initialVarLb.Size = new Size(183, 36);
            initialVarLb.TabIndex = 9;
            initialVarLb.Text = "输入初始值：";
            // 
            // secondVarLb
            // 
            secondVarLb.AutoSize = true;
            secondVarLb.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            secondVarLb.Location = new Point(63, 267);
            secondVarLb.Name = "secondVarLb";
            secondVarLb.Size = new Size(183, 36);
            secondVarLb.TabIndex = 10;
            secondVarLb.Text = "第二操作数：";
            secondVarLb.Visible = false;
            // 
            // Calculation
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 757);
            Controls.Add(secondVarLb);
            Controls.Add(initialVarLb);
            Controls.Add(informationBox);
            Controls.Add(resetBt);
            Controls.Add(calculateChooseLb);
            Controls.Add(doCalculationBt);
            Controls.Add(calculateChoiceCmbox);
            Controls.Add(currentVarLb);
            Controls.Add(SecondVarTxtbox);
            Controls.Add(loadVarBt);
            Controls.Add(initialVarTxtbox);
            Name = "Calculation";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox initialVarTxtbox;
        private Button loadVarBt;
        private TextBox SecondVarTxtbox;
        private Label currentVarLb;
        private ComboBox calculateChoiceCmbox;
        private Button doCalculationBt;
        private Label calculateChooseLb;
        private Button resetBt;
        private ListBox informationBox;
        private Label initialVarLb;
        private Label secondVarLb;
    }
}
