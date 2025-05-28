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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // hoverBtn
            // 
            hoverBtn.BackColor = SystemColors.ActiveCaption;
            hoverBtn.Font = new Font("Rockwell Nova Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hoverBtn.Location = new Point(235, 141);
            hoverBtn.Margin = new Padding(4, 5, 4, 5);
            hoverBtn.Name = "hoverBtn";
            hoverBtn.Size = new Size(172, 168);
            hoverBtn.TabIndex = 0;
            hoverBtn.Text = "Hover over me :)";
            hoverBtn.UseVisualStyleBackColor = false;
            hoverBtn.Click += hoverBtn_Click;
            hoverBtn.MouseEnter += hoverBtn_MouseEnter;
            hoverBtn.MouseLeave += hoverBtn_MouseLeave;
            // 
            // timing
            // 
            timing.BackColor = Color.CornflowerBlue;
            timing.BorderStyle = BorderStyle.FixedSingle;
            timing.CausesValidation = false;
            timing.Font = new Font("Showcard Gothic", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timing.Location = new Point(-2, -2);
            timing.Margin = new Padding(4, 5, 4, 5);
            timing.Multiline = true;
            timing.Name = "timing";
            timing.ReadOnly = true;
            timing.Size = new Size(663, 91);
            timing.TabIndex = 1;
            timing.Text = "Hover time : ";
            timing.TextChanged += timing_TextChanged;
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.Location = new Point(12, 97);
            button1.Name = "button1";
            button1.Size = new Size(218, 42);
            button1.TabIndex = 2;
            button1.Text = "Click me ";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 314);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 3;
            label1.Text = "Hovered: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Cursor = Cursors.IBeam;
            label2.Font = new Font("Snap ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(109, 26);
            label2.TabIndex = 4;
            label2.Text = "Clicked: ";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(657, 424);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(timing);
            Controls.Add(hoverBtn);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Tag = "Hover Time Meter";
            Text = "Hover Time Meter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hoverBtn;
        private TextBox timing;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
