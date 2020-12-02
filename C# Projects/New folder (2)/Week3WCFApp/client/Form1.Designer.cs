namespace client
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
            this.buttonWebshopName = new System.Windows.Forms.Button();
            this.buttonProductList = new System.Windows.Forms.Button();
            this.buttonProductInfo = new System.Windows.Forms.Button();
            this.buttonBuyProduct = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonWebshopName
            // 
            this.buttonWebshopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWebshopName.Location = new System.Drawing.Point(32, 23);
            this.buttonWebshopName.Name = "buttonWebshopName";
            this.buttonWebshopName.Size = new System.Drawing.Size(266, 53);
            this.buttonWebshopName.TabIndex = 0;
            this.buttonWebshopName.Text = "Get Webshop Name";
            this.buttonWebshopName.UseVisualStyleBackColor = true;
            this.buttonWebshopName.Click += new System.EventHandler(this.buttonWebshopName_Click);
            // 
            // buttonProductList
            // 
            this.buttonProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductList.Location = new System.Drawing.Point(32, 110);
            this.buttonProductList.Name = "buttonProductList";
            this.buttonProductList.Size = new System.Drawing.Size(266, 53);
            this.buttonProductList.TabIndex = 1;
            this.buttonProductList.Text = "Get Product List";
            this.buttonProductList.UseVisualStyleBackColor = true;
            // 
            // buttonProductInfo
            // 
            this.buttonProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductInfo.Location = new System.Drawing.Point(32, 206);
            this.buttonProductInfo.Name = "buttonProductInfo";
            this.buttonProductInfo.Size = new System.Drawing.Size(266, 53);
            this.buttonProductInfo.TabIndex = 2;
            this.buttonProductInfo.Text = "Get Product Info";
            this.buttonProductInfo.UseVisualStyleBackColor = true;
            // 
            // buttonBuyProduct
            // 
            this.buttonBuyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuyProduct.Location = new System.Drawing.Point(32, 292);
            this.buttonBuyProduct.Name = "buttonBuyProduct";
            this.buttonBuyProduct.Size = new System.Drawing.Size(266, 53);
            this.buttonBuyProduct.TabIndex = 3;
            this.buttonBuyProduct.Text = "Buy Product";
            this.buttonBuyProduct.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(326, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 180);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(598, 159);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(67, 180);
            this.listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(683, 159);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(67, 180);
            this.listBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(591, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(678, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stock";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonBuyProduct);
            this.Controls.Add(this.buttonProductInfo);
            this.Controls.Add(this.buttonProductList);
            this.Controls.Add(this.buttonWebshopName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWebshopName;
        private System.Windows.Forms.Button buttonProductList;
        private System.Windows.Forms.Button buttonProductInfo;
        private System.Windows.Forms.Button buttonBuyProduct;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

