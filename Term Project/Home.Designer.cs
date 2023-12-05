namespace Term_Project
{
    partial class Home
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label13 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 12);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 1;
            button1.Text = "John Smith";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(42, 52);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 2;
            button2.Text = "Amy Johnson";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(42, 93);
            button3.Name = "button3";
            button3.Size = new Size(105, 23);
            button3.TabIndex = 3;
            button3.Text = "Elijah James";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label13);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 75);
            panel1.TabIndex = 38;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(317, 32);
            label13.Name = "label13";
            label13.Size = new Size(148, 43);
            label13.TabIndex = 15;
            label13.Text = "Home";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(355, 124);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 39;
            label1.Text = "Patient List";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(290, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 197);
            panel2.TabIndex = 39;
            // 
            // button4
            // 
            button4.Location = new Point(42, 140);
            button4.Name = "button4";
            button4.Size = new Size(105, 23);
            button4.TabIndex = 4;
            button4.Text = "Jane Smith";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(242, 391);
            button5.Name = "button5";
            button5.Size = new Size(139, 23);
            button5.TabIndex = 5;
            button5.Text = "Sim Team Actions";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(403, 391);
            button6.Name = "button6";
            button6.Size = new Size(139, 23);
            button6.TabIndex = 40;
            button6.Text = "Log Out";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Label label13;
        private Label label1;
        private Panel panel2;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}