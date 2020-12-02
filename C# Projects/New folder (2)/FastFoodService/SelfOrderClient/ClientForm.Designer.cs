namespace SelfOrderClient
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
            this.btGetProducts.Location = new System.Drawing.Point(8, 23);
            this.btGetProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGetProducts.Name = "btGetProducts";
            this.btGetProducts.Size = new System.Drawing.Size(107, 47);
            this.btGetProducts.TabIndex = 0;
            this.btGetProducts.Text = "Get available products";
            this.btGetProducts.UseVisualStyleBackColor = true;
            this.btGetProducts.Click += new System.EventHandler(this.btGetProducts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your order:";
            // 
            // tbOrderNo
            // 
            this.tbOrderNo.Location = new System.Drawing.Point(209, 34);
            this.tbOrderNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOrderNo.Name = "tbOrderNo";
            this.tbOrderNo.ReadOnly = true;
            this.tbOrderNo.Size = new System.Drawing.Size(173, 22);
            this.tbOrderNo.TabIndex = 7;
            this.tbOrderNo.WordWrap = false;
            // 
            // btGetOrderNo
            // 
            this.btGetOrderNo.Location = new System.Drawing.Point(8, 23);
            this.btGetOrderNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGetOrderNo.Name = "btGetOrderNo";
            this.btGetOrderNo.Size = new System.Drawing.Size(107, 46);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(392, 86);
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
            this.groupBox2.Location = new System.Drawing.Point(16, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(392, 228);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // lbPrice
            // 
            this.lbPrice.FormattingEnabled = true;
            this.lbPrice.ItemHeight = 16;
            this.lbPrice.Location = new System.Drawing.Point(312, 23);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPrice.Size = new System.Drawing.Size(71, 116);
            this.lbPrice.TabIndex = 13;
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 16;
            this.lbProducts.Location = new System.Drawing.Point(127, 23);
            this.lbProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbProducts.Size = new System.Drawing.Size(176, 116);
            this.lbProducts.TabIndex = 12;
            this.lbProducts.SelectedValueChanged += new System.EventHandler(this.lbProducts_SelectedValueChanged);
            // 
            // tbOrderStatus
            // 
            this.tbOrderStatus.Location = new System.Drawing.Point(124, 191);
            this.tbOrderStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOrderStatus.Name = "tbOrderStatus";
            this.tbOrderStatus.ReadOnly = true;
            this.tbOrderStatus.Size = new System.Drawing.Size(259, 22);
            this.tbOrderStatus.TabIndex = 11;
            this.tbOrderStatus.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Order status:";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(124, 159);
            this.tbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(95, 22);
            this.tbTotalPrice.TabIndex = 9;
            this.tbTotalPrice.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total price:";
            // 
            // btMakeOrder
            // 
            this.btMakeOrder.Location = new System.Drawing.Point(8, 94);
            this.btMakeOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMakeOrder.Name = "btMakeOrder";
            this.btMakeOrder.Size = new System.Drawing.Size(107, 47);
            this.btMakeOrder.TabIndex = 5;
            this.btMakeOrder.Text = "Make an order";
            this.btMakeOrder.UseVisualStyleBackColor = true;
            this.btMakeOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 351);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

