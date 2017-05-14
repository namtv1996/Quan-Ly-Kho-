namespace QLNhaKho
{
    partial class FormView
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpProductDate = new System.Windows.Forms.DateTimePicker();
            this.rtbState = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.cbxStorage = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 16);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(691, 171);
            this.dgvList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReport);
            this.groupBox2.Controls.Add(this.nudAmount);
            this.groupBox2.Controls.Add(this.cmbSupplier);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtProducer);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSearchBox);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnImport);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpEntryDate);
            this.groupBox2.Controls.Add(this.dtpExpireDate);
            this.groupBox2.Controls.Add(this.dtpProductDate);
            this.groupBox2.Controls.Add(this.rtbState);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.txtPlace);
            this.groupBox2.Controls.Add(this.cbxStorage);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(270, 212);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 30;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(444, 166);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(239, 20);
            this.nudAmount.TabIndex = 29;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(101, 165);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(244, 21);
            this.cmbSupplier.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Nhà cung cấp";
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(444, 114);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(239, 20);
            this.txtProducer.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ngày nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nhà sản xuất";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Số lượng tồn";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(274, 258);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tìm kiếm";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchBox.Location = new System.Drawing.Point(68, 260);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(200, 20);
            this.txtSearchBox.TabIndex = 20;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(608, 212);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Cập nhật";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(80, 212);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(86, 23);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Xuất hàng hóa";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(527, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(446, 212);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(172, 212);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(92, 23);
            this.btnImport.TabIndex = 15;
            this.btnImport.Text = "Nhập hàng hóa";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hạn sử dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày sản xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tình trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên hàng hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã hàng hóa";
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Location = new System.Drawing.Point(444, 140);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(239, 20);
            this.dtpEntryDate.TabIndex = 9;
            // 
            // dtpExpireDate
            // 
            this.dtpExpireDate.Location = new System.Drawing.Point(444, 88);
            this.dtpExpireDate.Name = "dtpExpireDate";
            this.dtpExpireDate.Size = new System.Drawing.Size(239, 20);
            this.dtpExpireDate.TabIndex = 6;
            // 
            // dtpProductDate
            // 
            this.dtpProductDate.Location = new System.Drawing.Point(444, 62);
            this.dtpProductDate.Name = "dtpProductDate";
            this.dtpProductDate.Size = new System.Drawing.Size(239, 20);
            this.dtpProductDate.TabIndex = 5;
            // 
            // rtbState
            // 
            this.rtbState.Location = new System.Drawing.Point(101, 113);
            this.rtbState.Name = "rtbState";
            this.rtbState.Size = new System.Drawing.Size(244, 46);
            this.rtbState.TabIndex = 4;
            this.rtbState.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(101, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(244, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(533, 19);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(158, 20);
            this.txtPlace.TabIndex = 1;
            // 
            // cbxStorage
            // 
            this.cbxStorage.FormattingEnabled = true;
            this.cbxStorage.Location = new System.Drawing.Point(363, 19);
            this.cbxStorage.Name = "cbxStorage";
            this.cbxStorage.Size = new System.Drawing.Size(158, 21);
            this.cbxStorage.TabIndex = 0;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormView";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.ComboBox cbxStorage;
        private System.Windows.Forms.RichTextBox rtbState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.DateTimePicker dtpExpireDate;
        private System.Windows.Forms.DateTimePicker dtpProductDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnReport;
    }
}

