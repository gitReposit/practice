namespace AsimTraders
{
    partial class frmBalnce
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCur_credit = new System.Windows.Forms.TextBox();
            this.txtcur_debit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxPaidAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcus_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOr_id = new System.Windows.Forms.TextBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxCredit = new System.Windows.Forms.TextBox();
            this.txtbxDebit = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCur_credit);
            this.groupBox1.Controls.Add(this.txtcur_debit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbxPaidAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtcus_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOr_id);
            this.groupBox1.Controls.Add(this.cbName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtbxCredit);
            this.groupBox1.Controls.Add(this.txtbxDebit);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 491);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 89;
            this.label9.Text = "Current Debit";
            // 
            // txtCur_credit
            // 
            this.txtCur_credit.Enabled = false;
            this.txtCur_credit.Location = new System.Drawing.Point(187, 377);
            this.txtCur_credit.Name = "txtCur_credit";
            this.txtCur_credit.Size = new System.Drawing.Size(171, 20);
            this.txtCur_credit.TabIndex = 87;
            this.txtCur_credit.Text = "0";
            // 
            // txtcur_debit
            // 
            this.txtcur_debit.Enabled = false;
            this.txtcur_debit.Location = new System.Drawing.Point(187, 417);
            this.txtcur_debit.Name = "txtcur_debit";
            this.txtcur_debit.Size = new System.Drawing.Size(171, 20);
            this.txtcur_debit.TabIndex = 88;
            this.txtcur_debit.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 19);
            this.label10.TabIndex = 86;
            this.label10.Text = "Current Credit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 85;
            this.label1.Text = "Amount Paid";
            // 
            // txtbxPaidAmount
            // 
            this.txtbxPaidAmount.Location = new System.Drawing.Point(186, 337);
            this.txtbxPaidAmount.Name = "txtbxPaidAmount";
            this.txtbxPaidAmount.Size = new System.Drawing.Size(171, 20);
            this.txtbxPaidAmount.TabIndex = 2;
            this.txtbxPaidAmount.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 83;
            this.label8.Text = "Customer ID";
            // 
            // txtcus_id
            // 
            this.txtcus_id.Enabled = false;
            this.txtcus_id.Location = new System.Drawing.Point(187, 177);
            this.txtcus_id.Name = "txtcus_id";
            this.txtcus_id.Size = new System.Drawing.Size(171, 20);
            this.txtcus_id.TabIndex = 82;
            this.txtcus_id.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 81;
            this.label2.Text = "Order ID";
            // 
            // txtOr_id
            // 
            this.txtOr_id.Enabled = false;
            this.txtOr_id.Location = new System.Drawing.Point(186, 217);
            this.txtOr_id.Name = "txtOr_id";
            this.txtOr_id.Size = new System.Drawing.Size(171, 20);
            this.txtOr_id.TabIndex = 80;
            this.txtOr_id.Text = "0";
            // 
            // cbName
            // 
            this.cbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(187, 136);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(171, 21);
            this.cbName.TabIndex = 1;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 78;
            this.label3.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(182, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 77;
            this.label7.Text = "Asim Traders";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 72;
            this.label5.Text = "Credit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 71;
            this.label6.Text = "Debit";
            // 
            // txtbxCredit
            // 
            this.txtbxCredit.Location = new System.Drawing.Point(187, 257);
            this.txtbxCredit.Name = "txtbxCredit";
            this.txtbxCredit.Size = new System.Drawing.Size(171, 20);
            this.txtbxCredit.TabIndex = 68;
            // 
            // txtbxDebit
            // 
            this.txtbxDebit.Location = new System.Drawing.Point(187, 297);
            this.txtbxDebit.Name = "txtbxDebit";
            this.txtbxDebit.Size = new System.Drawing.Size(171, 20);
            this.txtbxDebit.TabIndex = 67;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(372, 456);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(297, 83);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 61;
            this.label4.Text = "DATE";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(244, 456);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBalnce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 491);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmBalnce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.banking_FormClosing);
            this.Load += new System.EventHandler(this.banking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxCredit;
        private System.Windows.Forms.TextBox txtbxDebit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOr_id;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcus_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxPaidAmount;
        private System.Windows.Forms.TextBox txtCur_credit;
        private System.Windows.Forms.TextBox txtcur_debit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}