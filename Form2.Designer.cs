namespace AsimTraders
{
    partial class frmAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounts));
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.btnCus_Balance = new System.Windows.Forms.Button();
            this.btnIst_order = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddAccounts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewCases = new System.Windows.Forms.Button();
            this.HeadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.HeadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadPanel.Controls.Add(this.btnCus_Balance);
            this.HeadPanel.Controls.Add(this.btnIst_order);
            this.HeadPanel.Controls.Add(this.button1);
            this.HeadPanel.Controls.Add(this.btnInput);
            this.HeadPanel.Controls.Add(this.btnBack);
            this.HeadPanel.Controls.Add(this.btnAddAccounts);
            this.HeadPanel.Controls.Add(this.label1);
            this.HeadPanel.Controls.Add(this.btnViewCases);
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(804, 499);
            this.HeadPanel.TabIndex = 38;
            // 
            // btnCus_Balance
            // 
            this.btnCus_Balance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCus_Balance.BackColor = System.Drawing.Color.Transparent;
            this.btnCus_Balance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCus_Balance.FlatAppearance.BorderSize = 0;
            this.btnCus_Balance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCus_Balance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCus_Balance.ForeColor = System.Drawing.Color.Maroon;
            this.btnCus_Balance.Image = ((System.Drawing.Image)(resources.GetObject("btnCus_Balance.Image")));
            this.btnCus_Balance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCus_Balance.Location = new System.Drawing.Point(604, 305);
            this.btnCus_Balance.Name = "btnCus_Balance";
            this.btnCus_Balance.Size = new System.Drawing.Size(161, 158);
            this.btnCus_Balance.TabIndex = 7;
            this.btnCus_Balance.Text = "Customer\r\nBalance";
            this.btnCus_Balance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCus_Balance.UseVisualStyleBackColor = false;
            this.btnCus_Balance.Click += new System.EventHandler(this.btnCus_Balance_Click);
            // 
            // btnIst_order
            // 
            this.btnIst_order.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIst_order.BackColor = System.Drawing.Color.Transparent;
            this.btnIst_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIst_order.FlatAppearance.BorderSize = 0;
            this.btnIst_order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIst_order.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIst_order.ForeColor = System.Drawing.Color.Maroon;
            this.btnIst_order.Image = ((System.Drawing.Image)(resources.GetObject("btnIst_order.Image")));
            this.btnIst_order.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIst_order.Location = new System.Drawing.Point(319, 305);
            this.btnIst_order.Name = "btnIst_order";
            this.btnIst_order.Size = new System.Drawing.Size(161, 158);
            this.btnIst_order.TabIndex = 5;
            this.btnIst_order.Text = "1st Customer Order";
            this.btnIst_order.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIst_order.UseVisualStyleBackColor = false;
            this.btnIst_order.Click += new System.EventHandler(this.btnIst_order_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(34, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 158);
            this.button1.TabIndex = 4;
            this.button1.Text = "Unknown Customer";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.btnInput.Location = new System.Drawing.Point(34, 107);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(161, 158);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Customer Order";
            this.btnInput.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddAccounts
            // 
            this.btnAddAccounts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddAccounts.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAccounts.FlatAppearance.BorderSize = 0;
            this.btnAddAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAccounts.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccounts.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddAccounts.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAccounts.Image")));
            this.btnAddAccounts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddAccounts.Location = new System.Drawing.Point(604, 107);
            this.btnAddAccounts.Name = "btnAddAccounts";
            this.btnAddAccounts.Size = new System.Drawing.Size(161, 158);
            this.btnAddAccounts.TabIndex = 3;
            this.btnAddAccounts.Text = "ADD Accounts";
            this.btnAddAccounts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddAccounts.UseVisualStyleBackColor = false;
            this.btnAddAccounts.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asim Traders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewCases
            // 
            this.btnViewCases.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewCases.BackColor = System.Drawing.Color.Transparent;
            this.btnViewCases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewCases.FlatAppearance.BorderSize = 0;
            this.btnViewCases.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewCases.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCases.ForeColor = System.Drawing.Color.Maroon;
            this.btnViewCases.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCases.Image")));
            this.btnViewCases.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewCases.Location = new System.Drawing.Point(319, 107);
            this.btnViewCases.Name = "btnViewCases";
            this.btnViewCases.Size = new System.Drawing.Size(161, 158);
            this.btnViewCases.TabIndex = 2;
            this.btnViewCases.Text = "Bank Management";
            this.btnViewCases.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewCases.UseVisualStyleBackColor = false;
            this.btnViewCases.Click += new System.EventHandler(this.btnViewCases_Click);
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 499);
            this.Controls.Add(this.HeadPanel);
            this.Name = "frmAccounts";
            this.Text = "Accounts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAccounts_FormClosing);
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewCases;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnAddAccounts;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIst_order;
        private System.Windows.Forms.Button btnCus_Balance;
    }
}