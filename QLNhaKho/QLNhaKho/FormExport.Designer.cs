namespace QLNhaKho
{
    partial class FormExport
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStorageID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCommodityName = new System.Windows.Forms.TextBox();
            this.txtCommodityID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.cbxReceived = new System.Windows.Forms.CheckBox();
            this.dtpReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExportDate = new System.Windows.Forms.DateTimePicker();
            this.nudAmountOfCommodities = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfCommodities)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chon,
            this.soluong});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 16);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(683, 178);
            this.dgvList.TabIndex = 0;
            // 
            // chon
            // 
            this.chon.HeaderText = "Chọn";
            this.chon.Name = "chon";
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStorageID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cmbCustomerID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCommodityName);
            this.groupBox2.Controls.Add(this.txtCommodityID);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rtbNote);
            this.groupBox2.Controls.Add(this.cbxReceived);
            this.groupBox2.Controls.Add(this.dtpReceiveDate);
            this.groupBox2.Controls.Add(this.dtpExportDate);
            this.groupBox2.Controls.Add(this.nudAmountOfCommodities);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // txtStorageID
            // 
            this.txtStorageID.Location = new System.Drawing.Point(435, 171);
            this.txtStorageID.Name = "txtStorageID";
            this.txtStorageID.Size = new System.Drawing.Size(228, 20);
            this.txtStorageID.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã kho";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(103, 39);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(187, 21);
            this.cmbCustomerID.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tên hàng hóa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mã hàng hóa";
            // 
            // txtCommodityName
            // 
            this.txtCommodityName.Location = new System.Drawing.Point(435, 145);
            this.txtCommodityName.Name = "txtCommodityName";
            this.txtCommodityName.Size = new System.Drawing.Size(228, 20);
            this.txtCommodityName.TabIndex = 20;
            // 
            // txtCommodityID
            // 
            this.txtCommodityID.Location = new System.Drawing.Point(103, 145);
            this.txtCommodityID.Name = "txtCommodityID";
            this.txtCommodityID.Size = new System.Drawing.Size(237, 20);
            this.txtCommodityID.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(550, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(469, 203);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày nhận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Chọn số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Khách hàng";
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(435, 39);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(228, 46);
            this.rtbNote.TabIndex = 7;
            this.rtbNote.Text = "";
            // 
            // cbxReceived
            // 
            this.cbxReceived.AutoSize = true;
            this.cbxReceived.Location = new System.Drawing.Point(435, 94);
            this.cbxReceived.Name = "cbxReceived";
            this.cbxReceived.Size = new System.Drawing.Size(76, 17);
            this.cbxReceived.TabIndex = 6;
            this.cbxReceived.Text = "Đã nhận ?";
            this.cbxReceived.UseVisualStyleBackColor = true;
            // 
            // dtpReceiveDate
            // 
            this.dtpReceiveDate.Location = new System.Drawing.Point(103, 91);
            this.dtpReceiveDate.Name = "dtpReceiveDate";
            this.dtpReceiveDate.Size = new System.Drawing.Size(237, 20);
            this.dtpReceiveDate.TabIndex = 5;
            // 
            // dtpExportDate
            // 
            this.dtpExportDate.Location = new System.Drawing.Point(103, 65);
            this.dtpExportDate.Name = "dtpExportDate";
            this.dtpExportDate.Size = new System.Drawing.Size(237, 20);
            this.dtpExportDate.TabIndex = 4;
            // 
            // nudAmountOfCommodities
            // 
            this.nudAmountOfCommodities.Location = new System.Drawing.Point(103, 171);
            this.nudAmountOfCommodities.Name = "nudAmountOfCommodities";
            this.nudAmountOfCommodities.Size = new System.Drawing.Size(237, 20);
            this.nudAmountOfCommodities.TabIndex = 3;
            // 
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormExport";
            this.Text = "Phiếu xuất";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfCommodities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.CheckBox cbxReceived;
        private System.Windows.Forms.DateTimePicker dtpReceiveDate;
        private System.Windows.Forms.DateTimePicker dtpExportDate;
        private System.Windows.Forms.NumericUpDown nudAmountOfCommodities;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCommodityName;
        private System.Windows.Forms.TextBox txtCommodityID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.TextBox txtStorageID;
        private System.Windows.Forms.Label label1;
    }
}