namespace Visitor_DPR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbNormalCustmor = new System.Windows.Forms.RadioButton();
            this.rbGoldenCustmor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.numericUpDownAll = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.radioButtonApple = new System.Windows.Forms.RadioButton();
            this.radioButtonBanana = new System.Windows.Forms.RadioButton();
            this.radioButtonCoffee = new System.Windows.Forms.RadioButton();
            this.radioButtonCola = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowPrice = new System.Windows.Forms.Button();
            this.btnNewClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAll)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbNormalCustmor
            // 
            this.rbNormalCustmor.AutoSize = true;
            this.rbNormalCustmor.Checked = true;
            this.rbNormalCustmor.Location = new System.Drawing.Point(137, 21);
            this.rbNormalCustmor.Margin = new System.Windows.Forms.Padding(2);
            this.rbNormalCustmor.Name = "rbNormalCustmor";
            this.rbNormalCustmor.Size = new System.Drawing.Size(105, 17);
            this.rbNormalCustmor.TabIndex = 0;
            this.rbNormalCustmor.TabStop = true;
            this.rbNormalCustmor.Text = "Normal Costumer";
            this.rbNormalCustmor.UseVisualStyleBackColor = true;
            this.rbNormalCustmor.CheckedChanged += new System.EventHandler(this.rbNormalCustmor_CheckedChanged);
            // 
            // rbGoldenCustmor
            // 
            this.rbGoldenCustmor.AutoSize = true;
            this.rbGoldenCustmor.Location = new System.Drawing.Point(258, 21);
            this.rbGoldenCustmor.Margin = new System.Windows.Forms.Padding(2);
            this.rbGoldenCustmor.Name = "rbGoldenCustmor";
            this.rbGoldenCustmor.Size = new System.Drawing.Size(106, 17);
            this.rbGoldenCustmor.TabIndex = 1;
            this.rbGoldenCustmor.Text = "Golden Costumer";
            this.rbGoldenCustmor.UseVisualStyleBackColor = true;
            this.rbGoldenCustmor.CheckedChanged += new System.EventHandler(this.rbGoldenCustmor_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Type";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(489, 361);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // numericUpDownAll
            // 
            this.numericUpDownAll.Location = new System.Drawing.Point(340, 19);
            this.numericUpDownAll.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownAll.Name = "numericUpDownAll";
            this.numericUpDownAll.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownAll.TabIndex = 4;
            this.numericUpDownAll.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vegetables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Drinks";
            // 
            // lbOrder
            // 
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.Location = new System.Drawing.Point(468, 70);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(225, 277);
            this.lbOrder.TabIndex = 8;
            // 
            // button18
            // 
            this.button18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button18.BackgroundImage")));
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.Location = new System.Drawing.Point(41, 36);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(119, 103);
            this.button18.TabIndex = 105;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(202, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 103);
            this.button1.TabIndex = 106;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(41, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 103);
            this.button2.TabIndex = 107;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(202, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 103);
            this.button3.TabIndex = 108;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(148, 283);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 109;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // radioButtonApple
            // 
            this.radioButtonApple.AutoSize = true;
            this.radioButtonApple.Checked = true;
            this.radioButtonApple.Location = new System.Drawing.Point(9, 59);
            this.radioButtonApple.Name = "radioButtonApple";
            this.radioButtonApple.Size = new System.Drawing.Size(14, 13);
            this.radioButtonApple.TabIndex = 110;
            this.radioButtonApple.TabStop = true;
            this.radioButtonApple.UseVisualStyleBackColor = true;
            // 
            // radioButtonBanana
            // 
            this.radioButtonBanana.AutoSize = true;
            this.radioButtonBanana.Location = new System.Drawing.Point(182, 62);
            this.radioButtonBanana.Name = "radioButtonBanana";
            this.radioButtonBanana.Size = new System.Drawing.Size(14, 13);
            this.radioButtonBanana.TabIndex = 111;
            this.radioButtonBanana.UseVisualStyleBackColor = true;
            // 
            // radioButtonCoffee
            // 
            this.radioButtonCoffee.AutoSize = true;
            this.radioButtonCoffee.Location = new System.Drawing.Point(9, 174);
            this.radioButtonCoffee.Name = "radioButtonCoffee";
            this.radioButtonCoffee.Size = new System.Drawing.Size(14, 13);
            this.radioButtonCoffee.TabIndex = 112;
            this.radioButtonCoffee.UseVisualStyleBackColor = true;
            // 
            // radioButtonCola
            // 
            this.radioButtonCola.AutoSize = true;
            this.radioButtonCola.Location = new System.Drawing.Point(182, 174);
            this.radioButtonCola.Name = "radioButtonCola";
            this.radioButtonCola.Size = new System.Drawing.Size(14, 13);
            this.radioButtonCola.TabIndex = 113;
            this.radioButtonCola.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.radioButtonCola);
            this.groupBox1.Controls.Add(this.numericUpDownAll);
            this.groupBox1.Controls.Add(this.radioButtonCoffee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButtonBanana);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButtonApple);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(26, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 311);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnShowPrice
            // 
            this.btnShowPrice.Location = new System.Drawing.Point(608, 361);
            this.btnShowPrice.Name = "btnShowPrice";
            this.btnShowPrice.Size = new System.Drawing.Size(75, 23);
            this.btnShowPrice.TabIndex = 115;
            this.btnShowPrice.Text = "Show Price";
            this.btnShowPrice.UseVisualStyleBackColor = true;
            this.btnShowPrice.Click += new System.EventHandler(this.btnShowPrice_Click);
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(468, 21);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(75, 23);
            this.btnNewClient.TabIndex = 116;
            this.btnNewClient.Text = "New Client";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 406);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.btnShowPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbGoldenCustmor);
            this.Controls.Add(this.rbNormalCustmor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAll)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNormalCustmor;
        private System.Windows.Forms.RadioButton rbGoldenCustmor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.NumericUpDown numericUpDownAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton radioButtonApple;
        private System.Windows.Forms.RadioButton radioButtonBanana;
        private System.Windows.Forms.RadioButton radioButtonCoffee;
        private System.Windows.Forms.RadioButton radioButtonCola;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowPrice;
        private System.Windows.Forms.Button btnNewClient;
    }
}

