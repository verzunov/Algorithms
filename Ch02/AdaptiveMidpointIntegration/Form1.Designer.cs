﻿namespace AdaptiveMidpointIntegration
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
            this.maxSliceErrorTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numIntervalsTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pctErrorTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.trueAreaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.estAreaTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.intervalsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.integrateButton = new System.Windows.Forms.Button();
            this.xMaxTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xMinTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // maxSliceErrorTextBox
            // 
            this.maxSliceErrorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.maxSliceErrorTextBox.Location = new System.Drawing.Point(206, 274);
            this.maxSliceErrorTextBox.Name = "maxSliceErrorTextBox";
            this.maxSliceErrorTextBox.Size = new System.Drawing.Size(34, 20);
            this.maxSliceErrorTextBox.TabIndex = 88;
            this.maxSliceErrorTextBox.Text = "1%";
            this.maxSliceErrorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 105;
            this.label10.Text = "Max Slice Error:";
            // 
            // numIntervalsTextBox
            // 
            this.numIntervalsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numIntervalsTextBox.Location = new System.Drawing.Point(115, 384);
            this.numIntervalsTextBox.Name = "numIntervalsTextBox";
            this.numIntervalsTextBox.ReadOnly = true;
            this.numIntervalsTextBox.Size = new System.Drawing.Size(75, 20);
            this.numIntervalsTextBox.TabIndex = 92;
            this.numIntervalsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 104;
            this.label11.Text = "# Intervals:";
            // 
            // pctErrorTextBox
            // 
            this.pctErrorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pctErrorTextBox.Location = new System.Drawing.Point(251, 344);
            this.pctErrorTextBox.Name = "pctErrorTextBox";
            this.pctErrorTextBox.ReadOnly = true;
            this.pctErrorTextBox.Size = new System.Drawing.Size(59, 20);
            this.pctErrorTextBox.TabIndex = 93;
            this.pctErrorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 103;
            this.label9.Text = "% Err:";
            // 
            // trueAreaTextBox
            // 
            this.trueAreaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trueAreaTextBox.Location = new System.Drawing.Point(116, 358);
            this.trueAreaTextBox.Name = "trueAreaTextBox";
            this.trueAreaTextBox.ReadOnly = true;
            this.trueAreaTextBox.Size = new System.Drawing.Size(75, 20);
            this.trueAreaTextBox.TabIndex = 91;
            this.trueAreaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "True Area:";
            // 
            // estAreaTextBox
            // 
            this.estAreaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.estAreaTextBox.Location = new System.Drawing.Point(115, 332);
            this.estAreaTextBox.Name = "estAreaTextBox";
            this.estAreaTextBox.ReadOnly = true;
            this.estAreaTextBox.Size = new System.Drawing.Size(75, 20);
            this.estAreaTextBox.TabIndex = 90;
            this.estAreaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "Est. Area:";
            // 
            // intervalsTextBox
            // 
            this.intervalsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.intervalsTextBox.Location = new System.Drawing.Point(206, 248);
            this.intervalsTextBox.Name = "intervalsTextBox";
            this.intervalsTextBox.Size = new System.Drawing.Size(34, 20);
            this.intervalsTextBox.TabIndex = 87;
            this.intervalsTextBox.Text = "5";
            this.intervalsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 100;
            this.label6.Text = "Initial Intervals:";
            // 
            // integrateButton
            // 
            this.integrateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.integrateButton.Location = new System.Drawing.Point(148, 303);
            this.integrateButton.Name = "integrateButton";
            this.integrateButton.Size = new System.Drawing.Size(75, 23);
            this.integrateButton.TabIndex = 89;
            this.integrateButton.Text = "Integrate";
            this.integrateButton.UseVisualStyleBackColor = true;
            this.integrateButton.Click += new System.EventHandler(this.integrateButton_Click);
            // 
            // xMaxTextBox
            // 
            this.xMaxTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xMaxTextBox.Location = new System.Drawing.Point(206, 222);
            this.xMaxTextBox.Name = "xMaxTextBox";
            this.xMaxTextBox.Size = new System.Drawing.Size(34, 20);
            this.xMaxTextBox.TabIndex = 84;
            this.xMaxTextBox.Text = "5";
            this.xMaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "to";
            // 
            // xMinTextBox
            // 
            this.xMinTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xMinTextBox.Location = new System.Drawing.Point(147, 222);
            this.xMinTextBox.Name = "xMinTextBox";
            this.xMinTextBox.Size = new System.Drawing.Size(34, 20);
            this.xMinTextBox.TabIndex = 83;
            this.xMinTextBox.Text = "0";
            this.xMinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "y = 1 + x + Sin(2 * x)";
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphPictureBox.Location = new System.Drawing.Point(14, 27);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(337, 189);
            this.graphPictureBox.TabIndex = 94;
            this.graphPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.integrateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 415);
            this.Controls.Add(this.maxSliceErrorTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numIntervalsTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pctErrorTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trueAreaTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.estAreaTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.intervalsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.integrateButton);
            this.Controls.Add(this.xMaxTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xMinTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graphPictureBox);
            this.Name = "Form1";
            this.Text = "AdaptiveMidpointIntegration";
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxSliceErrorTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox numIntervalsTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pctErrorTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox trueAreaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox estAreaTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox intervalsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button integrateButton;
        private System.Windows.Forms.TextBox xMaxTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xMinTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox graphPictureBox;
    }
}

