namespace Week1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbScanDisk = new System.Windows.Forms.RadioButton();
            this.rbShorstSeek = new System.Windows.Forms.RadioButton();
            this.rbFirstCome = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbReadRequests = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbReqProcessing = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbScanDisk);
            this.groupBox1.Controls.Add(this.rbShorstSeek);
            this.groupBox1.Controls.Add(this.rbFirstCome);
            this.groupBox1.Location = new System.Drawing.Point(447, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Strategy";
            // 
            // rbScanDisk
            // 
            this.rbScanDisk.AutoSize = true;
            this.rbScanDisk.Location = new System.Drawing.Point(33, 85);
            this.rbScanDisk.Name = "rbScanDisk";
            this.rbScanDisk.Size = new System.Drawing.Size(180, 24);
            this.rbScanDisk.TabIndex = 2;
            this.rbScanDisk.TabStop = true;
            this.rbScanDisk.Text = "SCAN disk (elevator)";
            this.rbScanDisk.UseVisualStyleBackColor = true;
            this.rbScanDisk.CheckedChanged += new System.EventHandler(this.rbScanDisk_CheckedChanged);
            // 
            // rbShorstSeek
            // 
            this.rbShorstSeek.AutoSize = true;
            this.rbShorstSeek.Location = new System.Drawing.Point(33, 55);
            this.rbShorstSeek.Name = "rbShorstSeek";
            this.rbShorstSeek.Size = new System.Drawing.Size(209, 24);
            this.rbShorstSeek.TabIndex = 1;
            this.rbShorstSeek.TabStop = true;
            this.rbShorstSeek.Text = "Shortest Seek Time First";
            this.rbShorstSeek.UseVisualStyleBackColor = true;
            this.rbShorstSeek.CheckedChanged += new System.EventHandler(this.rbShorstSeek_CheckedChanged);
            this.rbShorstSeek.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.rbShorstSeek_ChangeUICues);
            // 
            // rbFirstCome
            // 
            this.rbFirstCome.AutoSize = true;
            this.rbFirstCome.Location = new System.Drawing.Point(33, 25);
            this.rbFirstCome.Name = "rbFirstCome";
            this.rbFirstCome.Size = new System.Drawing.Size(191, 24);
            this.rbFirstCome.TabIndex = 0;
            this.rbFirstCome.TabStop = true;
            this.rbFirstCome.Text = "First Come First Serve";
            this.rbFirstCome.UseVisualStyleBackColor = true;
            this.rbFirstCome.CheckedChanged += new System.EventHandler(this.rbFirstCome_CheckedChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(513, 160);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(194, 51);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(513, 268);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(194, 51);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbReadRequests
            // 
            this.lbReadRequests.FormattingEnabled = true;
            this.lbReadRequests.ItemHeight = 20;
            this.lbReadRequests.Location = new System.Drawing.Point(244, 74);
            this.lbReadRequests.Name = "lbReadRequests";
            this.lbReadRequests.Size = new System.Drawing.Size(138, 364);
            this.lbReadRequests.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Processing Request";
            // 
            // lbReqProcessing
            // 
            this.lbReqProcessing.AutoSize = true;
            this.lbReqProcessing.Location = new System.Drawing.Point(240, 39);
            this.lbReqProcessing.Name = "lbReqProcessing";
            this.lbReqProcessing.Size = new System.Drawing.Size(18, 20);
            this.lbReqProcessing.TabIndex = 5;
            this.lbReqProcessing.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(36, 21);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(69, 394);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lbReqProcessing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbReadRequests);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Disk Scheduling";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFirstCome;
        private System.Windows.Forms.RadioButton rbScanDisk;
        private System.Windows.Forms.RadioButton rbShorstSeek;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lbReadRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbReqProcessing;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

