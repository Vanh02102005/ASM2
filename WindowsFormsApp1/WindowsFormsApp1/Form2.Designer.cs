﻿namespace WindowsFormsApp1
{
    partial class Form2
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
            this.lbTypes = new System.Windows.Forms.Label();
            this.lbBill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTypes
            // 
            this.lbTypes.AutoSize = true;
            this.lbTypes.Location = new System.Drawing.Point(150, 186);
            this.lbTypes.Name = "lbTypes";
            this.lbTypes.Size = new System.Drawing.Size(0, 16);
            this.lbTypes.TabIndex = 2;
            // 
            // lbBill
            // 
            this.lbBill.AutoSize = true;
            this.lbBill.Location = new System.Drawing.Point(150, 186);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(25, 16);
            this.lbBill.TabIndex = 3;
            this.lbBill.Text = "Bill";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBill);
            this.Controls.Add(this.lbTypes);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTypes;
        private System.Windows.Forms.Label lbBill;
    }
}