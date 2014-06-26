namespace AsimTraders
{
    partial class frmbalance_update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbalance_update));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewInfo = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnViewInfo);
            this.groupBox1.Controls.Add(this.btnInput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 566);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Asim Traders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(22, 40);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewInfo
            // 
            this.btnViewInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnViewInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewInfo.FlatAppearance.BorderSize = 0;
            this.btnViewInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInfo.ForeColor = System.Drawing.Color.Maroon;
            this.btnViewInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewInfo.Location = new System.Drawing.Point(402, 197);
            this.btnViewInfo.Name = "btnViewInfo";
            this.btnViewInfo.Size = new System.Drawing.Size(161, 158);
            this.btnViewInfo.TabIndex = 1;
            this.btnViewInfo.Text = "Bank Accounts";
            this.btnViewInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewInfo.UseVisualStyleBackColor = false;
            // 
            // btnInput
            // 
            this.btnInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInput.BackColor = System.Drawing.Color.Transparent;
            this.btnInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInput.FlatAppearance.BorderSize = 0;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInput.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.ForeColor = System.Drawing.Color.Maroon;
            this.btnInput.Image = ((System.Drawing.Image)(resources.GetObject("btnInput.Image")));
            this.btnInput.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInput.Location = new System.Drawing.Point(206, 197);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(161, 158);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Customer Accounts";
            this.btnInput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // frmbalance_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmbalance_update";
            this.Text = "Add_accounts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_accounts_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewInfo;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}