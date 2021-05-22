namespace Adapter_DPR
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
            this.rbDuck = new System.Windows.Forms.RadioButton();
            this.rbFish = new System.Windows.Forms.RadioButton();
            this.rbBird = new System.Windows.Forms.RadioButton();
            this.btnGetInfor = new System.Windows.Forms.Button();
            this.lbSqueak = new System.Windows.Forms.Label();
            this.lbFly = new System.Windows.Forms.Label();
            this.lbSqueakSound = new System.Windows.Forms.Label();
            this.lbFlyWay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbDuck
            // 
            this.rbDuck.AutoSize = true;
            this.rbDuck.Location = new System.Drawing.Point(256, 29);
            this.rbDuck.Name = "rbDuck";
            this.rbDuck.Size = new System.Drawing.Size(71, 24);
            this.rbDuck.TabIndex = 0;
            this.rbDuck.TabStop = true;
            this.rbDuck.Text = "Duck";
            this.rbDuck.UseVisualStyleBackColor = true;
            // 
            // rbFish
            // 
            this.rbFish.AutoSize = true;
            this.rbFish.Location = new System.Drawing.Point(256, 92);
            this.rbFish.Name = "rbFish";
            this.rbFish.Size = new System.Drawing.Size(64, 24);
            this.rbFish.TabIndex = 1;
            this.rbFish.TabStop = true;
            this.rbFish.Text = "Fish";
            this.rbFish.UseVisualStyleBackColor = true;
            // 
            // rbBird
            // 
            this.rbBird.AutoSize = true;
            this.rbBird.Location = new System.Drawing.Point(256, 153);
            this.rbBird.Name = "rbBird";
            this.rbBird.Size = new System.Drawing.Size(62, 24);
            this.rbBird.TabIndex = 2;
            this.rbBird.TabStop = true;
            this.rbBird.Text = "Bird";
            this.rbBird.UseVisualStyleBackColor = true;
            // 
            // btnGetInfor
            // 
            this.btnGetInfor.Location = new System.Drawing.Point(361, 92);
            this.btnGetInfor.Name = "btnGetInfor";
            this.btnGetInfor.Size = new System.Drawing.Size(136, 36);
            this.btnGetInfor.TabIndex = 3;
            this.btnGetInfor.Text = "Get Information";
            this.btnGetInfor.UseVisualStyleBackColor = true;
            this.btnGetInfor.Click += new System.EventHandler(this.btnGetInfor_Click);
            // 
            // lbSqueak
            // 
            this.lbSqueak.AutoSize = true;
            this.lbSqueak.Location = new System.Drawing.Point(78, 204);
            this.lbSqueak.Name = "lbSqueak";
            this.lbSqueak.Size = new System.Drawing.Size(72, 20);
            this.lbSqueak.TabIndex = 4;
            this.lbSqueak.Text = "Squeak: ";
            // 
            // lbFly
            // 
            this.lbFly.AutoSize = true;
            this.lbFly.Location = new System.Drawing.Point(78, 240);
            this.lbFly.Name = "lbFly";
            this.lbFly.Size = new System.Drawing.Size(37, 20);
            this.lbFly.TabIndex = 5;
            this.lbFly.Text = "Fly: ";
            // 
            // lbSqueakSound
            // 
            this.lbSqueakSound.AutoSize = true;
            this.lbSqueakSound.Location = new System.Drawing.Point(156, 204);
            this.lbSqueakSound.Name = "lbSqueakSound";
            this.lbSqueakSound.Size = new System.Drawing.Size(0, 20);
            this.lbSqueakSound.TabIndex = 6;
            // 
            // lbFlyWay
            // 
            this.lbFlyWay.AutoSize = true;
            this.lbFlyWay.Location = new System.Drawing.Point(156, 240);
            this.lbFlyWay.Name = "lbFlyWay";
            this.lbFlyWay.Size = new System.Drawing.Size(0, 20);
            this.lbFlyWay.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 292);
            this.Controls.Add(this.lbFlyWay);
            this.Controls.Add(this.lbSqueakSound);
            this.Controls.Add(this.lbFly);
            this.Controls.Add(this.lbSqueak);
            this.Controls.Add(this.btnGetInfor);
            this.Controls.Add(this.rbBird);
            this.Controls.Add(this.rbFish);
            this.Controls.Add(this.rbDuck);
            this.Name = "Form1";
            this.Text = "Duck Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDuck;
        private System.Windows.Forms.RadioButton rbFish;
        private System.Windows.Forms.RadioButton rbBird;
        private System.Windows.Forms.Button btnGetInfor;
        private System.Windows.Forms.Label lbSqueak;
        private System.Windows.Forms.Label lbFly;
        private System.Windows.Forms.Label lbSqueakSound;
        private System.Windows.Forms.Label lbFlyWay;
    }
}

