using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public static double result = 0;
        public static double mem = 0;
        public static string op1 = "";
        public static string op2 = "";
        public static char operation;
        public static bool dot = false, haschar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            if (haschar == true)
            {
                textBox1.Text = bt_0.Text;
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(bt_0.Text);
            }
            else
            {
                textBox1.AppendText(bt_0.Text);
            }
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            if (haschar == true)
            {
                textBox1.Text = bt_1.Text;
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(bt_1.Text);
            }
            else
            {
                textBox1.AppendText(bt_1.Text);
            }
            if (haschar == true)
                haschar = false;
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            if (haschar == true)
            {
                textBox1.Text = bt_2.Text;
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(bt_2.Text);
            }
            else
            {
                textBox1.AppendText(bt_2.Text);
            }
            if (haschar == true)
                haschar = false;
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            if (haschar == true)
            {
                textBox1.Text = bt_3.Text;
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(bt_3.Text);
            }
            else
            {
                textBox1.AppendText(bt_3.Text);
            }
            if (haschar == true)
                haschar = false;
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            if (haschar == true)
            {
                textBox1.Text = bt_4.Text;
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(bt_4.Text);
            }
            else
            {
                textBox1.AppendText(bt_4.Text);
            }
            if (haschar == true)
                haschar = false;
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            if (haschar == true)
            {
                textBox1.Text = bt_5.Text;
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(bt_5.Text);
            }
            else
            {
                textBox1.AppendText(bt_5.Text);
            }
            if (haschar == true)
                haschar = false;
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            if (haschar == true)
            {
                textBox1.Text = bt_6.Text;
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(bt_6.Text);
            }
            else
            {
                textBox1.AppendText(bt_6.Text);
            }
            if (haschar == true)
                haschar = false;
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            if (haschar == true)
            {
                textBox1.Text = bt_7.Text;
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(bt_7.Text);
            }
            else
            {
                textBox1.AppendText(bt_7.Text);
            }
            if (haschar == true)
                haschar = false;
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            if (haschar == true)
            {
                textBox1.Text = bt_8.Text;
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(bt_8.Text);
            }
            else
            {
                textBox1.AppendText(bt_8.Text);
            }
            if (haschar == true)
                haschar = false;
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            if (haschar == true)
            {
                textBox2.Text = "";
                textBox1.Text = bt_9.Text;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.AppendText(bt_9.Text);
            }
            else
            {
                textBox1.AppendText(bt_9.Text);
            }
            if (haschar == true)
                haschar = false;
        }

        private void bt_dot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0.";
                dot = true;
            }
            else if (dot == false)
            {
                textBox1.AppendText(bt_dot.Text);
                dot = true;
            }

        }

        private void bt_plus_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text + bt_plus.Text;
            op1 = textBox1.Text;
            operation = '+';
            textBox1.Text = "";
            dot = false;

        }

        private void bt_equal_Click(object sender, EventArgs e)
        {
            DataTable obj = new DataTable();
            string tem = textBox2.Text + textBox1.Text;
            double a = Convert.ToDouble(obj.Compute(tem, null));
            textBox1.Text = Convert.ToString(a);
            textBox2.Text = tem;
            haschar = true;
        }

        private void bt_min_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text + bt_min.Text;
            op1 = textBox1.Text;
            operation = '-';
            textBox1.Text = "";
            dot = false;
        }

        private void bt_mul_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text + bt_mul.Text;
            op1 = textBox1.Text;
            operation = '*';
            textBox1.Text = "";
            dot = false;
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text + bt_div.Text;
            op1 = textBox1.Text;
            operation = '/';
            textBox1.Text = "";
            dot = false;
        }

        private void bt_ce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bt_c_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            op1 = "";
            op2 = "";
            result = 0;
            operation = '\0';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            int l = textBox1.Text.Length;
            string tem = textBox1.Text;
            textBox1.Text = "";
            for (int i = 0; i < l - 1; i++)
            {
                textBox1.AppendText(Convert.ToString(tem[i]));
            }
        }

        private void bt_plusminus_Click(object sender, EventArgs e)
        {
            double plminus = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString((-1) * plminus);
        }

        private void bt_sqrt_Click(object sender, EventArgs e)
        {
            op1 = textBox1.Text;
            result = Math.Sqrt(Convert.ToDouble(op1));
            textBox1.Text = Convert.ToString(result);
            op1 = "";
        }

        private void bt_inverse_Click(object sender, EventArgs e)
        {
            op1 = textBox1.Text;
            result = 1 / Convert.ToDouble(op1);
            textBox1.Text = Convert.ToString(result);
            op1 = "";
        }

        private void bt_per_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text + bt_per.Text;
            op1 = textBox1.Text;
            operation = '%';
            textBox1.Text = "";
            dot = false;
        }

        private void bt_mc_Click(object sender, EventArgs e)
        {
            mem = 0;
            dot = false;
        }

        private void bt_mr_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(mem);
            dot = false;
        }

        private void bt_mplus_Click(object sender, EventArgs e)
        {
            mem += Convert.ToDouble(textBox1.Text);
            dot = false;
        }

        private void bt_mminus_Click(object sender, EventArgs e)
        {
            mem -= Convert.ToDouble(textBox1.Text);
            dot = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_ms_Click(object sender, EventArgs e)
        {
            mem = Convert.ToDouble(textBox1.Text);
        }
    }
}
