﻿namespace eggsinteractive
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
            this.txtEntry4 = new System.Windows.Forms.TextBox();
            this.txtEntry1 = new System.Windows.Forms.TextBox();
            this.txtEntry5 = new System.Windows.Forms.TextBox();
            this.txtEntry3 = new System.Windows.Forms.TextBox();
            this.txtEntry2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntry4
            // 
            this.txtEntry4.Location = new System.Drawing.Point(125, 132);
            this.txtEntry4.Name = "txtEntry4";
            this.txtEntry4.Size = new System.Drawing.Size(51, 20);
            this.txtEntry4.TabIndex = 0;
            // 
            // txtEntry1
            // 
            this.txtEntry1.Location = new System.Drawing.Point(125, 81);
            this.txtEntry1.Name = "txtEntry1";
            this.txtEntry1.Size = new System.Drawing.Size(51, 20);
            this.txtEntry1.TabIndex = 1;
            // 
            // txtEntry5
            // 
            this.txtEntry5.Location = new System.Drawing.Point(202, 132);
            this.txtEntry5.Name = "txtEntry5";
            this.txtEntry5.Size = new System.Drawing.Size(51, 20);
            this.txtEntry5.TabIndex = 2;
            // 
            // txtEntry3
            // 
            this.txtEntry3.Location = new System.Drawing.Point(283, 81);
            this.txtEntry3.Name = "txtEntry3";
            this.txtEntry3.Size = new System.Drawing.Size(51, 20);
            this.txtEntry3.TabIndex = 3;
            // 
            // txtEntry2
            // 
            this.txtEntry2.Location = new System.Drawing.Point(202, 81);
            this.txtEntry2.Name = "txtEntry2";
            this.txtEntry2.Size = new System.Drawing.Size(51, 20);
            this.txtEntry2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter eggs produced each by each of 5 chickens";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(146, 190);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(156, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Click to calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(167, 248);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(186, 23);
            this.lblResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 470);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEntry2);
            this.Controls.Add(this.txtEntry3);
            this.Controls.Add(this.txtEntry5);
            this.Controls.Add(this.txtEntry1);
            this.Controls.Add(this.txtEntry4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntry4;
        private System.Windows.Forms.TextBox txtEntry1;
        private System.Windows.Forms.TextBox txtEntry5;
        private System.Windows.Forms.TextBox txtEntry3;
        private System.Windows.Forms.TextBox txtEntry2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}

