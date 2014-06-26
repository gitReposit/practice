namespace AsimTraders
{
    partial class frmStalks_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStalks_Menu));
            this.headPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBioData = new System.Windows.Forms.Button();
            this.btnGeneal = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.headPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.headPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headPanel.Controls.Add(this.label2);
            this.headPanel.Controls.Add(this.dateTimePicker1);
            this.headPanel.Controls.Add(this.label1);
            this.headPanel.Controls.Add(this.panel4);
            this.headPanel.Controls.Add(this.btnBack);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(744, 562);
            this.headPanel.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "Asim Traders";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 62);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "DATE(view daily sale)";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnBioData);
            this.panel4.Controls.Add(this.btnGeneal);
            this.panel4.Location = new System.Drawing.Point(22, 251);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(686, 109);
            this.panel4.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(472, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Stalk Remaing";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBioData
            // 
            this.btnBioData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBioData.BackgroundImage")));
            this.btnBioData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBioData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBioData.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBioData.Image = ((System.Drawing.Image)(resources.GetObject("btnBioData.Image")));
            this.btnBioData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBioData.Location = new System.Drawing.Point(245, 3);
            this.btnBioData.Name = "btnBioData";
            this.btnBioData.Size = new System.Drawing.Size(195, 100);
            this.btnBioData.TabIndex = 2;
            this.btnBioData.Text = "View Daily report";
            this.btnBioData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBioData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBioData.UseVisualStyleBackColor = true;
            this.btnBioData.Click += new System.EventHandler(this.btnBioData_Click_1);
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
            this.btnGeneal.Text = "Stalks Update";
            this.btnGeneal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeneal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGeneal.UseVisualStyleBackColor = true;
            this.btnGeneal.Click += new System.EventHandler(this.btnGeneal_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmStalks_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(744, 562);
            this.Controls.Add(this.headPanel);
            this.Name = "frmStalks_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Stalks_Menu";
            this.Text = "Stalks_Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStalks_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBioData;
        private System.Windows.Forms.Button btnGeneal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;        
    }
}