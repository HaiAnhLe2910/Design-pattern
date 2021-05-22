namespace Week2
{
    partial class PushForm
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
            this.lbTemp = new System.Windows.Forms.Label();
            this.lbHumid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPressure = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(135, 48);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(0, 20);
            this.lbTemp.TabIndex = 1;
            // 
            // lbHumid
            // 
            this.lbHumid.AutoSize = true;
            this.lbHumid.Location = new System.Drawing.Point(316, 48);
            this.lbHumid.Name = "lbHumid";
            this.lbHumid.Size = new System.Drawing.Size(0, 20);
            this.lbHumid.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Humidity";
            // 
            // lbPressure
            // 
            this.lbPressure.AutoSize = true;
            this.lbPressure.Location = new System.Drawing.Point(494, 48);
            this.lbPressure.Name = "lbPressure";
            this.lbPressure.Size = new System.Drawing.Size(0, 20);
            this.lbPressure.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pressure";
            // 
            // PushForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 111);
            this.Controls.Add(this.lbPressure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbHumid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.label1);
            this.Name = "PushForm";
            this.Text = "PushForm";
            this.Load += new System.EventHandler(this.PushForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label lbHumid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPressure;
        private System.Windows.Forms.Label label6;
    }
}