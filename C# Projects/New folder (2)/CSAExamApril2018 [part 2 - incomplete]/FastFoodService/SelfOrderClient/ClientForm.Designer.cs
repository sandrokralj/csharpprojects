﻿namespace SelfOrderClient
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
            this.btGetProducts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrderNo = new System.Windows.Forms.TextBox();
            this.btGetOrderNo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbPrice = new System.Windows.Forms.ListBox();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.tbOrderStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btMakeOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGetProducts
            // 
            this.btGetProducts.Location = new System.Drawing.Point(12, 37);
            this.btGetProducts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btGetProducts.Name = "btGetProducts";
            this.btGetProducts.Size = new System.Drawing.Size(160, 73);
            this.btGetProducts.TabIndex = 0;
            this.btGetProducts.Text = "Get available products";
            this.btGetProducts.UseVisualStyleBackColor = true;
            this.btGetProducts.Click += new System.EventHandler(this.btGetProducts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your order:";
            // 
            // tbOrderNo
            // 
            this.tbOrderNo.Location = new System.Drawing.Point(314, 54);
            this.tbOrderNo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbOrderNo.Name = "tbOrderNo";
            this.tbOrderNo.ReadOnly = true;
            this.tbOrderNo.Size = new System.Drawing.Size(258, 31);
            this.tbOrderNo.TabIndex = 7;
            this.tbOrderNo.WordWrap = false;
            // 
            // btGetOrderNo
            // 
            this.btGetOrderNo.Location = new System.Drawing.Point(12, 37);
            this.btGetOrderNo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btGetOrderNo.Name = "btGetOrderNo";
            this.btGetOrderNo.Size = new System.Drawing.Size(160, 71);
            this.btGetOrderNo.TabIndex = 8;
            this.btGetOrderNo.Text = "Get order number";
            this.btGetOrderNo.UseVisualStyleBackColor = true;
            this.btGetOrderNo.Click += new System.EventHandler(this.btGetOrderNo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.tbOrderNo);
            this.groupBox1.Controls.Add(this.btGetOrderNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(588, 135);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order number";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.lbPrice);
            this.groupBox2.Controls.Add(this.lbProducts);
            this.groupBox2.Controls.Add(this.tbOrderStatus);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbTotalPrice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btMakeOrder);
            this.groupBox2.Controls.Add(this.btGetProducts);
            this.groupBox2.Location = new System.Drawing.Point(24, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(588, 356);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // lbPrice
            // 
            this.lbPrice.FormattingEnabled = true;
            this.lbPrice.ItemHeight = 25;
            this.lbPrice.Location = new System.Drawing.Point(468, 37);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPrice.Size = new System.Drawing.Size(104, 179);
            this.lbPrice.TabIndex = 13;
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 25;
            this.lbProducts.Location = new System.Drawing.Point(190, 37);
            this.lbProducts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbProducts.Size = new System.Drawing.Size(262, 179);
            this.lbProducts.TabIndex = 12;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // tbOrderStatus
            // 
            this.tbOrderStatus.Location = new System.Drawing.Point(186, 298);
            this.tbOrderStatus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbOrderStatus.Name = "tbOrderStatus";
            this.tbOrderStatus.ReadOnly = true;
            this.tbOrderStatus.Size = new System.Drawing.Size(386, 31);
            this.tbOrderStatus.TabIndex = 11;
            this.tbOrderStatus.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Order status:";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(186, 248);
            this.tbTotalPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(140, 31);
            this.tbTotalPrice.TabIndex = 9;
            this.tbTotalPrice.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total price:";
            // 
            // btMakeOrder
            // 
            this.btMakeOrder.Location = new System.Drawing.Point(12, 146);
            this.btMakeOrder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btMakeOrder.Name = "btMakeOrder";
            this.btMakeOrder.Size = new System.Drawing.Size(160, 73);
            this.btMakeOrder.TabIndex = 5;
            this.btMakeOrder.Text = "Make an order";
            this.btMakeOrder.UseVisualStyleBackColor = true;
            this.btMakeOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ClientForm";
            this.Text = "Self Order Kiosk";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGetProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrderNo;
        private System.Windows.Forms.Button btGetOrderNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btMakeOrder;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrderStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ListBox lbPrice;
    }
}

