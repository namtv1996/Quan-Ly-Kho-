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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nhan su");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Xem chi tiet");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nhap hang hoa");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Xuat hang hoa");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Khach hang");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Thong ke");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tro giup");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NhanSu";
            treeNode1.Text = "Nhan su";
            treeNode2.Name = "Xem";
            treeNode2.Text = "Xem chi tiet";
            treeNode3.Name = "Nhap";
            treeNode3.Text = "Nhap hang hoa";
            treeNode4.Name = "Xuat";
            treeNode4.Text = "Xuat hang hoa";
            treeNode5.Name = "KhachHang";
            treeNode5.Text = "Khach hang";
            treeNode6.Name = "ThongKe";
            treeNode6.Text = "Thong ke";
            treeNode7.Name = "Help";
            treeNode7.Text = "Tro giup";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(114, 433);
            this.treeView1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(114, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Import";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Export";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Storage";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(633, 433);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 433);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.treeView1);
            this.Name = "FormMain";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}