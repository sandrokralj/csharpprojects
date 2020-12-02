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
            this.btnNrOffers.Location = new System.Drawing.Point(15, 36);
            this.btnNrOffers.Name = "btnNrOffers";
            this.btnNrOffers.Size = new System.Drawing.Size(109, 23);
            this.btnNrOffers.TabIndex = 0;
            this.btnNrOffers.Text = "Get asking price";
            this.btnNrOffers.UseVisualStyleBackColor = true;
            this.btnNrOffers.Click += new System.EventHandler(this.btnNrOffers_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(81, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "tbName";
            // 
            // rtbMessages
            // 
            this.rtbMessages.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.rtbMessages.Location = new System.Drawing.Point(336, 25);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(163, 258);
            this.rtbMessages.TabIndex = 2;
            this.rtbMessages.Text = "rtbMessages";
            // 
            // lbAvailable
            // 
            this.lbAvailable.DisplayMember = "Address";
            this.lbAvailable.FormattingEnabled = true;
            this.lbAvailable.Location = new System.Drawing.Point(12, 29);
            this.lbAvailable.Name = "lbAvailable";
            this.lbAvailable.Size = new System.Drawing.Size(127, 121);
            this.lbAvailable.TabIndex = 4;
            this.lbAvailable.SelectedIndexChanged += new System.EventHandler(this.lbAvailable_SelectedIndexChanged);
            // 
            // btnMakeOffer
            // 
            this.btnMakeOffer.AutoEllipsis = true;
            this.btnMakeOffer.Location = new System.Drawing.Point(155, 71);
            this.btnMakeOffer.Name = "btnMakeOffer";
            this.btnMakeOffer.Size = new System.Drawing.Size(149, 23);
            this.btnMakeOffer.TabIndex = 7;
            this.btnMakeOffer.Text = "offer for ...";
            this.btnMakeOffer.UseVisualStyleBackColor = true;
            this.btnMakeOffer.Click += new System.EventHandler(this.btnMakeOffer_Click);
            // 
            // tbOffer
            // 
            this.tbOffer.Location = new System.Drawing.Point(174, 45);
            this.tbOffer.Name = "tbOffer";
            this.tbOffer.Size = new System.Drawing.Size(100, 20);
            this.tbOffer.TabIndex = 8;
            this.tbOffer.Text = "tbOffer";
            // 
            // btnGetAvailable
            // 
            this.btnGetAvailable.Location = new System.Drawing.Point(12, 156);
            this.btnGetAvailable.Name = "btnGetAvailable";
            this.btnGetAvailable.Size = new System.Drawing.Size(127, 23);
            this.btnGetAvailable.TabIndex = 3;
            this.btnGetAvailable.Text = "get available";
            this.btnGetAvailable.UseVisualStyleBackColor = true;
            this.btnGetAvailable.Click += new System.EventHandler(this.btnGetAvailable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "available:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnNrOffers);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 70);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
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
            this.panel2.Location = new System.Drawing.Point(12, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 186);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "messages:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 296);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtbMessages);
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

