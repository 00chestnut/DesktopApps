using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace HoverTime
{
    public partial class Form1 : Form
    {
        private Stopwatch hoverTimer = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hoverBtn_MouseEnter(object sender, EventArgs e)
        {
            hoverTimer.Restart();
        }

        private void hoverBtn_MouseLeave(object sender, EventArgs e)
        {
            hoverTimer.Stop();
            timing.Text = $"Hovered: {hoverTimer.ElapsedMilliseconds} ms    /    {hoverTimer.ElapsedMilliseconds / 1000} s";
            label1.Text = $"Hovered: {++labelcounter} times";
        }

        private void timing_TextChanged(object sender, EventArgs e)
        {
        }

        private void hoverBtn_Click(object sender, EventArgs e)
        {

        }

        int clicks = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = $"Clicked: {++clicks} times";
        }
        int labelcounter = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
