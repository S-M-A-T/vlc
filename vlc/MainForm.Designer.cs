namespace vlc
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Vlc.DotNet.Forms.VlcControl vlcControl;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtVideoUrl;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.vlcControl = new Vlc.DotNet.Forms.VlcControl();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtVideoUrl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).BeginInit();
            this.SuspendLayout();

            // Set VlcLibDirectory before EndInit
            this.vlcControl.VlcLibDirectory = new System.IO.DirectoryInfo(@"D:\VideoLAN\VLC");
            this.vlcControl.EndInit();

            // vlcControl
            this.vlcControl.Location = new System.Drawing.Point(0, 50);
            this.vlcControl.Name = "vlcControl";
            this.vlcControl.Size = new System.Drawing.Size(800, 450);
            this.vlcControl.Spu = -1;
            this.vlcControl.TabIndex = 0;
            this.vlcControl.Text = "vlcControl";
            this.vlcControl.Dock = System.Windows.Forms.DockStyle.Fill;

            // btnPlay
            this.btnPlay.Location = new System.Drawing.Point(12, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);

            // btnStop
            this.btnStop.Location = new System.Drawing.Point(93, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);

            // txtVideoUrl
            this.txtVideoUrl.Location = new System.Drawing.Point(174, 12);
            this.txtVideoUrl.Name = "txtVideoUrl";
            this.txtVideoUrl.Size = new System.Drawing.Size(614, 23);
            this.txtVideoUrl.TabIndex = 3;
            this.txtVideoUrl.Text = "https://www.youtube.com/watch?v=pebAfwsbLa8&ab_channel=SAMAATV";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.txtVideoUrl);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.vlcControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
