﻿namespace CaesarSubstitution
{
    partial class Form1
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
            this.plaintextTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.ciphertextTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.shiftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // plaintextTextBox
            // 
            this.plaintextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plaintextTextBox.Location = new System.Drawing.Point(75, 150);
            this.plaintextTextBox.Name = "plaintextTextBox";
            this.plaintextTextBox.Size = new System.Drawing.Size(197, 20);
            this.plaintextTextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Plaintext:";
            // 
            // decryptButton
            // 
            this.decryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.decryptButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.decryptButton.Location = new System.Drawing.Point(105, 121);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 26;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // ciphertextTextBox
            // 
            this.ciphertextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ciphertextTextBox.Location = new System.Drawing.Point(75, 93);
            this.ciphertextTextBox.Name = "ciphertextTextBox";
            this.ciphertextTextBox.Size = new System.Drawing.Size(197, 20);
            this.ciphertextTextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ciphertext:";
            // 
            // encryptButton
            // 
            this.encryptButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.encryptButton.Location = new System.Drawing.Point(105, 64);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 23;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // shiftNumericUpDown
            // 
            this.shiftNumericUpDown.Location = new System.Drawing.Point(75, 38);
            this.shiftNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.shiftNumericUpDown.Name = "shiftNumericUpDown";
            this.shiftNumericUpDown.Size = new System.Drawing.Size(43, 20);
            this.shiftNumericUpDown.TabIndex = 22;
            this.shiftNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Shift:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Location = new System.Drawing.Point(75, 12);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(197, 20);
            this.messageTextBox.TabIndex = 20;
            this.messageTextBox.Text = "THIS IS A SECRET MESSAGE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Plaintext:";
            // 
            // Form1
            // 
            this.AcceptButton = this.encryptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.decryptButton;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.plaintextTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.ciphertextTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.shiftNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CaesarSubstitution";
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plaintextTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox ciphertextTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.NumericUpDown shiftNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label1;
    }
}

