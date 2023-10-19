namespace Term_Project
{
    partial class Education
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(571, 373);
            button7.Name = "button7";
            button7.Size = new Size(73, 23);
            button7.TabIndex = 34;
            button7.Text = "Order";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(500, 374);
            button6.Name = "button6";
            button6.Size = new Size(73, 23);
            button6.TabIndex = 33;
            button6.Text = "Notes";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(431, 374);
            button5.Name = "button5";
            button5.Size = new Size(73, 23);
            button5.TabIndex = 32;
            button5.Text = "FlowSheets";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(214, 373);
            button4.Name = "button4";
            button4.Size = new Size(73, 23);
            button4.TabIndex = 31;
            button4.Text = "Summary";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(293, 374);
            button3.Name = "button3";
            button3.Size = new Size(73, 23);
            button3.TabIndex = 30;
            button3.Text = "MAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(363, 374);
            button2.Name = "button2";
            button2.Size = new Size(73, 23);
            button2.TabIndex = 29;
            button2.Text = "Reports";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(150, 374);
            button1.Name = "button1";
            button1.Size = new Size(73, 22);
            button1.TabIndex = 28;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Education
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Education";
            Text = "Education";
            Load += Education_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}