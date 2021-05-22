namespace Week3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbHouseBlend = new System.Windows.Forms.RadioButton();
            this.rbDecaf = new System.Windows.Forms.RadioButton();
            this.rbExpresso = new System.Windows.Forms.RadioButton();
            this.cbMilk = new System.Windows.Forms.CheckBox();
            this.cbMocha = new System.Windows.Forms.CheckBox();
            this.cbSoy = new System.Windows.Forms.CheckBox();
            this.cbWhip = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.comboMilk = new System.Windows.Forms.ComboBox();
            this.comboMocha = new System.Windows.Forms.ComboBox();
            this.comboSoy = new System.Windows.Forms.ComboBox();
            this.comboWhip = new System.Windows.Forms.ComboBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kind of drink";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Condiment";
            // 
            // rbHouseBlend
            // 
            this.rbHouseBlend.AutoSize = true;
            this.rbHouseBlend.Location = new System.Drawing.Point(102, 81);
            this.rbHouseBlend.Margin = new System.Windows.Forms.Padding(2);
            this.rbHouseBlend.Name = "rbHouseBlend";
            this.rbHouseBlend.Size = new System.Drawing.Size(86, 17);
            this.rbHouseBlend.TabIndex = 2;
            this.rbHouseBlend.TabStop = true;
            this.rbHouseBlend.Text = "House Blend";
            this.rbHouseBlend.UseVisualStyleBackColor = true;
            // 
            // rbDecaf
            // 
            this.rbDecaf.AutoSize = true;
            this.rbDecaf.Location = new System.Drawing.Point(102, 110);
            this.rbDecaf.Margin = new System.Windows.Forms.Padding(2);
            this.rbDecaf.Name = "rbDecaf";
            this.rbDecaf.Size = new System.Drawing.Size(54, 17);
            this.rbDecaf.TabIndex = 3;
            this.rbDecaf.TabStop = true;
            this.rbDecaf.Text = "Decaf";
            this.rbDecaf.UseVisualStyleBackColor = true;
            // 
            // rbExpresso
            // 
            this.rbExpresso.AutoSize = true;
            this.rbExpresso.Location = new System.Drawing.Point(102, 140);
            this.rbExpresso.Margin = new System.Windows.Forms.Padding(2);
            this.rbExpresso.Name = "rbExpresso";
            this.rbExpresso.Size = new System.Drawing.Size(68, 17);
            this.rbExpresso.TabIndex = 4;
            this.rbExpresso.TabStop = true;
            this.rbExpresso.Text = "Expresso";
            this.rbExpresso.UseVisualStyleBackColor = true;
            // 
            // cbMilk
            // 
            this.cbMilk.AutoSize = true;
            this.cbMilk.Location = new System.Drawing.Point(271, 75);
            this.cbMilk.Margin = new System.Windows.Forms.Padding(2);
            this.cbMilk.Name = "cbMilk";
            this.cbMilk.Size = new System.Drawing.Size(45, 17);
            this.cbMilk.TabIndex = 5;
            this.cbMilk.Text = "Milk";
            this.cbMilk.UseVisualStyleBackColor = true;
            this.cbMilk.CheckedChanged += new System.EventHandler(this.cbMilk_CheckedChanged);
            // 
            // cbMocha
            // 
            this.cbMocha.AutoSize = true;
            this.cbMocha.Location = new System.Drawing.Point(271, 101);
            this.cbMocha.Margin = new System.Windows.Forms.Padding(2);
            this.cbMocha.Name = "cbMocha";
            this.cbMocha.Size = new System.Drawing.Size(59, 17);
            this.cbMocha.TabIndex = 6;
            this.cbMocha.Text = "Mocha";
            this.cbMocha.UseVisualStyleBackColor = true;
            this.cbMocha.CheckedChanged += new System.EventHandler(this.cbMocha_CheckedChanged);
            // 
            // cbSoy
            // 
            this.cbSoy.AutoSize = true;
            this.cbSoy.Location = new System.Drawing.Point(271, 127);
            this.cbSoy.Margin = new System.Windows.Forms.Padding(2);
            this.cbSoy.Name = "cbSoy";
            this.cbSoy.Size = new System.Drawing.Size(44, 17);
            this.cbSoy.TabIndex = 7;
            this.cbSoy.Text = "Soy";
            this.cbSoy.UseVisualStyleBackColor = true;
            this.cbSoy.CheckedChanged += new System.EventHandler(this.cbSoy_CheckedChanged);
            // 
            // cbWhip
            // 
            this.cbWhip.AutoSize = true;
            this.cbWhip.Location = new System.Drawing.Point(271, 154);
            this.cbWhip.Margin = new System.Windows.Forms.Padding(2);
            this.cbWhip.Name = "cbWhip";
            this.cbWhip.Size = new System.Drawing.Size(51, 17);
            this.cbWhip.TabIndex = 10;
            this.cbWhip.Text = "Whip";
            this.cbWhip.UseVisualStyleBackColor = true;
            this.cbWhip.CheckedChanged += new System.EventHandler(this.cbWhip_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(169, 196);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(118, 24);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Order Price";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(129, 247);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(349, 20);
            this.tbPrice.TabIndex = 13;
            // 
            // comboMilk
            // 
            this.comboMilk.Enabled = false;
            this.comboMilk.FormattingEnabled = true;
            this.comboMilk.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboMilk.Location = new System.Drawing.Point(357, 73);
            this.comboMilk.Name = "comboMilk";
            this.comboMilk.Size = new System.Drawing.Size(121, 21);
            this.comboMilk.TabIndex = 14;
            this.comboMilk.Text = "1";
            // 
            // comboMocha
            // 
            this.comboMocha.Enabled = false;
            this.comboMocha.FormattingEnabled = true;
            this.comboMocha.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboMocha.Location = new System.Drawing.Point(357, 101);
            this.comboMocha.Name = "comboMocha";
            this.comboMocha.Size = new System.Drawing.Size(121, 21);
            this.comboMocha.TabIndex = 15;
            this.comboMocha.Text = "1";
            // 
            // comboSoy
            // 
            this.comboSoy.Enabled = false;
            this.comboSoy.FormattingEnabled = true;
            this.comboSoy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboSoy.Location = new System.Drawing.Point(357, 127);
            this.comboSoy.Name = "comboSoy";
            this.comboSoy.Size = new System.Drawing.Size(121, 21);
            this.comboSoy.TabIndex = 16;
            this.comboSoy.Text = "1";
            // 
            // comboWhip
            // 
            this.comboWhip.Enabled = false;
            this.comboWhip.FormattingEnabled = true;
            this.comboWhip.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboWhip.Location = new System.Drawing.Point(357, 154);
            this.comboWhip.Name = "comboWhip";
            this.comboWhip.Size = new System.Drawing.Size(121, 21);
            this.comboWhip.TabIndex = 17;
            this.comboWhip.Text = "1";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(129, 225);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(349, 20);
            this.tbDescription.TabIndex = 18;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(11, 228);
            this.lDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(89, 13);
            this.lDescription.TabIndex = 12;
            this.lDescription.Text = "Order Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 292);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.comboWhip);
            this.Controls.Add(this.comboSoy);
            this.Controls.Add(this.comboMocha);
            this.Controls.Add(this.comboMilk);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cbWhip);
            this.Controls.Add(this.cbSoy);
            this.Controls.Add(this.cbMocha);
            this.Controls.Add(this.cbMilk);
            this.Controls.Add(this.rbExpresso);
            this.Controls.Add(this.rbDecaf);
            this.Controls.Add(this.rbHouseBlend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Beverage Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbHouseBlend;
        private System.Windows.Forms.RadioButton rbDecaf;
        private System.Windows.Forms.RadioButton rbExpresso;
        private System.Windows.Forms.CheckBox cbMilk;
        private System.Windows.Forms.CheckBox cbMocha;
        private System.Windows.Forms.CheckBox cbSoy;
        private System.Windows.Forms.CheckBox cbWhip;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.ComboBox comboMilk;
        private System.Windows.Forms.ComboBox comboMocha;
        private System.Windows.Forms.ComboBox comboSoy;
        private System.Windows.Forms.ComboBox comboWhip;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lDescription;
    }
}

