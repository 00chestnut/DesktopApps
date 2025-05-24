namespace HoverTime
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hoverBtn = new Button();
            timing = new TextBox();
            SuspendLayout();
            // 
            // hoverBtn
            // 
            hoverBtn.Location = new Point(175, 331);
            hoverBtn.Name = "hoverBtn";
            hoverBtn.Size = new Size(445, 101);
            hoverBtn.TabIndex = 0;
            hoverBtn.Text = "Hover over me :)";
            hoverBtn.UseVisualStyleBackColor = true;
            hoverBtn.MouseEnter += hoverBtn_MouseEnter;
            hoverBtn.MouseLeave += hoverBtn_MouseLeave;
            // 
            // timing
            // 
            timing.BackColor = Color.CornflowerBlue;
            timing.Location = new Point(154, 74);
            timing.Multiline = true;
            timing.Name = "timing";
            timing.ReadOnly = true;
            timing.Size = new Size(507, 129);
            timing.TabIndex = 1;
            timing.Text = "Hover time : ";
            timing.TextChanged += timing_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 538);
            Controls.Add(timing);
            Controls.Add(hoverBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hoverBtn;
        private TextBox timing;
    }
}
