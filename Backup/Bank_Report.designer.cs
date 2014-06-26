namespace AsimTraders
{
    partial class frmBankReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBioData = new System.Windows.Forms.Button();
            this.btnGeneal = new System.Windows.Forms.Button();
            this.headPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.headPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-1, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 424);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.btnBioData);
            this.panel4.Controls.Add(this.btnGeneal);
            this.panel4.Location = new System.Drawing.Point(145, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(465, 109);
            this.panel4.TabIndex = 5;
            // 
            // btnBioData
            // 
            this.btnBioData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBioData.BackgroundImage")));
            this.btnBioData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBioData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBioData.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBioData.Image = ((System.Drawing.Image)(resources.GetObject("btnBioData.Image")));
            this.btnBioData.Location = new System.Drawing.Point(245, 3);
            this.btnBioData.Name = "btnBioData";
            this.btnBioData.Size = new System.Drawing.Size(195, 100);
            this.btnBioData.TabIndex = 2;
            this.btnBioData.Text = "Balance Update Report";
            this.btnBioData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBioData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBioData.UseVisualStyleBackColor = true;
            this.btnBioData.Click += new System.EventHandler(this.btnBioData_Click);
            // 
            // btnGeneal
            // 
            this.btnGeneal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeneal.BackgroundImage")));
            this.btnGeneal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeneal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneal.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGeneal.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneal.Image")));
            this.btnGeneal.Location = new System.Drawing.Point(22, 3);
            this.btnGeneal.Name = "btnGeneal";
            this.btnGeneal.Size = new System.Drawing.Size(195, 100);
            this.btnGeneal.TabIndex = 1;
            this.btnGeneal.Text = "Banking Report";
            this.btnGeneal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeneal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGeneal.UseVisualStyleBackColor = true;
            this.btnGeneal.Click += new System.EventHandler(this.btnbtnGeneal_Click);
            // 
            // headPanel
            // 
            this.headPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.headPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headPanel.Controls.Add(this.button1);
            this.headPanel.Controls.Add(this.label1);
            this.headPanel.Location = new System.Drawing.Point(0, 1);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(717, 110);
            this.headPanel.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Asim Traders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBankReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(744, 562);
            this.Controls.Add(this.headPanel);
            this.Controls.Add(this.panel1);
            this.Name = "frmBankReport";
            this.Tag = "Bank Report";
            this.Text = "Bank Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBankReport_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGeneal;
        private System.Windows.Forms.Button btnBioData;
        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;        
    }
}