﻿namespace NumberFrequency
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
            NumberTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(105, 75);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(149, 23);
            NumberTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(135, 123);
            button1.Name = "button1";
            button1.Size = new Size(93, 36);
            button1.TabIndex = 1;
            button1.Text = "出現次數";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 233);
            Controls.Add(button1);
            Controls.Add(NumberTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NumberTextBox;
        private Button button1;
    }
}
