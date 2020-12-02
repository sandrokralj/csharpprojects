namespace DPR_DecoratorPattern
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
            this.radioButtonFiltered = new System.Windows.Forms.RadioButton();
            this.radioButtonEspresso = new System.Windows.Forms.RadioButton();
            this.labelCoffee = new System.Windows.Forms.Label();
            this.labelCondiments = new System.Windows.Forms.Label();
            this.checkBoxMilk = new System.Windows.Forms.CheckBox();
            this.checkBoxSoy = new System.Windows.Forms.CheckBox();
            this.checkBoxWater = new System.Windows.Forms.CheckBox();
            this.checkBoxSugar = new System.Windows.Forms.CheckBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonCoffee = new System.Windows.Forms.Button();
            this.buttonCondiment = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonFiltered
            // 
            this.radioButtonFiltered.AutoSize = true;
            this.radioButtonFiltered.Location = new System.Drawing.Point(116, 52);
            this.radioButtonFiltered.Name = "radioButtonFiltered";
            this.radioButtonFiltered.Size = new System.Drawing.Size(76, 21);
            this.radioButtonFiltered.TabIndex = 0;
            this.radioButtonFiltered.TabStop = true;
            this.radioButtonFiltered.Text = "Filtered\r\n";
            this.radioButtonFiltered.UseVisualStyleBackColor = true;
            // 
            // radioButtonEspresso
            // 
            this.radioButtonEspresso.AutoSize = true;
            this.radioButtonEspresso.Location = new System.Drawing.Point(227, 52);
            this.radioButtonEspresso.Name = "radioButtonEspresso";
            this.radioButtonEspresso.Size = new System.Drawing.Size(88, 21);
            this.radioButtonEspresso.TabIndex = 1;
            this.radioButtonEspresso.TabStop = true;
            this.radioButtonEspresso.Text = "Espresso";
            this.radioButtonEspresso.UseVisualStyleBackColor = true;
            // 
            // labelCoffee
            // 
            this.labelCoffee.AutoSize = true;
            this.labelCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoffee.Location = new System.Drawing.Point(98, 9);
            this.labelCoffee.Name = "labelCoffee";
            this.labelCoffee.Size = new System.Drawing.Size(239, 29);
            this.labelCoffee.TabIndex = 2;
            this.labelCoffee.Text = "Choose your coffee";
            // 
            // labelCondiments
            // 
            this.labelCondiments.AutoSize = true;
            this.labelCondiments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondiments.Location = new System.Drawing.Point(98, 121);
            this.labelCondiments.Name = "labelCondiments";
            this.labelCondiments.Size = new System.Drawing.Size(301, 29);
            this.labelCondiments.TabIndex = 3;
            this.labelCondiments.Text = "Choose your condiments";
            // 
            // checkBoxMilk
            // 
            this.checkBoxMilk.AutoSize = true;
            this.checkBoxMilk.Location = new System.Drawing.Point(114, 173);
            this.checkBoxMilk.Name = "checkBoxMilk";
            this.checkBoxMilk.Size = new System.Drawing.Size(54, 21);
            this.checkBoxMilk.TabIndex = 4;
            this.checkBoxMilk.Text = "Milk";
            this.checkBoxMilk.UseVisualStyleBackColor = true;
            this.checkBoxMilk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxSoy
            // 
            this.checkBoxSoy.AutoSize = true;
            this.checkBoxSoy.Location = new System.Drawing.Point(174, 173);
            this.checkBoxSoy.Name = "checkBoxSoy";
            this.checkBoxSoy.Size = new System.Drawing.Size(54, 21);
            this.checkBoxSoy.TabIndex = 5;
            this.checkBoxSoy.Text = "Soy";
            this.checkBoxSoy.UseVisualStyleBackColor = true;
            // 
            // checkBoxWater
            // 
            this.checkBoxWater.AutoSize = true;
            this.checkBoxWater.Location = new System.Drawing.Point(238, 173);
            this.checkBoxWater.Name = "checkBoxWater";
            this.checkBoxWater.Size = new System.Drawing.Size(68, 21);
            this.checkBoxWater.TabIndex = 6;
            this.checkBoxWater.Text = "Water";
            this.checkBoxWater.UseVisualStyleBackColor = true;
            // 
            // checkBoxSugar
            // 
            this.checkBoxSugar.AutoSize = true;
            this.checkBoxSugar.Location = new System.Drawing.Point(312, 173);
            this.checkBoxSugar.Name = "checkBoxSugar";
            this.checkBoxSugar.Size = new System.Drawing.Size(68, 21);
            this.checkBoxSugar.TabIndex = 7;
            this.checkBoxSugar.Text = "Sugar";
            this.checkBoxSugar.UseVisualStyleBackColor = true;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(10, 255);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(0, 29);
            this.labelDescription.TabIndex = 8;
            // 
            // buttonCoffee
            // 
            this.buttonCoffee.Location = new System.Drawing.Point(174, 88);
            this.buttonCoffee.Name = "buttonCoffee";
            this.buttonCoffee.Size = new System.Drawing.Size(75, 30);
            this.buttonCoffee.TabIndex = 9;
            this.buttonCoffee.Text = "Confirm";
            this.buttonCoffee.UseVisualStyleBackColor = true;
            this.buttonCoffee.Click += new System.EventHandler(this.buttonCoffee_Click);
            // 
            // buttonCondiment
            // 
            this.buttonCondiment.Location = new System.Drawing.Point(174, 213);
            this.buttonCondiment.Name = "buttonCondiment";
            this.buttonCondiment.Size = new System.Drawing.Size(75, 30);
            this.buttonCondiment.TabIndex = 10;
            this.buttonCondiment.Text = "Confirm";
            this.buttonCondiment.UseVisualStyleBackColor = true;
            this.buttonCondiment.Click += new System.EventHandler(this.buttonCondiment_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(498, 255);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 29);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 389);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonCondiment);
            this.Controls.Add(this.buttonCoffee);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.checkBoxSugar);
            this.Controls.Add(this.checkBoxWater);
            this.Controls.Add(this.checkBoxSoy);
            this.Controls.Add(this.checkBoxMilk);
            this.Controls.Add(this.labelCondiments);
            this.Controls.Add(this.labelCoffee);
            this.Controls.Add(this.radioButtonEspresso);
            this.Controls.Add(this.radioButtonFiltered);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonFiltered;
        private System.Windows.Forms.RadioButton radioButtonEspresso;
        private System.Windows.Forms.Label labelCoffee;
        private System.Windows.Forms.Label labelCondiments;
        private System.Windows.Forms.CheckBox checkBoxMilk;
        private System.Windows.Forms.CheckBox checkBoxSoy;
        private System.Windows.Forms.CheckBox checkBoxWater;
        private System.Windows.Forms.CheckBox checkBoxSugar;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonCoffee;
        private System.Windows.Forms.Button buttonCondiment;
        private System.Windows.Forms.Label labelPrice;
    }
}

