namespace BusyBeesDesktop
{
    partial class FrmMedia
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
            this.lstHiveMedia = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstHiveMedia
            // 
            this.lstHiveMedia.FormattingEnabled = true;
            this.lstHiveMedia.Location = new System.Drawing.Point(24, 51);
            this.lstHiveMedia.Name = "lstHiveMedia";
            this.lstHiveMedia.Size = new System.Drawing.Size(215, 381);
            this.lstHiveMedia.TabIndex = 0;
            this.lstHiveMedia.SelectedIndexChanged += new System.EventHandler(this.lstHiveMedia_SelectedIndexChanged);
            // 
            // FrmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 627);
            this.Controls.Add(this.lstHiveMedia);
            this.Name = "FrmMedia";
            this.Text = "FrmMedia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMedia_FormClosing);
            this.Load += new System.EventHandler(this.FrmMedia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstHiveMedia;
    }
}