using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password
{
    public partial class Form1 : Form
    {
        string haslo = ""; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string maleLitery = "abcdefghijklmnopqrstuvwxyz";
            string wielkieLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cyfry = "0123456789";
            string znakiSpecjalne = "!@#$%^&*()_+-=";
            string dostepneZnaki = maleLitery;

            if (checkBox1.Checked)
                dostepneZnaki += wielkieLitery;

            if (checkBox2.Checked)
                dostepneZnaki += cyfry;

            if (checkBox3.Checked)
                dostepneZnaki += znakiSpecjalne;
            int dlugoscHasla = int.Parse(textBox3.Text);
            Random rand = new Random();

            for (int i = 0; i < dlugoscHasla; i++)
            {
                int indeks = rand.Next(dostepneZnaki.Length);
                haslo += dostepneZnaki[indeks]; 
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this
            string imie = textBox1.Text;
            string nazwisko = textBox2.Text;
            string stanowisko = comboBox1.Text;
            MessageBox.Show($"Imię: {imie}\nNazwisko: {nazwisko}\nStanowisko: {stanowisko} \nHasło: {haslo}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
