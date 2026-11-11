namespace Lab03
{
    partial class Form1
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
            guessNumText = new TextBox();
            ReadyChoose = new Label();
            LabelRange = new Label();
            registe = new Button();
            RestartNew = new Button();
            HistoryRecord = new Label();
            HistoryList = new ListBox();
            SuspendLayout();
            // 
            // guessNumText
            // 
            guessNumText.Location = new Point(184, 126);
            guessNumText.Name = "guessNumText";
            guessNumText.Size = new Size(161, 30);
            guessNumText.TabIndex = 0;
            // 
            // ReadyChoose
            // 
            ReadyChoose.AutoSize = true;
            ReadyChoose.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ReadyChoose.Location = new Point(41, 120);
            ReadyChoose.Name = "ReadyChoose";
            ReadyChoose.Size = new Size(99, 36);
            ReadyChoose.TabIndex = 1;
            ReadyChoose.Text = "候选值";
            ReadyChoose.Click += ReadyChoose_Click;
            // 
            // LabelRange
            // 
            LabelRange.AutoSize = true;
            LabelRange.Font = new Font("宋体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            LabelRange.Location = new Point(41, 56);
            LabelRange.Name = "LabelRange";
            LabelRange.Size = new Size(290, 28);
            LabelRange.TabIndex = 2;
            LabelRange.Text = "当前有效区间为20-80";
            // 
            // registe
            // 
            registe.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            registe.Location = new Point(393, 120);
            registe.Name = "registe";
            registe.Size = new Size(112, 45);
            registe.TabIndex = 3;
            registe.Text = "提交";
            registe.UseVisualStyleBackColor = true;
            registe.Click += registe_Click;
            // 
            // RestartNew
            // 
            RestartNew.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            RestartNew.Location = new Point(540, 120);
            RestartNew.Name = "RestartNew";
            RestartNew.Size = new Size(165, 45);
            RestartNew.TabIndex = 4;
            RestartNew.Text = "开始新一轮";
            RestartNew.UseVisualStyleBackColor = true;
            RestartNew.Click += RestartNew_Click;
            // 
            // HistoryRecord
            // 
            HistoryRecord.AutoSize = true;
            HistoryRecord.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            HistoryRecord.Location = new Point(41, 224);
            HistoryRecord.Name = "HistoryRecord";
            HistoryRecord.Size = new Size(157, 37);
            HistoryRecord.TabIndex = 5;
            HistoryRecord.Text = "历史记录：";
            // 
            // HistoryList
            // 
            HistoryList.FormattingEnabled = true;
            HistoryList.ItemHeight = 24;
            HistoryList.Location = new Point(41, 311);
            HistoryList.Name = "HistoryList";
            HistoryList.Size = new Size(664, 364);
            HistoryList.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 751);
            Controls.Add(HistoryList);
            Controls.Add(HistoryRecord);
            Controls.Add(RestartNew);
            Controls.Add(registe);
            Controls.Add(LabelRange);
            Controls.Add(ReadyChoose);
            Controls.Add(guessNumText);
            Name = "Form1";
            Text = "温感测试";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox guessNumText;
        private Label ReadyChoose;
        private Label LabelRange;
        private Button registe;
        private Button RestartNew;
        private Label HistoryRecord;
        private ListBox HistoryList;
    }
}
