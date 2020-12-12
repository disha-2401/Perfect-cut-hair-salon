namespace PerfectCutHairSalon
{
    partial class PerfectCutHairSalon
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
            this.hairdresser = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.services = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chargeditems = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pricebox = new System.Windows.Forms.ListBox();
            this.totalPriceLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.addservice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // a combobox that contains hairdressers
            // 
            this.hairdresser.FormattingEnabled = true;
            this.hairdresser.Items.AddRange(new object[] {
            "Jane",
            "Pat",
            "Ron",
            "Sue",
            "Laurie"});
            this.hairdresser.Location = new System.Drawing.Point(6, 19);
            this.hairdresser.Name = "hairdresser";
            this.hairdresser.Size = new System.Drawing.Size(177, 21);
            this.hairdresser.TabIndex = 1;
           
            // 
            // groupBox of hairdresser
            // 
            this.groupBox1.Controls.Add(this.hairdresser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Hairdresser:";
            // 
            // groupBox of services
            // 
            this.groupBox2.Controls.Add(this.services);
            this.groupBox2.Location = new System.Drawing.Point(207, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Service:";
            // 
            // a listbox that contains services
            // 
            this.services.FormattingEnabled = true;
            this.services.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extension",
            "Up-do"});
            this.services.Location = new System.Drawing.Point(7, 19);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(172, 95);
            this.services.TabIndex = 0;
            
            // 
            // groupBox of charged items
            // 
            this.groupBox3.Controls.Add(this.chargeditems);
            this.groupBox3.Location = new System.Drawing.Point(398, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 122);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charged items:";
            // 
            // listbox that will contain chargeditems
            // 
            this.chargeditems.FormattingEnabled = true;
            this.chargeditems.Location = new System.Drawing.Point(7, 20);
            this.chargeditems.Name = "chargeditems";
            this.chargeditems.Size = new System.Drawing.Size(159, 95);
            this.chargeditems.TabIndex = 0;
            
            // groupBox of Price
            // 
            this.groupBox4.Controls.Add(this.pricebox);
            this.groupBox4.Location = new System.Drawing.Point(576, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 122);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price:";
            // 
            // a listbox thai will contain prices
            // 
            this.pricebox.FormattingEnabled = true;
            this.pricebox.Location = new System.Drawing.Point(7, 19);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(90, 95);
            this.pricebox.TabIndex = 0;
            // 
            // a lable that will display total price
            // 
            this.totalPriceLable.AutoSize = true;
            this.totalPriceLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLable.Location = new System.Drawing.Point(598, 147);
            this.totalPriceLable.Name = "totalPriceLable";
            this.totalPriceLable.Size = new System.Drawing.Size(2, 15);
            this.totalPriceLable.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Price:";
            // 
            // Exit button
            // 
            this.button1.Location = new System.Drawing.Point(558, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            //Reset button
            // 
            this.button2.Location = new System.Drawing.Point(426, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            //Calculate Total Price button
            // 
            this.button3.Location = new System.Drawing.Point(302, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Calculate Total Price";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Add Service button
            // 
            this.addservice.Location = new System.Drawing.Point(176, 175);
            this.addservice.Name = "addservice";
            this.addservice.Size = new System.Drawing.Size(120, 23);
            this.addservice.TabIndex = 11;
            this.addservice.Text = "Add Service";
            this.addservice.UseVisualStyleBackColor = true;
            this.addservice.Click += new System.EventHandler(this.add_service);
            // 
            // main form named as Perfect Cut Hair Salon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 212);
            this.Controls.Add(this.addservice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalPriceLable);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hairdresser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox services;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox chargeditems;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox pricebox;
        private System.Windows.Forms.Label totalPriceLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addservice;

    }
}

