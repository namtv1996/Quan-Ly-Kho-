namespace QLNhaKho
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thong tin nguoi dung");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Them nguoi dung");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nhan su", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Xem chi tiet");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nhap hang hoa");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Xuat hang hoa");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Thong ke");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Tro giup");
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(109, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Import";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Export";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(638, 433);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "ThongTinNguoiDung";
            treeNode1.Text = "Thong tin nguoi dung";
            treeNode2.Name = "ThemNguoiDung";
            treeNode2.Text = "Them nguoi dung";
            treeNode3.Name = "NhanSu";
            treeNode3.Text = "Nhan su";
            treeNode4.Name = "Xem";
            treeNode4.Text = "Xem chi tiet";
            treeNode5.Name = "Nhap";
            treeNode5.Text = "Nhap hang hoa";
            treeNode6.Name = "Xuat";
            treeNode6.Text = "Xuat hang hoa";
            treeNode7.Name = "ThongKe";
            treeNode7.Text = "Thong ke";
            treeNode8.Name = "Help";
            treeNode8.Text = "Tro giup";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(109, 433);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 433);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.chart1);
            this.Name = "FormMain";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TreeView treeView1;
    }
}