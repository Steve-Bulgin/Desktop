namespace BusyBeesDesktop
{
    partial class FrmMain
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
            this.btnViewYard = new System.Windows.Forms.Button();
            this.btnViewHive = new System.Windows.Forms.Button();
            this.btnViewQueen = new System.Windows.Forms.Button();
            this.btnViewMedia = new System.Windows.Forms.Button();
            this.btnInspections = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewYard
            // 
            this.btnViewYard.Location = new System.Drawing.Point(12, 100);
            this.btnViewYard.Name = "btnViewYard";
            this.btnViewYard.Size = new System.Drawing.Size(373, 23);
            this.btnViewYard.TabIndex = 0;
            this.btnViewYard.Text = "View Yard";
            this.btnViewYard.UseVisualStyleBackColor = true;
            this.btnViewYard.Click += new System.EventHandler(this.btnViewYard_Click);
            // 
            // btnViewHive
            // 
            this.btnViewHive.Location = new System.Drawing.Point(12, 129);
            this.btnViewHive.Name = "btnViewHive";
            this.btnViewHive.Size = new System.Drawing.Size(373, 23);
            this.btnViewHive.TabIndex = 1;
            this.btnViewHive.Text = "View Hive";
            this.btnViewHive.UseVisualStyleBackColor = true;
            this.btnViewHive.Click += new System.EventHandler(this.btnViewHive_Click);
            // 
            // btnViewQueen
            // 
            this.btnViewQueen.Location = new System.Drawing.Point(12, 158);
            this.btnViewQueen.Name = "btnViewQueen";
            this.btnViewQueen.Size = new System.Drawing.Size(373, 23);
            this.btnViewQueen.TabIndex = 2;
            this.btnViewQueen.Text = "View Queen";
            this.btnViewQueen.UseVisualStyleBackColor = true;
            this.btnViewQueen.Click += new System.EventHandler(this.btnViewQueen_Click);
            // 
            // btnViewMedia
            // 
            this.btnViewMedia.Location = new System.Drawing.Point(12, 187);
            this.btnViewMedia.Name = "btnViewMedia";
            this.btnViewMedia.Size = new System.Drawing.Size(373, 23);
            this.btnViewMedia.TabIndex = 3;
            this.btnViewMedia.Text = "View Media";
            this.btnViewMedia.UseVisualStyleBackColor = true;
            this.btnViewMedia.Click += new System.EventHandler(this.btnViewMedia_Click);
            // 
            // btnInspections
            // 
            this.btnInspections.Location = new System.Drawing.Point(12, 216);
            this.btnInspections.Name = "btnInspections";
            this.btnInspections.Size = new System.Drawing.Size(373, 23);
            this.btnInspections.TabIndex = 4;
            this.btnInspections.Text = "Inspections";
            this.btnInspections.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Busy Bees Apiary";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(397, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInspections);
            this.Controls.Add(this.btnViewMedia);
            this.Controls.Add(this.btnViewQueen);
            this.Controls.Add(this.btnViewHive);
            this.Controls.Add(this.btnViewYard);
            this.Name = "FrmMain";
            this.Text = "Busy Bees Apiary";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewYard;
        private System.Windows.Forms.Button btnViewHive;
        private System.Windows.Forms.Button btnViewQueen;
        private System.Windows.Forms.Button btnViewMedia;
        private System.Windows.Forms.Button btnInspections;
        private System.Windows.Forms.Label label1;
    }
}