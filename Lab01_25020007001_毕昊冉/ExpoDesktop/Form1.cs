using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpoDesktop
{
    public partial class Form1 : Form
    {
        private const string studentid = "25020007001";
        private const string form = "智能制造";
        public Form1()
        {
            InitializeComponent();
            this.Text = $"{studentid} 科创展提示工具";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            string generate_inf = showName.Text.Trim();
            if (string.IsNullOrWhiteSpace(generate_inf))
            {
                MessageBox.Show("请输入展位名称。");
                return;
            }

            result.Text = $"欢迎参观【{form}】展区的【{generate_inf}】展位";
        }
    }
}
