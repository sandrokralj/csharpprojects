namespace WebshopApp
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
            this.buttonGetWebshopName = new System.Windows.Forms.Button();
            this.buttonGetProductList = new System.Windows.Forms.Button();
            this.buttonProductInfo = new System.Windows.Forms.Button();
            this.buttonBuyProduct = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.richTextBoxId = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPrice = new System.Windows.Forms.RichTextBox();
            this.richTextBoxStock = new System.Windows.Forms.RichTextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGetWebshopName
            // 
            this.buttonGetWebshopName.Location = new System.Drawing.Point(86, 46);
            this.buttonGetWebshopName.Name = "buttonGetWebshopName";
            this.buttonGetWebshopName.Size = new System.Drawing.Size(221, 57);
            this.buttonGetWebshopName.TabIndex = 0;
            this.buttonGetWebshopName.Text = "Get WebShop Name";
            this.buttonGetWebshopName.UseVisualStyleBackColor = true;
            this.buttonGetWebshopName.Click += new System.EventHandler(this.buttonGetWebshopName_Click);
            // 
            // buttonGetProductList
            // 
            this.buttonGetProductList.Location = new System.Drawing.Point(86, 134);
            this.buttonGetProductList.Name = "buttonGetProductList";
            this.buttonGetProductList.Size = new System.Drawing.Size(221, 57);
            this.buttonGetProductList.TabIndex = 1;
            this.buttonGetProductList.Text = "Get Product List";
            this.buttonGetProductList.UseVisualStyleBackColor = true;
            // 
            // buttonProductInfo
            // 
            this.buttonProductInfo.Location = new System.Drawing.Point(86, 222);
            this.buttonProductInfo.Name = "buttonProductInfo";
            this.buttonProductInfo.Size = new System.Drawing.Size(221, 57);
            this.buttonProductInfo.TabIndex = 2;
            this.buttonProductInfo.Text = "Get Product Info";
            this.buttonProductInfo.UseVisualStyleBackColor = true;
            // 
            // buttonBuyProduct
            // 
            this.buttonBuyProduct.Location = new System.Drawing.Point(86, 303);
            this.buttonBuyProduct.Name = "buttonBuyProduct";
            this.buttonBuyProduct.Size = new System.Drawing.Size(221, 57);
            this.buttonBuyProduct.TabIndex = 3;
            this.buttonBuyProduct.Text = "Buy Product";
            this.buttonBuyProduct.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(420, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(335, 46);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Peter\'s Bookshop";
            // 
            // richTextBoxId
            // 
            this.richTextBoxId.Location = new System.Drawing.Point(428, 212);
            this.richTextBoxId.Name = "richTextBoxId";
            this.richTextBoxId.Size = new System.Drawing.Size(197, 148);
            this.richTextBoxId.TabIndex = 7;
            this.richTextBoxId.Text = "";
            // 
            // richTextBoxPrice
            // 
            this.richTextBoxPrice.Location = new System.Drawing.Point(631, 212);
            this.richTextBoxPrice.Name = "richTextBoxPrice";
            this.richTextBoxPrice.Size = new System.Drawing.Size(76, 148);
            this.richTextBoxPrice.TabIndex = 8;
            this.richTextBoxPrice.Text = "";
            // 
            // richTextBoxStock
            // 
            this.richTextBoxStock.Location = new System.Drawing.Point(713, 212);
            this.richTextBoxStock.Name = "richTextBoxStock";
            this.richTextBoxStock.Size = new System.Drawing.Size(76, 148);
            this.richTextBoxStock.TabIndex = 9;
            this.richTextBoxStock.Text = "";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(512, 173);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(36, 29);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(641, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(720, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stock";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.richTextBoxStock);
            this.Controls.Add(this.richTextBoxPrice);
            this.Controls.Add(this.richTextBoxId);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonBuyProduct);
            this.Controls.Add(this.buttonProductInfo);
            this.Controls.Add(this.buttonGetProductList);
            this.Controls.Add(this.buttonGetWebshopName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetWebshopName;
        private System.Windows.Forms.Button buttonGetProductList;
        private System.Windows.Forms.Button buttonProductInfo;
        private System.Windows.Forms.Button buttonBuyProduct;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox richTextBoxId;
        private System.Windows.Forms.RichTextBox richTextBoxPrice;
        private System.Windows.Forms.RichTextBox richTextBoxStock;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

