using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbdisplayarea.Text = "展示面积:—";
            lbedgearea.Text = "边框材料面积:—";
            lbedgecircle.Text = "外边缘周长:—";

            if(string.IsNullOrWhiteSpace(txtWidth.Text) || 
                string.IsNullOrWhiteSpace(txtHeight.Text) || 
                string.IsNullOrWhiteSpace(txtBorder.Text))
            {
                MessageBox.Show("请把宽度、高度、边框宽度填写完整");
                return;
            }

            if(!TryParseNumber(txtWidth.Text, out double width) || 
                !TryParseNumber(txtHeight.Text, out double height) || 
                !TryParseNumber(txtBorder.Text, out double border))
            {
                MessageBox.Show("请确保宽度、高度、边框宽度为数字");
                return;
            }

            if (double.IsNaN(width) || double.IsInfinity(width) ||
                double.IsNaN(height) || double.IsInfinity(height) ||
                double.IsNaN(border) || double.IsInfinity(border))
            {
                MessageBox.Show("宽度、高度、边框宽度都必须是有限实数");
                return;
            }

            if ((width <= 0 || width > 10000) || (height <= 0 || height > 10000) || border <= 0)
            {
                if (width <= 0)
                {
                    MessageBox.Show("宽度非正");
                }
                else if (width > 10000)
                {
                    MessageBox.Show("宽度过大");
                }
                else if (height <= 0)
                {
                    MessageBox.Show("高度非正");
                }
                else if (height > 10000)
                {
                    MessageBox.Show("高度过大");
                }
                else if (border <= 0)
                {
                    MessageBox.Show("边框宽度非正");
                }

                return;
            }

            double innerwidth = width - 2 * border;
            double innerheight = height - 2 * border;
            double displayarea = innerwidth * innerheight;
            double edgearea = width * height - displayarea;
            double edgecircle = 2 * (width + height);

            if (innerheight <= 0)
            {
                if (innerheight < 0)
                {
                    MessageBox.Show("内部高度非正");
                }
                else
                {
                    MessageBox.Show("内部高度为0");
                }

                return;
            }

            if(innerwidth <= 0)
            {
                if (innerwidth < 0)
                {
                    MessageBox.Show("内部宽度非正");
                }
                else
                {
                    MessageBox.Show("内部宽度为0");
                }

                return;
            }

            lbdisplayarea.Text = $"展示面积:{displayarea:F2} cm²";
            lbedgearea.Text = $"边框材料面积:{edgearea:F2} cm²";
            lbedgecircle.Text = $"外边缘周长:{edgecircle:F2} cm";

        }

        private static bool TryParseNumber(string text, out double value)
        {
            return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value);
        }
    }
}
