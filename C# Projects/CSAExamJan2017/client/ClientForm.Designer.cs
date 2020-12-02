namespace RentClient
{
    partial class ClientForm
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
            this.btnNrOffers = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.lbAvailable = new System.Windows.Forms.ListBox();
            this.btnMakeOffer = new System.Windows.Forms.Button();
            this.tbOffer = new System.Windows.Forms.TextBox();
            this.btnGetAvailable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNrOffers
            // 
            this.btnNrOffers.Location = new System.Drawing.Point(30, 69);
            this.btnNrOffers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNrOffers.Name = "btnNrOffers";
            this.btnNrOffers.Size = new System.Drawing.Size(332, 44);
            this.btnNrOffers.TabIndex = 0;
            this.btnNrOffers.Text = "get number of offers";
            this.btnNrOffers.UseVisualStyleBackColor = true;
            this.btnNrOffers.Click += new System.EventHandler(this.btnNrOffers_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(162, 19);
            this.tbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(196, 31);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "tbName";
            // 
            // rtbMessages
            // 
            this.rtbMessages.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.rtbMessages.Location = new System.Drawing.Point(672, 48);
            this.rtbMessages.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(322, 492);
            this.rtbMessages.TabIndex = 2;
            this.rtbMessages.Text = "rtbMessages";
            // 
            // lbAvailable
            // 
            this.lbAvailable.FormattingEnabled = true;
            this.lbAvailable.ItemHeight = 25;
            this.lbAvailable.Location = new System.Drawing.Point(24, 56);
            this.lbAvailable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbAvailable.Name = "lbAvailable";
            this.lbAvailable.Size = new System.Drawing.Size(250, 229);
            this.lbAvailable.TabIndex = 4;
            this.lbAvailable.SelectedIndexChanged += new System.EventHandler(this.lbAvailable_SelectedIndexChanged);
            // 
            // btnMakeOffer
            // 
            this.btnMakeOffer.AutoEllipsis = true;
            this.btnMakeOffer.Location = new System.Drawing.Point(310, 137);
            this.btnMakeOffer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMakeOffer.Name = "btnMakeOffer";
            this.btnMakeOffer.Size = new System.Drawing.Size(298, 44);
            this.btnMakeOffer.TabIndex = 7;
            this.btnMakeOffer.Text = "offer for ...";
            this.btnMakeOffer.UseVisualStyleBackColor = true;
            this.btnMakeOffer.Click += new System.EventHandler(this.btnMakeOffer_Click);
            // 
            // tbOffer
            // 
            this.tbOffer.Location = new System.Drawing.Point(348, 87);
            this.tbOffer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbOffer.Name = "tbOffer";
            this.tbOffer.Size = new System.Drawing.Size(196, 31);
            this.tbOffer.TabIndex = 8;
            this.tbOffer.Text = "tbOffer";
            // 
            // btnGetAvailable
            // 
            this.btnGetAvailable.Location = new System.Drawing.Point(24, 300);
            this.btnGetAvailable.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGetAvailable.Name = "btnGetAvailable";
            this.btnGetAvailable.Size = new System.Drawing.Size(254, 44);
            this.btnGetAvailable.TabIndex = 3;
            this.btnGetAvailable.Text = "get available";
            this.btnGetAvailable.UseVisualStyleBackColor = true;
            this.btnGetAvailable.Click += new System.EventHandler(this.btnGetAvailable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "available:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnNrOffers);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 133);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "name:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbAvailable);
            this.panel2.Controls.Add(this.btnMakeOffer);
            this.panel2.Controls.Add(this.tbOffer);
            this.panel2.Controls.Add(this.btnGetAvailable);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 187);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 356);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "messages:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 569);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtbMessages);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ClientForm";
            this.Text = "Client From";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNrOffers;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.ListBox lbAvailable;
        private System.Windows.Forms.Button btnMakeOffer;
        private System.Windows.Forms.TextBox tbOffer;
        private System.Windows.Forms.Button btnGetAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

