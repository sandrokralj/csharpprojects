namespace MessagingClient
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
            this.btLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLoginStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btGetListOfUsers = new System.Windows.Forms.Button();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPublicMessage = new System.Windows.Forms.TextBox();
            this.btPostPublic = new System.Windows.Forms.Button();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.groupBoxSendPrivateMessage = new System.Windows.Forms.GroupBox();
            this.tbPrivateMessage = new System.Windows.Forms.TextBox();
            this.btSendPrivate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxSendPrivateMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(97, 55);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(91, 28);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLoginStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btLogin);
            this.groupBox1.Controls.Add(this.tbUserName);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(201, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login box";
            // 
            // labelLoginStatus
            // 
            this.labelLoginStatus.AutoSize = true;
            this.labelLoginStatus.Location = new System.Drawing.Point(73, 106);
            this.labelLoginStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginStatus.Name = "labelLoginStatus";
            this.labelLoginStatus.Size = new System.Drawing.Size(113, 17);
            this.labelLoginStatus.TabIndex = 4;
            this.labelLoginStatus.Text = "labelLoginStatus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(97, 23);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(92, 22);
            this.tbUserName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btGetListOfUsers);
            this.groupBox2.Controls.Add(this.lbUsers);
            this.groupBox2.Location = new System.Drawing.Point(16, 159);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(201, 178);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users";
            // 
            // btGetListOfUsers
            // 
            this.btGetListOfUsers.Location = new System.Drawing.Point(8, 23);
            this.btGetListOfUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGetListOfUsers.Name = "btGetListOfUsers";
            this.btGetListOfUsers.Size = new System.Drawing.Size(143, 28);
            this.btGetListOfUsers.TabIndex = 2;
            this.btGetListOfUsers.Text = "Get list of users";
            this.btGetListOfUsers.UseVisualStyleBackColor = true;
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 16;
            this.lbUsers.Location = new System.Drawing.Point(12, 59);
            this.lbUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(177, 100);
            this.lbUsers.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbPublicMessage);
            this.groupBox3.Controls.Add(this.btPostPublic);
            this.groupBox3.Controls.Add(this.lbMessages);
            this.groupBox3.Location = new System.Drawing.Point(225, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(329, 431);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Post a message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 361);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "New message:";
            // 
            // tbPublicMessage
            // 
            this.tbPublicMessage.Location = new System.Drawing.Point(119, 357);
            this.tbPublicMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPublicMessage.Name = "tbPublicMessage";
            this.tbPublicMessage.Size = new System.Drawing.Size(193, 22);
            this.tbPublicMessage.TabIndex = 6;
            // 
            // btPostPublic
            // 
            this.btPostPublic.Location = new System.Drawing.Point(213, 389);
            this.btPostPublic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPostPublic.Name = "btPostPublic";
            this.btPostPublic.Size = new System.Drawing.Size(100, 28);
            this.btPostPublic.TabIndex = 7;
            this.btPostPublic.Text = "Post";
            this.btPostPublic.UseVisualStyleBackColor = true;
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.ItemHeight = 16;
            this.lbMessages.Location = new System.Drawing.Point(8, 23);
            this.lbMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(304, 308);
            this.lbMessages.TabIndex = 6;
            this.lbMessages.TabStop = false;
            // 
            // groupBoxSendPrivateMessage
            // 
            this.groupBoxSendPrivateMessage.Controls.Add(this.tbPrivateMessage);
            this.groupBoxSendPrivateMessage.Controls.Add(this.btSendPrivate);
            this.groupBoxSendPrivateMessage.Location = new System.Drawing.Point(16, 345);
            this.groupBoxSendPrivateMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSendPrivateMessage.Name = "groupBoxSendPrivateMessage";
            this.groupBoxSendPrivateMessage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSendPrivateMessage.Size = new System.Drawing.Size(201, 101);
            this.groupBoxSendPrivateMessage.TabIndex = 5;
            this.groupBoxSendPrivateMessage.TabStop = false;
            this.groupBoxSendPrivateMessage.Text = "Send private message";
            // 
            // tbPrivateMessage
            // 
            this.tbPrivateMessage.Location = new System.Drawing.Point(12, 27);
            this.tbPrivateMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrivateMessage.Name = "tbPrivateMessage";
            this.tbPrivateMessage.Size = new System.Drawing.Size(177, 22);
            this.tbPrivateMessage.TabIndex = 4;
            // 
            // btSendPrivate
            // 
            this.btSendPrivate.Location = new System.Drawing.Point(88, 59);
            this.btSendPrivate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSendPrivate.Name = "btSendPrivate";
            this.btSendPrivate.Size = new System.Drawing.Size(100, 28);
            this.btSendPrivate.TabIndex = 5;
            this.btSendPrivate.Text = "Send";
            this.btSendPrivate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 458);
            this.Controls.Add(this.groupBoxSendPrivateMessage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Messaging client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxSendPrivateMessage.ResumeLayout(false);
            this.groupBoxSendPrivateMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btGetListOfUsers;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPublicMessage;
        private System.Windows.Forms.Button btPostPublic;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.Label labelLoginStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.GroupBox groupBoxSendPrivateMessage;
        private System.Windows.Forms.TextBox tbPrivateMessage;
        private System.Windows.Forms.Button btSendPrivate;
    }
}

