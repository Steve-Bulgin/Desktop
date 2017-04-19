namespace BusyBeesDesktop
{
    partial class FrmHive
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
            this.listHive = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHive = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblConfig = new System.Windows.Forms.Label();
            this.lblYard = new System.Windows.Forms.Label();
            this.lblSplit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listHive
            // 
            this.listHive.FormattingEnabled = true;
            this.listHive.Location = new System.Drawing.Point(12, 42);
            this.listHive.Name = "listHive";
            this.listHive.Size = new System.Drawing.Size(162, 160);
            this.listHive.TabIndex = 0;
            this.listHive.SelectedIndexChanged += new System.EventHandler(this.listHive_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select A Hive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Configuration Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "What Yard:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Year Sourced:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hive Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hive Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Split Type:";
            // 
            // lblHive
            // 
            this.lblHive.AutoSize = true;
            this.lblHive.Location = new System.Drawing.Point(434, 63);
            this.lblHive.Name = "lblHive";
            this.lblHive.Size = new System.Drawing.Size(0, 13);
            this.lblHive.TabIndex = 8;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(434, 92);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 13);
            this.lblType.TabIndex = 9;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(434, 120);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(0, 13);
            this.lblSource.TabIndex = 10;
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Location = new System.Drawing.Point(434, 148);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(0, 13);
            this.lblConfig.TabIndex = 11;
            // 
            // lblYard
            // 
            this.lblYard.AutoSize = true;
            this.lblYard.Location = new System.Drawing.Point(434, 176);
            this.lblYard.Name = "lblYard";
            this.lblYard.Size = new System.Drawing.Size(0, 13);
            this.lblYard.TabIndex = 12;
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.Location = new System.Drawing.Point(434, 203);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(0, 13);
            this.lblSplit.TabIndex = 13;
            // 
            // FrmHive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 320);
            this.Controls.Add(this.lblSplit);
            this.Controls.Add(this.lblYard);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblHive);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listHive);
            this.Name = "FrmHive";
            this.Text = "FrmHive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHive_FormClosing);
            this.Load += new System.EventHandler(this.FrmHive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listHive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHive;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Label lblYard;
        private System.Windows.Forms.Label lblSplit;
    }
}