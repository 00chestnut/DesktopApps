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

            // Optional: attach handlers if not using Designer
            // hoverBtn.MouseEnter += hoverBtn_MouseEnter;
            // hoverBtn.MouseLeave += hoverBtn_MouseLeave;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hoverBtn_MouseEnter(object sender, EventArgs e)
        {
            hoverTimer.Restart(); // This starts and resets the timer
        }

        private void hoverBtn_MouseLeave(object sender, EventArgs e)
        {
            hoverTimer.Stop();
            timing.Text = $"Hovered: {hoverTimer.ElapsedMilliseconds} ms";
        }

        private void timing_TextChanged(object sender, EventArgs e)
        {
            // Optional
        }
    }
}
