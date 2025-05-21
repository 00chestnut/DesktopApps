using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Calculator : Form
    {
        string operation = string.Empty; // Store the operation

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        // Digit Buttons
        private void button1_Click(object sender, EventArgs e) // 1
        {
            operation += "1";
            textBox1.Text = operation;
        }

        private void button2_Click(object sender, EventArgs e) // 2
        {
            operation += "2";
            textBox1.Text = operation;
        }

        private void button3_Click(object sender, EventArgs e) // 3
        {
            operation += "3";
            textBox1.Text = operation;
        }

        private void button4_Click(object sender, EventArgs e) // 4
        {
            operation += "4";
            textBox1.Text = operation;
        }

        private void button5_Click(object sender, EventArgs e) // 5
        {
            operation += "5";
            textBox1.Text = operation;
        }

        private void button6_Click(object sender, EventArgs e) // 6
        {
            operation += "6";
            textBox1.Text = operation;
        }

        private void button7_Click(object sender, EventArgs e) // 7
        {
            operation += "7";
            textBox1.Text = operation;
        }

        private void button8_Click(object sender, EventArgs e) // 8
        {
            operation += "8";
            textBox1.Text = operation;
        }

        private void button9_Click(object sender, EventArgs e) // 9
        {
            operation += "9";
            textBox1.Text = operation;
        }

        private void button0_Click(object sender, EventArgs e) // 0
        {
            operation += "0";
            textBox1.Text = operation;
        }

        // Operators
        private void btnClear_Click(object sender, EventArgs e)
        {
            operation = string.Empty; // Clear the operation
            textBox1.Text = operation;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation += "/";
            textBox1.Text = operation;
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                var expression = operation.Split('=')[0];
                var result = table.Compute(expression, null);
                operation = expression + "=" + result.ToString();
                textBox1.Text = operation;
            }
            catch (Exception)
            {
                textBox1.Text = "Error";
                operation = "";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operation += "*";
            textBox1.Text = operation;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (operation.Length > 0)
            {
                operation = operation.Remove(operation.Length - 1);
                textBox1.Text = operation;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {   operation += "-";
            textBox1.Text = operation;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation += "+";
            textBox1.Text = operation;
        }
    }
}
