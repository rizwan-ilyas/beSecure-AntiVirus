

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
            this.CircularBar = new CircularProgressBar.CircularProgressBar();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CircularBar
            // 
            this.CircularBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CircularBar.AnimationSpeed = 500;
            this.CircularBar.BackColor = System.Drawing.Color.Transparent;
            this.CircularBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
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
            this.CircularBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CircularBar.Size = new System.Drawing.Size(200, 200);
            this.CircularBar.StartAngle = 270;
            this.CircularBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircularBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CircularBar.SubscriptText = ".23";
            this.CircularBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircularBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CircularBar.SuperscriptText = "°C";
            this.CircularBar.TabIndex = 0;
            this.CircularBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CircularBar.Value = 68;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.Location = new System.Drawing.Point(207, 303);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(116, 16);
            this.lblFiles.TabIndex = 1;
            this.lblFiles.Text = "This will show files";
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
            // ProgressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.CircularBar);
            this.Name = "ProgressControl";
            this.Size = new System.Drawing.Size(800, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar CircularBar;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblProcessing;
        




    }
}
