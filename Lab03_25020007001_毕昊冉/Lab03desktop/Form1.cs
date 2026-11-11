using System;
using System.Collections.Generic;

namespace Lab03
{
    public partial class Form1 : Form
    {
        private int randomNum;
        private bool isFinished = false;
        private List<string> history = new List<string>();
        private int lownum = 20;
        private int highnum = 80;
        private List<int> guessHistory = new List<int>();
        private const bool testmode = false;
        private const int testNum = 53;

        public Form1()
        {
            InitializeComponent();
            randomNum = testmode? testNum : new Random().Next(20,81);
        }

        private void ReadyChoose_Click(object sender, EventArgs e)
        {

        }

        private void registe_Click(object sender, EventArgs e)
        {
            if(isFinished) {
                MessageBox.Show("本轮已结束，请点击开始新一轮");
                return;
            }
            int inputNum;
            if (!(int.TryParse(guessNumText.Text, out inputNum)))
            {
                MessageBox.Show("请输入整数：");
                return;
            }
            if (inputNum < lownum || inputNum > highnum)
            {
                MessageBox.Show($"请输入{lownum}-{highnum}之间的整数：");
                return;
            }

            foreach (var item in guessHistory)
            {
                if(inputNum == item)
                {
                    MessageBox.Show("你已经猜过这个数字了，请重新输入！");
                    return;
                }
            }

            if (inputNum < randomNum)
            {
                lownum = inputNum+1;
                history.Add($"候选值：{inputNum},需要调高,范围是{lownum}~{highnum}");
                LabelRange.Text = $"范围是{lownum}~{highnum}";
            }
            else if (inputNum == randomNum)
            {
                LabelRange.Text = $"结果是{randomNum}";
                history.Add($"候选值：{inputNum},校准完成,范围{lownum}~{highnum}");
                isFinished = true;
            }
            else
            {
                highnum = inputNum-1;
                history.Add($"候选值：{inputNum},需要调低,范围是{lownum}~{highnum}");
                LabelRange.Text = $"范围是{lownum}~{highnum}";
            }

            RefreshHistory();
        }

        private void RefreshHistory()
        {
            HistoryList.Items.Clear();
            foreach (string record in history)
            {
                HistoryList.Items.Add(record);
            }
        }

        private void RestartNew_Click(object sender, EventArgs e)
        {
            isFinished = false;
            guessHistory.Clear();
            history.Clear();
            HistoryList.Items.Clear();
            randomNum = testmode ? testNum : new Random().Next(20, 81);
            lownum = 20;
            highnum = 80;
            LabelRange.Text = $"范围是{lownum}~{highnum}";
            guessNumText.Clear();
        }
    }
}
