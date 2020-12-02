namespace City_Traffic_Simulation_Application
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.waypoint3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.waypoint2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.trafficlightRight = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.waypoint1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.trafficlightLeft = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.buttonStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::City_Traffic_Simulation_Application.Properties.Resources.GreenCarRight;
            this.pictureBox1.Location = new System.Drawing.Point(377, 286);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::City_Traffic_Simulation_Application.Properties.Resources.GreenCarRight;
            this.pictureBox2.Location = new System.Drawing.Point(241, 286);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::City_Traffic_Simulation_Application.Properties.Resources.GreenCarRight;
            this.pictureBox3.Location = new System.Drawing.Point(97, 286);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::City_Traffic_Simulation_Application.Properties.Resources.GreenCarDown;
            this.pictureBox9.Location = new System.Drawing.Point(668, 144);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(41, 91);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::City_Traffic_Simulation_Application.Properties.Resources.GreenCarDown;
            this.pictureBox10.Location = new System.Drawing.Point(668, 48);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(41, 91);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(97, 79);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1087, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "0";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.waypoint3,
            this.waypoint2,
            this.ovalShape2,
            this.ovalShape1,
            this.trafficlightRight,
            this.waypoint1,
            this.trafficlightLeft});
            this.shapeContainer1.Size = new System.Drawing.Size(1315, 670);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // waypoint3
            // 
            this.waypoint3.BackColor = System.Drawing.Color.RosyBrown;
            this.waypoint3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.waypoint3.BorderColor = System.Drawing.Color.RosyBrown;
            this.waypoint3.Location = new System.Drawing.Point(803, 246);
            this.waypoint3.Name = "waypoint3";
            this.waypoint3.Size = new System.Drawing.Size(29, 29);
            // 
            // waypoint2
            // 
            this.waypoint2.BackColor = System.Drawing.Color.RosyBrown;
            this.waypoint2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.waypoint2.BorderColor = System.Drawing.Color.RosyBrown;
            this.waypoint2.Location = new System.Drawing.Point(521, 448);
            this.waypoint2.Name = "waypoint2";
            this.waypoint2.Size = new System.Drawing.Size(29, 29);
            // 
            // ovalShape2
            // 
            this.ovalShape2.BackColor = System.Drawing.Color.Red;
            this.ovalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape2.BorderColor = System.Drawing.Color.Red;
            this.ovalShape2.Location = new System.Drawing.Point(561, 331);
            this.ovalShape2.Name = "ovalShape2";
            this.ovalShape2.Size = new System.Drawing.Size(29, 29);
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.Color.Red;
            this.ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape1.BorderColor = System.Drawing.Color.Red;
            this.ovalShape1.Location = new System.Drawing.Point(382, 198);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(29, 29);
            // 
            // trafficlightRight
            // 
            this.trafficlightRight.BackColor = System.Drawing.Color.Green;
            this.trafficlightRight.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.trafficlightRight.BorderColor = System.Drawing.Color.Red;
            this.trafficlightRight.Location = new System.Drawing.Point(565, 195);
            this.trafficlightRight.Name = "trafficlightRight";
            this.trafficlightRight.Size = new System.Drawing.Size(29, 29);
            // 
            // waypoint1
            // 
            this.waypoint1.BackColor = System.Drawing.Color.RosyBrown;
            this.waypoint1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.waypoint1.BorderColor = System.Drawing.Color.RosyBrown;
            this.waypoint1.Location = new System.Drawing.Point(461, 256);
            this.waypoint1.Name = "waypoint1";
            this.waypoint1.Size = new System.Drawing.Size(29, 29);
            // 
            // trafficlightLeft
            // 
            this.trafficlightLeft.BackColor = System.Drawing.Color.Red;
            this.trafficlightLeft.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.trafficlightLeft.BorderColor = System.Drawing.Color.Red;
            this.trafficlightLeft.Location = new System.Drawing.Point(378, 326);
            this.trafficlightLeft.Name = "trafficlightLeft";
            this.trafficlightLeft.Size = new System.Drawing.Size(29, 29);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(177, 79);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 20;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(201, 129);
            this.btnprint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 59);
            this.btnprint.TabIndex = 22;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(97, 129);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 54);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "save ";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::City_Traffic_Simulation_Application.Properties.Resources.Map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1315, 670);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape trafficlightRight;
        private Microsoft.VisualBasic.PowerPacks.OvalShape waypoint1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape trafficlightLeft;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button button1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape waypoint3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape waypoint2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnsave;
    }
}

