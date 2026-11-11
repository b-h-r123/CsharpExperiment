namespace Lab04
{
    public partial class Calculation : Form
    {
        private double initialVar;
        private double secondVar;
        private int calculateChoice;
        private double result;
        private bool hasLoading = false;

        public Calculation()
        {
            InitializeComponent();
        }

        private void initialVarTxtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loadVarBt_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(initialVarTxtbox.Text, out double tempVar) || !double.IsFinite(tempVar))
            {
                MessageBox.Show("请输入有效数字");
                return;
            }

            informationBox.Items.Clear();
            hasLoading = true;
            initialVar = tempVar;
            currentVarLb.Text = $"当前变量值为：{initialVar}";


        }

        private void calculateChoiceCmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (calculateChoiceCmbox.SelectedIndex < 4)
            {
                SecondVarTxtbox.Visible = true;
                secondVarLb.Visible = true;
            }
            else if (calculateChoiceCmbox.SelectedIndex >= 4 && calculateChoiceCmbox.SelectedIndex < 7)
            {
                SecondVarTxtbox.Visible = false;
                secondVarLb.Visible = false;
            }
            else
            {
                MessageBox.Show("请选择有效的计算选项");
            }
        }

        private void doCalculationBt_Click(object sender, EventArgs e)
        {
            if (!hasLoading)
            {
                MessageBox.Show("请先加载初始值");
                return;
            }

            calculateChoice = calculateChoiceCmbox.SelectedIndex;

            if (calculateChoice == -1)
            {
                MessageBox.Show("请选择有效的运算");
                return;
            }

            if (calculateChoice < 4 && (!double.TryParse(SecondVarTxtbox.Text, out secondVar) || !double.IsFinite(secondVar)))
            {
                MessageBox.Show("请输入有效的第二个数字");
                return;
            }


            double oldVar = initialVar;

            switch (calculateChoice)
            {
                case 0:
                    result = initialVar + secondVar;
                    break;
                case 1:
                    result = initialVar - secondVar;
                    break;
                case 2:
                    result = initialVar * secondVar;
                    break;
                case 3:
                    if (secondVar == 0)
                    {
                        MessageBox.Show("除数不能为0");
                        return;
                    }
                    else
                    {
                        result = initialVar / secondVar;
                    }
                    break;
                case 4:
                    result = initialVar * initialVar;
                    break;
                case 5:
                    if (initialVar < 0)
                    {
                        MessageBox.Show("不能对负数平方根");
                        return;
                    }
                    result = Math.Sqrt(initialVar);
                    break;
                case 6:
                    if (initialVar == 0)
                    {
                        MessageBox.Show("除数不能为0");
                        return;
                    }
                    else
                    {
                        result = 1 / initialVar;
                    }
                    break;
            }

            if (!double.IsFinite(result))
            {
                MessageBox.Show("计算结果超出范围，当前值保持不变"); 
                return;
            }

            switch (calculateChoice)
            {
                case 0:
                    informationBox.Items.Add($"执行了加法运算：{oldVar} + {secondVar} = {result}");
                    break;
                case 1:
                    informationBox.Items.Add($"执行了减法运算：{oldVar} - {secondVar} = {result}");
                    break;
                case 2:
                    informationBox.Items.Add($"执行了乘法运算：{oldVar} * {secondVar} = {result}");
                    break;
                case 3:
                    informationBox.Items.Add($"执行了除法运算：{oldVar} / {secondVar} = {result}");
                    break;
                case 4:
                    informationBox.Items.Add($"执行了平方运算：{oldVar} ^ 2 = {result}");
                    break;
                case 5:
                    informationBox.Items.Add($"执行了平方根运算：√{oldVar} = {result}");
                    break;
                case 6:
                    informationBox.Items.Add($"执行了倒数运算：1 / {oldVar} = {result}");
                    break;
            }

            initialVar = result;
            initialVarTxtbox.Text = $"{initialVar}";
            currentVarLb.Text = $"当前变量值为：{initialVar}";

        }

        private void resetBt_Click(object sender, EventArgs e)
        {
            clearInformationBox();
        }

        private void clearInformationBox()
        {
            informationBox.Items.Clear();
            hasLoading = false;
            initialVar = 0;
            secondVar = 0;
            initialVarTxtbox.Text = "";
            SecondVarTxtbox.Text = "";
            currentVarLb.Text = $"当前变量值为：";
        }

    }
}
