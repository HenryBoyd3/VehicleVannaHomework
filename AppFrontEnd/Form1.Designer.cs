
namespace AppFrontEnd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.modle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.make = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.responseLable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ListPrice = new System.Windows.Forms.NumericUpDown();
            this.year = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ListPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(11, 31);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(183, 23);
            this.lName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(11, 83);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(183, 23);
            this.fName.TabIndex = 3;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(11, 135);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(183, 23);
            this.email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email Adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Year";
            // 
            // modle
            // 
            this.modle.Location = new System.Drawing.Point(11, 246);
            this.modle.Name = "modle";
            this.modle.Size = new System.Drawing.Size(182, 23);
            this.modle.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Model";
            // 
            // make
            // 
            this.make.Location = new System.Drawing.Point(11, 194);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(182, 23);
            this.make.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Make";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Process Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vType
            // 
            this.vType.FormattingEnabled = true;
            this.vType.Items.AddRange(new object[] {
            "Car",
            "SportsCar",
            "Truck",
            "Motorcycle",
            "MotorHome"});
            this.vType.Location = new System.Drawing.Point(248, 31);
            this.vType.Name = "vType";
            this.vType.Size = new System.Drawing.Size(165, 23);
            this.vType.TabIndex = 20;
            this.vType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Vehicle Type";
            // 
            // responseLable
            // 
            this.responseLable.Location = new System.Drawing.Point(277, 117);
            this.responseLable.Name = "responseLable";
            this.responseLable.Size = new System.Drawing.Size(343, 178);
            this.responseLable.TabIndex = 23;
            this.responseLable.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Price";
            // 
            // ListPrice
            // 
            this.ListPrice.Location = new System.Drawing.Point(11, 347);
            this.ListPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ListPrice.Name = "ListPrice";
            this.ListPrice.Size = new System.Drawing.Size(184, 23);
            this.ListPrice.TabIndex = 25;
            this.ListPrice.Value = new decimal(new int[] {
            25499,
            0,
            0,
            0});
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(13, 298);
            this.year.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(184, 23);
            this.year.TabIndex = 26;
            this.year.Value = new decimal(new int[] {
            1994,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.year);
            this.Controls.Add(this.ListPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.responseLable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.make);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ListPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox make;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox vType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label responseLable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ListPrice;
        private System.Windows.Forms.NumericUpDown year;
    }
}

