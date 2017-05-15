namespace QLNhaKho
{
    partial class FormImport
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
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.btnMoreSuppliers = new System.Windows.Forms.Button();
            this.txtCommodityName = new System.Windows.Forms.TextBox();
            this.dtpProductingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiringDate = new System.Windows.Forms.DateTimePicker();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.rtbState = new System.Windows.Forms.RichTextBox();
            this.dtpImportingDate = new System.Windows.Forms.DateTimePicker();
            this.cbxReceived = new System.Windows.Forms.CheckBox();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbStorage = new System.Windows.Forms.ComboBox();
            this.btnMoreStorages = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(98, 32);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(208, 21);
            this.cmbSupplier.TabIndex = 0;
            // 
            // btnMoreSuppliers
            // 
            this.btnMoreSuppliers.Location = new System.Drawing.Point(312, 32);
            this.btnMoreSuppliers.Name = "btnMoreSuppliers";
            this.btnMoreSuppliers.Size = new System.Drawing.Size(38, 22);
            this.btnMoreSuppliers.TabIndex = 1;
            this.btnMoreSuppliers.Text = "...";
            this.btnMoreSuppliers.UseVisualStyleBackColor = true;
            // 
            // txtCommodityName
            // 
            this.txtCommodityName.Location = new System.Drawing.Point(98, 59);
            this.txtCommodityName.Name = "txtCommodityName";
            this.txtCommodityName.Size = new System.Drawing.Size(252, 20);
            this.txtCommodityName.TabIndex = 2;
            // 
            // dtpProductingDate
            // 
            this.dtpProductingDate.Location = new System.Drawing.Point(98, 85);
            this.dtpProductingDate.Name = "dtpProductingDate";
            this.dtpProductingDate.Size = new System.Drawing.Size(252, 20);
            this.dtpProductingDate.TabIndex = 3;
            // 
            // dtpExpiringDate
            // 
            this.dtpExpiringDate.Location = new System.Drawing.Point(98, 111);
            this.dtpExpiringDate.Name = "dtpExpiringDate";
            this.dtpExpiringDate.Size = new System.Drawing.Size(252, 20);
            this.dtpExpiringDate.TabIndex = 4;
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(98, 137);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(252, 20);
            this.txtProducer.TabIndex = 5;
            // 
            // rtbState
            // 
            this.rtbState.Location = new System.Drawing.Point(98, 163);
            this.rtbState.Name = "rtbState";
            this.rtbState.Size = new System.Drawing.Size(252, 53);
            this.rtbState.TabIndex = 6;
            this.rtbState.Text = "";
            // 
            // dtpImportingDate
            // 
            this.dtpImportingDate.Location = new System.Drawing.Point(432, 62);
            this.dtpImportingDate.Name = "dtpImportingDate";
            this.dtpImportingDate.Size = new System.Drawing.Size(237, 20);
            this.dtpImportingDate.TabIndex = 7;
            // 
            // cbxReceived
            // 
            this.cbxReceived.AutoSize = true;
            this.cbxReceived.Location = new System.Drawing.Point(432, 114);
            this.cbxReceived.Name = "cbxReceived";
            this.cbxReceived.Size = new System.Drawing.Size(76, 17);
            this.cbxReceived.TabIndex = 9;
            this.cbxReceived.Text = "Đã nhận ?";
            this.cbxReceived.UseVisualStyleBackColor = true;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(432, 137);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(237, 82);
            this.rtbNote.TabIndex = 10;
            this.rtbNote.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên hàng hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ngày sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hạn sử dụng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nhà sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tình trạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ngày nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ghi chú";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(432, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(513, 252);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(594, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbStorage
            // 
            this.cmbStorage.FormattingEnabled = true;
            this.cmbStorage.Location = new System.Drawing.Point(432, 35);
            this.cmbStorage.Name = "cmbStorage";
            this.cmbStorage.Size = new System.Drawing.Size(196, 21);
            this.cmbStorage.TabIndex = 23;
            // 
            // btnMoreStorages
            // 
            this.btnMoreStorages.Location = new System.Drawing.Point(634, 35);
            this.btnMoreStorages.Name = "btnMoreStorages";
            this.btnMoreStorages.Size = new System.Drawing.Size(35, 21);
            this.btnMoreStorages.TabIndex = 24;
            this.btnMoreStorages.Text = "...";
            this.btnMoreStorages.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Kho";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(432, 89);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(237, 20);
            this.nudAmount.TabIndex = 26;
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 304);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMoreStorages);
            this.Controls.Add(this.cmbStorage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.cbxReceived);
            this.Controls.Add(this.dtpImportingDate);
            this.Controls.Add(this.rtbState);
            this.Controls.Add(this.txtProducer);
            this.Controls.Add(this.dtpExpiringDate);
            this.Controls.Add(this.dtpProductingDate);
            this.Controls.Add(this.txtCommodityName);
            this.Controls.Add(this.btnMoreSuppliers);
            this.Controls.Add(this.cmbSupplier);
            this.Name = "FormImport";
            this.Text = "Phiếu nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormImport_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Button btnMoreSuppliers;
        private System.Windows.Forms.TextBox txtCommodityName;
        private System.Windows.Forms.DateTimePicker dtpProductingDate;
        private System.Windows.Forms.DateTimePicker dtpExpiringDate;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.RichTextBox rtbState;
        private System.Windows.Forms.DateTimePicker dtpImportingDate;
        private System.Windows.Forms.CheckBox cbxReceived;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbStorage;
        private System.Windows.Forms.Button btnMoreStorages;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudAmount;
    }
}