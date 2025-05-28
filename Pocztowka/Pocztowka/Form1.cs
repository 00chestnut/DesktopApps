using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocztowka
{
    public partial class Poczta : Form
    {
        public Poczta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text.Length !=5)
            {
                MessageBox.Show("Kod pocztowy ma zawierać 5 znaków" +".");
                return;
            }
            MessageBox.Show("Wysłano pocztówkę do " + textBox2.Text + " na kod pocztowy: " + textBox3.Text + " do miasta " + textBox5.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Cena: 1.00 zł";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "Cena: 1,50 zł";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "Cena: 10,00 zł";
            }
            // cena 
        }
    }
}
