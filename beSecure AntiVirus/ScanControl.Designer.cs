namespace beSecure_AntiVirus
{
    partial class ScanControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanControl));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.picCustomscan = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picQuickscan = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picFullscan = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomscan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuickscan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFullscan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is Scan Control";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.picCustomscan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picQuickscan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picFullscan);
            this.panel1.Location = new System.Drawing.Point(76, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 236);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Custom Scan";
            this.label4.Click += new System.EventHandler(this.PicCustomscan_Click);
            // 
            // picCustomscan
            // 
            this.picCustomscan.Image = ((System.Drawing.Image)(resources.GetObject("picCustomscan.Image")));
            this.picCustomscan.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCustomscan.InitialImage")));
            this.picCustomscan.Location = new System.Drawing.Point(479, 18);
            this.picCustomscan.Name = "picCustomscan";
            this.picCustomscan.Size = new System.Drawing.Size(130, 135);
            this.picCustomscan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCustomscan.TabIndex = 4;
            this.picCustomscan.TabStop = false;
            this.picCustomscan.Click += new System.EventHandler(this.PicCustomscan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quick Scan";
            this.label3.Click += new System.EventHandler(this.PicQuickscan_Click);
            // 
            // picQuickscan
            // 
            this.picQuickscan.Image = ((System.Drawing.Image)(resources.GetObject("picQuickscan.Image")));
            this.picQuickscan.InitialImage = ((System.Drawing.Image)(resources.GetObject("picQuickscan.InitialImage")));
            this.picQuickscan.Location = new System.Drawing.Point(259, 18);
            this.picQuickscan.Name = "picQuickscan";
            this.picQuickscan.Size = new System.Drawing.Size(130, 135);
            this.picQuickscan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQuickscan.TabIndex = 2;
            this.picQuickscan.TabStop = false;
            this.picQuickscan.Click += new System.EventHandler(this.PicQuickscan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Scan";
            this.label2.Click += new System.EventHandler(this.PicFullscan_Click);
            // 
            // picFullscan
            // 
            this.picFullscan.Image = ((System.Drawing.Image)(resources.GetObject("picFullscan.Image")));
            this.picFullscan.InitialImage = ((System.Drawing.Image)(resources.GetObject("picFullscan.InitialImage")));
            this.picFullscan.Location = new System.Drawing.Point(43, 18);
            this.picFullscan.Name = "picFullscan";
            this.picFullscan.Size = new System.Drawing.Size(130, 135);
            this.picFullscan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFullscan.TabIndex = 0;
            this.picFullscan.TabStop = false;
            this.picFullscan.Click += new System.EventHandler(this.PicFullscan_Click);
            // 
            // ScanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ScanControl";
            this.Size = new System.Drawing.Size(800, 360);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomscan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuickscan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFullscan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picFullscan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picCustomscan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picQuickscan;
    }
}
