﻿namespace admin_client
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbOffers = new System.Windows.Forms.ListBox();
            this.btnGetOffers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(172, 31);
            this.tbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(234, 31);
            this.tbName.TabIndex = 1;
            // 
            // lbOffers
            // 
            this.lbOffers.FormattingEnabled = true;
            this.lbOffers.ItemHeight = 25;
            this.lbOffers.Location = new System.Drawing.Point(24, 146);
            this.lbOffers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbOffers.Name = "lbOffers";
            this.lbOffers.Size = new System.Drawing.Size(382, 329);
            this.lbOffers.TabIndex = 2;
            // 
            // btnGetOffers
            // 
            this.btnGetOffers.Location = new System.Drawing.Point(24, 90);
            this.btnGetOffers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGetOffers.Name = "btnGetOffers";
            this.btnGetOffers.Size = new System.Drawing.Size(386, 44);
            this.btnGetOffers.TabIndex = 3;
            this.btnGetOffers.Text = "get offers";
            this.btnGetOffers.UseVisualStyleBackColor = true;
            this.btnGetOffers.Click += new System.EventHandler(this.btnGetOffers_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 504);
            this.Controls.Add(this.btnGetOffers);
            this.Controls.Add(this.lbOffers);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdminForm";
            this.Text = "Admin Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListBox lbOffers;
        private System.Windows.Forms.Button btnGetOffers;
    }
}

