namespace AsimTraders
{
    partial class frmCustomer_OrderReg
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOr_id = new System.Windows.Forms.TextBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcus_id = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPaid_Amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCur_credit = new System.Windows.Forms.TextBox();
            this.txtcur_debit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPay_Amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPre_credit = new System.Windows.Forms.TextBox();
            this.txtpre_debit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cgfg = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOr_id);
            this.groupBox1.Controls.Add(this.cbName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcus_id);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 566);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(501, 97);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "DATE";
            // 
            // txtOr_id
            // 
            this.txtOr_id.Enabled = false;
            this.txtOr_id.Location = new System.Drawing.Point(501, 33);
            this.txtOr_id.Name = "txtOr_id";
            this.txtOr_id.Size = new System.Drawing.Size(171, 20);
            this.txtOr_id.TabIndex = 9;
            this.txtOr_id.Text = "0";
            // 
            // cbName
            // 
            this.cbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(192, 96);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(171, 28);
            this.cbName.TabIndex = 0;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Name";
            // 
            // txtcus_id
            // 
            this.txtcus_id.Enabled = false;
            this.txtcus_id.Location = new System.Drawing.Point(192, 33);
            this.txtcus_id.Name = "txtcus_id";
            this.txtcus_id.Size = new System.Drawing.Size(171, 20);
            this.txtcus_id.TabIndex = 6;
            this.txtcus_id.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtPaid_Amount);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCur_credit);
            this.groupBox3.Controls.Add(this.txtcur_debit);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtPay_Amount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtPre_credit);
            this.groupBox3.Controls.Add(this.txtpre_debit);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cgfg);
            this.groupBox3.Controls.Add(this.dgvOrder);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(18, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(815, 424);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Customer Order";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(194, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 27);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPaid_Amount
            // 
            this.txtPaid_Amount.Location = new System.Drawing.Point(634, 313);
            this.txtPaid_Amount.Name = "txtPaid_Amount";
            this.txtPaid_Amount.Size = new System.Drawing.Size(113, 26);
            this.txtPaid_Amount.TabIndex = 1;
            this.txtPaid_Amount.Text = "0";
            this.txtPaid_Amount.TextChanged += new System.EventHandler(this.txtPaid_Amount_TextChanged);
            this.txtPaid_Amount.Leave += new System.EventHandler(this.txtPaid_Amount_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 82;
            this.label6.Text = "Paid Amount";
            // 
            // txtCur_credit
            // 
            this.txtCur_credit.Enabled = false;
            this.txtCur_credit.Location = new System.Drawing.Point(125, 313);
            this.txtCur_credit.Name = "txtCur_credit";
            this.txtCur_credit.Size = new System.Drawing.Size(113, 26);
            this.txtCur_credit.TabIndex = 78;
            this.txtCur_credit.Text = "0";
            // 
            // txtcur_debit
            // 
            this.txtcur_debit.Enabled = false;
            this.txtcur_debit.Location = new System.Drawing.Point(383, 313);
            this.txtcur_debit.Name = "txtcur_debit";
            this.txtcur_debit.Size = new System.Drawing.Size(113, 26);
            this.txtcur_debit.TabIndex = 79;
            this.txtcur_debit.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 19);
            this.label7.TabIndex = 80;
            this.label7.Text = "Current Debit ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 77;
            this.label8.Text = "Current Credit";
            // 
            // txtPay_Amount
            // 
            this.txtPay_Amount.Enabled = false;
            this.txtPay_Amount.Location = new System.Drawing.Point(634, 252);
            this.txtPay_Amount.Name = "txtPay_Amount";
            this.txtPay_Amount.Size = new System.Drawing.Size(113, 26);
            this.txtPay_Amount.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 76;
            this.label5.Text = "Payable Amount";
            // 
            // txtPre_credit
            // 
            this.txtPre_credit.Enabled = false;
            this.txtPre_credit.Location = new System.Drawing.Point(125, 252);
            this.txtPre_credit.Name = "txtPre_credit";
            this.txtPre_credit.Size = new System.Drawing.Size(113, 26);
            this.txtPre_credit.TabIndex = 71;
            this.txtPre_credit.Text = "0";
            // 
            // txtpre_debit
            // 
            this.txtpre_debit.Enabled = false;
            this.txtpre_debit.Location = new System.Drawing.Point(383, 252);
            this.txtpre_debit.Name = "txtpre_debit";
            this.txtpre_debit.Size = new System.Drawing.Size(113, 26);
            this.txtpre_debit.TabIndex = 72;
            this.txtpre_debit.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 19);
            this.label11.TabIndex = 73;
            this.label11.Text = "Previous Debit ";
            // 
            // cgfg
            // 
            this.cgfg.AutoSize = true;
            this.cgfg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgfg.Location = new System.Drawing.Point(6, 255);
            this.cgfg.Name = "cgfg";
            this.cgfg.Size = new System.Drawing.Size(113, 19);
            this.cgfg.TabIndex = 70;
            this.cgfg.Text = "Previous Credit";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowDrop = true;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeight = 30;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvOrder.Location = new System.Drawing.Point(10, 55);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(799, 150);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.Leave += new System.EventHandler(this.dgvOrder_Leave);
            this.dgvOrder.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_RowLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column1.HeaderText = "Item";
            this.Column1.Items.AddRange(new object[] {
            "Sugar_ittefaq",
            "Sugar_private",
            "Nemat_teen_16",
            "Nemat_teen_10",
            "Nemat_gatta_16",
            "Nemat_gatta_10",
            "Nemat_gatta_5",
            "Nemat_balty_16",
            "Nemat_balty_10",
            "Nemat_balty_5",
            "Nemat_balty_2_5",
            "Nemat_saban",
            "Salva_teen_16",
            "Salva_teen_10",
            "Salva_gata_16",
            "Salva_gata_10",
            "Salva_gata_5",
            "Salva_balty_16",
            "Salva_balty_10",
            "Salva_balty_5",
            "Salva_balty_2_5",
            "Salva_oil_5",
            "Pakwan_oil_16",
            "ATTA_20",
            "Meeda_40",
            "chokar_24",
            "sooji_50",
            "Rehmat_teen_16",
            "Rehmat_gata_16",
            "Rehmat_gata_12",
            "Rehmat_gata_6"});
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Amount";
            this.Column5.Name = "Column5";
            // 
            // frmCustomer_OrderReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 566);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmCustomer_OrderReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input_Order";
            this.Load += new System.EventHandler(this.Input_Customer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInputOrder_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOr_id;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcus_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TextBox txtPre_credit;
        private System.Windows.Forms.TextBox txtpre_debit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label cgfg;
        private System.Windows.Forms.TextBox txtPay_Amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaid_Amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCur_credit;
        private System.Windows.Forms.TextBox txtcur_debit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}