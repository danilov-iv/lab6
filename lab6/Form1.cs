using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool dot_flag;
        private bool operation_flag;
        private void add_symbol(int symb)
        {
            if (Display.Text == "0" || Display.Text == float.PositiveInfinity.ToString())
                Display.Text = "";
            Display.Text += symb;
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            add_symbol(0);
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            add_symbol(1);
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            add_symbol(2);
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            add_symbol(3);
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            add_symbol(4);
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            add_symbol(5);
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            add_symbol(6);
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            add_symbol(7);
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            add_symbol(8);
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            add_symbol(9);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Display.Text.EndsWith(",") ||
                Display.Text.EndsWith("+") || Display.Text.EndsWith("-") ||
                Display.Text.EndsWith("*") || Display.Text.EndsWith("/") || Display.Text == float.PositiveInfinity.ToString()
                )
                return;
            if (operation_flag)
                Calculate();
            dot_flag = false;
            Display.Text += "+";
            operation_flag = true;
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            if (Display.Text.EndsWith(",") ||
                Display.Text.EndsWith("+") || Display.Text.EndsWith("-") ||
                Display.Text.EndsWith("*") || Display.Text.EndsWith("/") || Display.Text == float.PositiveInfinity.ToString()
                )
                return;
            if (operation_flag)
                Calculate();
            dot_flag = false;
            Display.Text += "-";
            operation_flag = true;

        }

        private void Mult_Click(object sender, EventArgs e)
        {
            if (Display.Text.EndsWith(",") ||
                Display.Text.EndsWith("+") || Display.Text.EndsWith("-") ||
                Display.Text.EndsWith("*") || Display.Text.EndsWith("/") || Display.Text == float.PositiveInfinity.ToString()
                )
                return;
            if (operation_flag)
                Calculate();
            dot_flag = false;
            Display.Text += "*";
            operation_flag = true;

        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (Display.Text.EndsWith(",") ||
                Display.Text.EndsWith("+") || Display.Text.EndsWith("-") ||
                Display.Text.EndsWith("*") || Display.Text.EndsWith("/") || Display.Text == float.PositiveInfinity.ToString()
                )
                return;
            if (operation_flag)
                Calculate();
            dot_flag = false;
            Display.Text += "/";
            operation_flag = true;

        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (dot_flag ||
                Display.Text.EndsWith("+") || Display.Text.EndsWith("-") ||
                Display.Text.EndsWith("*") || Display.Text.EndsWith("/") || Display.Text == float.PositiveInfinity.ToString()
                )
                return;
            Display.Text += ",";
            dot_flag = true;
        }

        private void Eq_Click(object sender, EventArgs e)
        {
            dot_flag = false;
            operation_flag = false;
            Calculate();
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            dot_flag = false;
            operation_flag = false;
        }

        private void Calculate()
        {
            var reg = Regex.Match(Display.Text, @"(-?\d+(,\d+)?)[-+*/]");
            if (!reg.Success)
                return;
            var fir = reg.Value;
            var op = fir.Last();
            var y = float.Parse(Display.Text.Substring(fir.Length));
            fir = fir.Substring(0, fir.Length - 1);
            var x = float.Parse(fir);
            switch (op)
            {
                case '+':
                    Display.Text = (x + y).ToString();
                    break;
                case '-':
                    Display.Text = (x - y).ToString();
                    break;
                case '*':
                    Display.Text = (x * y).ToString();
                    break;
                case '/':
                    Display.Text = (x / y).ToString();
                    break;
            }
            if (Display.Text.Contains('E'))
                Display.Text = float.PositiveInfinity.ToString();
            if (Display.Text.Contains(','))
                dot_flag = true;
            Clipboard.SetText(Display.Text);
        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                add_symbol(e.KeyChar - 48);
            if (e.KeyChar == '/')
                Div_Click(sender, e);
            if (e.KeyChar == '.')
                Dot_Click(sender, e);
            if (e.KeyChar == '*')
                Mult_Click(sender, e);
            if (e.KeyChar == '-')
                Sub_Click(sender, e);
            if (e.KeyChar == '+')
                Add_Click(sender, e);
            if (e.KeyChar == (char)Keys.Enter)
                Eq_Click(sender, e);
        }
    }
}