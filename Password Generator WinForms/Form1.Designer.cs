namespace Password_Generator_WinForms
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
            System.Windows.Forms.CheckBox BigLetters;
            this.StartButton = new System.Windows.Forms.Button();
            this.Punctuation = new System.Windows.Forms.CheckBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.LenghtBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.SmallLetters = new System.Windows.Forms.CheckBox();
            this.Numbers = new System.Windows.Forms.CheckBox();
            BigLetters = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BigLetters
            // 
            BigLetters.AutoSize = true;
            BigLetters.Cursor = System.Windows.Forms.Cursors.Hand;
            BigLetters.Location = new System.Drawing.Point(12, 305);
            BigLetters.Name = "BigLetters";
            BigLetters.Size = new System.Drawing.Size(78, 19);
            BigLetters.TabIndex = 0;
            BigLetters.Text = "Big letters";
            BigLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            BigLetters.UseVisualStyleBackColor = true;
            BigLetters.CheckedChanged += new System.EventHandler(this.BigLetters_CheckedChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 381);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(224, 57);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "button1";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Punctuation
            // 
            this.Punctuation.AutoSize = true;
            this.Punctuation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Punctuation.Location = new System.Drawing.Point(12, 280);
            this.Punctuation.Name = "Punctuation";
            this.Punctuation.Size = new System.Drawing.Size(91, 19);
            this.Punctuation.TabIndex = 1;
            this.Punctuation.Text = "Punctuation";
            this.Punctuation.UseVisualStyleBackColor = true;
            this.Punctuation.CheckedChanged += new System.EventHandler(this.Punctuation_CheckedChanged);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(361, 0);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(439, 454);
            this.OutputTextBox.TabIndex = 3;
            this.OutputTextBox.Text = "";
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(12, 42);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(214, 23);
            this.AmountBox.TabIndex = 4;
            this.AmountBox.TextChanged += new System.EventHandler(this.AmountBox_TextChanged);
            // 
            // LenghtBox
            // 
            this.LenghtBox.Location = new System.Drawing.Point(12, 95);
            this.LenghtBox.Name = "LenghtBox";
            this.LenghtBox.Size = new System.Drawing.Size(214, 23);
            this.LenghtBox.TabIndex = 5;
            this.LenghtBox.TextChanged += new System.EventHandler(this.LengthBox_TextChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(12, 24);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(167, 15);
            this.AmountLabel.TabIndex = 6;
            this.AmountLabel.Text = "Enter an amount of passwords";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(12, 77);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(155, 15);
            this.LengthLabel.TabIndex = 7;
            this.LengthLabel.Text = "Enter a length of passwords.";
            // 
            // SmallLetters
            // 
            this.SmallLetters.AutoSize = true;
            this.SmallLetters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SmallLetters.Location = new System.Drawing.Point(12, 330);
            this.SmallLetters.Name = "SmallLetters";
            this.SmallLetters.Size = new System.Drawing.Size(90, 19);
            this.SmallLetters.TabIndex = 8;
            this.SmallLetters.Text = "Small letters";
            this.SmallLetters.UseVisualStyleBackColor = true;
            this.SmallLetters.CheckedChanged += new System.EventHandler(this.SmallLetters_CheckedChanged);
            // 
            // Numbers
            // 
            this.Numbers.AutoSize = true;
            this.Numbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Numbers.Location = new System.Drawing.Point(11, 255);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(75, 19);
            this.Numbers.TabIndex = 9;
            this.Numbers.Text = "Numbers";
            this.Numbers.UseVisualStyleBackColor = true;
            this.Numbers.CheckedChanged += new System.EventHandler(this.Numbers_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.SmallLetters);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.LenghtBox);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Punctuation);
            this.Controls.Add(BigLetters);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Cryptographic Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartButton;
        private CheckBox Punctuation;
        private RichTextBox OutputTextBox;
        private TextBox AmountBox;
        private TextBox LenghtBox;
        private Label AmountLabel;
        private Label LengthLabel;
        private CheckBox SmallLetters;
        private CheckBox Numbers;
    }
}