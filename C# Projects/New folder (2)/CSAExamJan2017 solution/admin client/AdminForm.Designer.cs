namespace admin_client
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
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(86, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(119, 20);
            this.tbName.TabIndex = 1;
            // 
            // lbOffers
            // 
            this.lbOffers.FormattingEnabled = true;
            this.lbOffers.Location = new System.Drawing.Point(12, 76);
            this.lbOffers.Name = "lbOffers";
            this.lbOffers.Size = new System.Drawing.Size(193, 173);
            this.lbOffers.TabIndex = 2;
            // 
            // btnGetOffers
            // 
            this.btnGetOffers.Location = new System.Drawing.Point(12, 47);
            this.btnGetOffers.Name = "btnGetOffers";
            this.btnGetOffers.Size = new System.Drawing.Size(193, 23);
            this.btnGetOffers.TabIndex = 3;
            this.btnGetOffers.Text = "get offers";
            this.btnGetOffers.UseVisualStyleBackColor = true;
            this.btnGetOffers.Click += new System.EventHandler(this.btnGetOffers_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 262);
            this.Controls.Add(this.btnGetOffers);
            this.Controls.Add(this.lbOffers);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
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

