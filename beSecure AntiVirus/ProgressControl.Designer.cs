

namespace beSecure_AntiVirus
{
    partial class ProgressControl
    {

        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.CircularBar = new CircularProgressBar.CircularProgressBar();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.WaitProgress = new CircularProgressBar.CircularProgressBar();
            this.filetimer = new System.Windows.Forms.Timer(this.components);
            this.lblnoFiles = new System.Windows.Forms.Label();
            this.lblscan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CircularBar
            // 
            this.CircularBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CircularBar.AnimationSpeed = 500;
            this.CircularBar.BackColor = System.Drawing.Color.Transparent;
            this.CircularBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircularBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CircularBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CircularBar.InnerMargin = 2;
            this.CircularBar.InnerWidth = -1;
            this.CircularBar.Location = new System.Drawing.Point(305, 83);
            this.CircularBar.MarqueeAnimationSpeed = 2000;
            this.CircularBar.Name = "CircularBar";
            this.CircularBar.OuterColor = System.Drawing.Color.Gray;
            this.CircularBar.OuterMargin = -25;
            this.CircularBar.OuterWidth = 26;
            this.CircularBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CircularBar.ProgressWidth = 15;
            this.CircularBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircularBar.Size = new System.Drawing.Size(200, 200);
            this.CircularBar.StartAngle = 270;
            this.CircularBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircularBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CircularBar.SubscriptText = "";
            this.CircularBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircularBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CircularBar.SuperscriptText = "";
            this.CircularBar.TabIndex = 0;
            this.CircularBar.Text = "100%";
            this.CircularBar.TextMargin = new System.Windows.Forms.Padding(8);
            this.CircularBar.Value = 68;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.Location = new System.Drawing.Point(93, 308);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(101, 16);
            this.lblFiles.TabIndex = 1;
            this.lblFiles.Text = "Sacning Files....";
            this.lblFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessing.Location = new System.Drawing.Point(305, 29);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(204, 25);
            this.lblProcessing.TabIndex = 2;
            this.lblProcessing.Text = "Processing Files...";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // WaitProgress
            // 
            this.WaitProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.WaitProgress.AnimationSpeed = 250;
            this.WaitProgress.BackColor = System.Drawing.Color.Transparent;
            this.WaitProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.WaitProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WaitProgress.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WaitProgress.InnerMargin = 2;
            this.WaitProgress.InnerWidth = -1;
            this.WaitProgress.Location = new System.Drawing.Point(277, 57);
            this.WaitProgress.MarqueeAnimationSpeed = 2000;
            this.WaitProgress.Name = "WaitProgress";
            this.WaitProgress.OuterColor = System.Drawing.Color.Gray;
            this.WaitProgress.OuterMargin = -25;
            this.WaitProgress.OuterWidth = 20;
            this.WaitProgress.ProgressColor = System.Drawing.Color.Aquamarine;
            this.WaitProgress.ProgressWidth = 30;
            this.WaitProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.WaitProgress.Size = new System.Drawing.Size(267, 263);
            this.WaitProgress.StartAngle = 270;
            this.WaitProgress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.WaitProgress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.WaitProgress.SubscriptText = ".23";
            this.WaitProgress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.WaitProgress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.WaitProgress.SuperscriptText = "";
            this.WaitProgress.TabIndex = 3;
            this.WaitProgress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.WaitProgress.Value = 68;
            // 
            // filetimer
            // 
            this.filetimer.Enabled = true;
            this.filetimer.Tick += new System.EventHandler(this.Filetimer_Tick);
            // 
            // lblnoFiles
            // 
            this.lblnoFiles.AutoSize = true;
            this.lblnoFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoFiles.Location = new System.Drawing.Point(93, 132);
            this.lblnoFiles.Name = "lblnoFiles";
            this.lblnoFiles.Size = new System.Drawing.Size(15, 16);
            this.lblnoFiles.TabIndex = 4;
            this.lblnoFiles.Text = "0";
            // 
            // lblscan
            // 
            this.lblscan.AutoSize = true;
            this.lblscan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscan.Location = new System.Drawing.Point(135, 132);
            this.lblscan.Name = "lblscan";
            this.lblscan.Size = new System.Drawing.Size(94, 16);
            this.lblscan.TabIndex = 5;
            this.lblscan.Text = "Files Scanned";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // ProgressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblscan);
            this.Controls.Add(this.lblnoFiles);
            this.Controls.Add(this.WaitProgress);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.CircularBar);
            this.Name = "ProgressControl";
            this.Size = new System.Drawing.Size(800, 360);
            this.Load += new System.EventHandler(this.ProgressControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar CircularBar;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblProcessing;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private CircularProgressBar.CircularProgressBar WaitProgress;
        private System.Windows.Forms.Timer filetimer;
        private System.Windows.Forms.Label lblnoFiles;
        private System.Windows.Forms.Label lblscan;
        private System.Windows.Forms.Label label1;
    }
}
