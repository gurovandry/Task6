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

namespace Task6
{
    public partial class Form1 : Form
    {
        private bool is_dot;
        private bool is_op;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_symbol(int symb)
        {
            if (output.Text == "0" || output.Text == float.PositiveInfinity.ToString())
                output.Text = "";
            output.Text += symb;
        }

        private void but0_Click(object sender, EventArgs e)
        {
            add_symbol(0);
        }

        private void but1_Click(object sender, EventArgs e)
        {
            add_symbol(1);
        }

        private void but2_Click(object sender, EventArgs e)
        {
            add_symbol(2);
        }

        private void but3_Click(object sender, EventArgs e)
        {
            add_symbol(3);
        }

        private void but4_Click(object sender, EventArgs e)
        {
            add_symbol(4);
        }

        private void but5_Click(object sender, EventArgs e)
        {
            add_symbol(5);
        }

        private void but6_Click(object sender, EventArgs e)
        {
            add_symbol(6);
        }

        private void but7_Click(object sender, EventArgs e)
        {
            add_symbol(7);
        }

        private void but8_Click(object sender, EventArgs e)
        {
            add_symbol(8);
        }

        private void but9_Click(object sender, EventArgs e)
        {
            add_symbol(9);
        }

        private void plus_but_Click(object sender, EventArgs e)
        {
            if (output.Text.EndsWith(",") ||
                output.Text.EndsWith("+") || output.Text.EndsWith("-") ||
                output.Text.EndsWith("*") || output.Text.EndsWith("/") || output.Text == float.PositiveInfinity.ToString()
                )
                return;
            if (is_op)
                Calculate();
            is_dot = false;
            output.Text += "+";
            is_op = true;

        }
        private void Calculate()
        {
            var reg = Regex.Match(output.Text, @"(-?\d+(,\d+)?)[-+*/]");
            if (!reg.Success)
                return;
            var fir = reg.Value;
            var op = fir.Last();
            var y = float.Parse(output.Text.Substring(fir.Length));
            fir = fir.Substring(0, fir.Length - 1);
            var x = float.Parse(fir);
            switch (op)
            {
                case '+':
                    output.Text = (x + y).ToString();
                    break;
                case '-':
                    output.Text = (x - y).ToString();
                    break;
                case '*':
                    output.Text = (x * y).ToString();
                    break;
                case '/':
                    output.Text = (x / y).ToString();
                    break;
            }
            if (output.Text.Contains('E'))
                output.Text = float.PositiveInfinity.ToString();
            if (output.Text.Contains(','))
                is_dot = true;
            Clipboard.SetText(output.Text);
        }

        private void min_but_Click(object sender, EventArgs e)
        {
            if (output.Text.EndsWith(",") ||
                output.Text.EndsWith("+") || output.Text.EndsWith("-") ||
                output.Text.EndsWith("*") || output.Text.EndsWith("/") || output.Text == float.PositiveInfinity.ToString()
                )
                return;
            if (is_op)
                Calculate();
            is_dot = false;
            output.Text += "-";
            is_op = true;
        }

        private void mult_but_Click(object sender, EventArgs e)
        {
            if (output.Text.EndsWith(",") ||
                output.Text.EndsWith("+") || output.Text.EndsWith("-") ||
                output.Text.EndsWith("*") || output.Text.EndsWith("/") || output.Text == float.PositiveInfinity.ToString()
                )
                return;
            if (is_op)
                Calculate();
            is_dot = false;
            output.Text += "*";
            is_op = true;
        }

        private void dev_but_Click(object sender, EventArgs e)
        {
            if (output.Text.EndsWith(",") ||
                output.Text.EndsWith("+") || output.Text.EndsWith("-") ||
                output.Text.EndsWith("*") || output.Text.EndsWith("/") || output.Text == float.PositiveInfinity.ToString()
                )
                return;
            if (is_op)
                Calculate();
            is_dot = false;
            output.Text += "/";
            is_op = true;
        }

        private void but_dot_Click(object sender, EventArgs e)
        {
            if (is_dot ||
                output.Text.EndsWith("+") || output.Text.EndsWith("-") ||
                output.Text.EndsWith("*") || output.Text.EndsWith("/") || output.Text == float.PositiveInfinity.ToString()
                )
                return;
            output.Text += ",";
            is_dot = true;
        }

        private void but_eq_Click(object sender, EventArgs e)
        {
            is_dot = false;
            is_op = false;
            Calculate();
        }

        private void ce_but_Click(object sender, EventArgs e)
        {
            output.Text = "0";
            is_dot = false;
            is_op = false;
        }

        

        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                add_symbol(e.KeyChar - 48);
            if (e.KeyChar == '/')
                dev_but_Click(sender, e);
            if (e.KeyChar == '.')
                but_dot_Click(sender, e);
            if (e.KeyChar == '*')
                mult_but_Click(sender, e);
            if (e.KeyChar == '-')
                min_but_Click(sender, e);
            if (e.KeyChar == '+')
                plus_but_Click(sender, e);
            if (e.KeyChar == (char)Keys.Enter)
                but_eq_Click(sender, e);
        }
    }

}
