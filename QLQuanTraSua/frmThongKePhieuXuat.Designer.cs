namespace QLQuanTraSua
{
	partial class frmThongKePhieuXuat
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKePhieuXuat));
			this.lbTừNgày = new System.Windows.Forms.Label();
			this.groupBoxthongtin = new System.Windows.Forms.GroupBox();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.btTongTien = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsThongKe = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.tsThoat = new System.Windows.Forms.ToolStripButton();
			this.lbDenNgay = new System.Windows.Forms.Label();
			this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
			this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
			this.cbKieuThongKe = new System.Windows.Forms.ComboBox();
			this.groupBoxchitiet = new System.Windows.Forms.GroupBox();
			this.dgThongKepx = new System.Windows.Forms.DataGridView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lbThongKePhieuXuat = new System.Windows.Forms.Label();
			this.groupBoxthongtin.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.groupBoxchitiet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgThongKepx)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbTừNgày
			// 
			this.lbTừNgày.AutoSize = true;
			this.lbTừNgày.Location = new System.Drawing.Point(288, 72);
			this.lbTừNgày.Name = "lbTừNgày";
			this.lbTừNgày.Size = new System.Drawing.Size(54, 16);
			this.lbTừNgày.TabIndex = 2;
			this.lbTừNgày.Text = "Từ ngày";
			// 
			// groupBoxthongtin
			// 
			this.groupBoxthongtin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.groupBoxthongtin.Controls.Add(this.txtTongTien);
			this.groupBoxthongtin.Controls.Add(this.btTongTien);
			this.groupBoxthongtin.Controls.Add(this.toolStrip1);
			this.groupBoxthongtin.Controls.Add(this.lbDenNgay);
			this.groupBoxthongtin.Controls.Add(this.lbTừNgày);
			this.groupBoxthongtin.Controls.Add(this.dtpDenNgay);
			this.groupBoxthongtin.Controls.Add(this.dtpTuNgay);
			this.groupBoxthongtin.Controls.Add(this.cbKieuThongKe);
			this.groupBoxthongtin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxthongtin.Location = new System.Drawing.Point(0, 8);
			this.groupBoxthongtin.Name = "groupBoxthongtin";
			this.groupBoxthongtin.Size = new System.Drawing.Size(872, 152);
			this.groupBoxthongtin.TabIndex = 0;
			this.groupBoxthongtin.TabStop = false;
			this.groupBoxthongtin.Text = "Thống kê";
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(752, 120);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.Size = new System.Drawing.Size(100, 23);
			this.txtTongTien.TabIndex = 9;
			// 
			// btTongTien
			// 
			this.btTongTien.Location = new System.Drawing.Point(672, 120);
			this.btTongTien.Name = "btTongTien";
			this.btTongTien.Size = new System.Drawing.Size(75, 23);
			this.btTongTien.TabIndex = 8;
			this.btTongTien.Text = "Tổng Tiền";
			this.btTongTien.UseVisualStyleBackColor = true;
			this.btTongTien.Click += new System.EventHandler(this.btTongTien_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThongKe,
            this.toolStripButton1,
            this.tsThoat});
			this.toolStrip1.Location = new System.Drawing.Point(3, 19);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(866, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsThongKe
			// 
			this.tsThongKe.Image = ((System.Drawing.Image)(resources.GetObject("tsThongKe.Image")));
			this.tsThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsThongKe.Name = "tsThongKe";
			this.tsThongKe.Size = new System.Drawing.Size(76, 22);
			this.tsThongKe.Text = "Thống kê";
			this.tsThongKe.Click += new System.EventHandler(this.tsThongKe_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(75, 22);
			this.toolStripButton1.Text = "Làm Mới";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// tsThoat
			// 
			this.tsThoat.Image = ((System.Drawing.Image)(resources.GetObject("tsThoat.Image")));
			this.tsThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsThoat.Name = "tsThoat";
			this.tsThoat.Size = new System.Drawing.Size(57, 22);
			this.tsThoat.Text = "Thoát";
			this.tsThoat.Click += new System.EventHandler(this.tsThoat_Click);
			// 
			// lbDenNgay
			// 
			this.lbDenNgay.AutoSize = true;
			this.lbDenNgay.Location = new System.Drawing.Point(584, 64);
			this.lbDenNgay.Name = "lbDenNgay";
			this.lbDenNgay.Size = new System.Drawing.Size(62, 16);
			this.lbDenNgay.TabIndex = 4;
			this.lbDenNgay.Text = "Đến Ngày";
			// 
			// dtpDenNgay
			// 
			this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDenNgay.Location = new System.Drawing.Point(656, 64);
			this.dtpDenNgay.Name = "dtpDenNgay";
			this.dtpDenNgay.Size = new System.Drawing.Size(200, 23);
			this.dtpDenNgay.TabIndex = 5;
			// 
			// dtpTuNgay
			// 
			this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTuNgay.Location = new System.Drawing.Point(360, 64);
			this.dtpTuNgay.Name = "dtpTuNgay";
			this.dtpTuNgay.Size = new System.Drawing.Size(200, 23);
			this.dtpTuNgay.TabIndex = 3;
			// 
			// cbKieuThongKe
			// 
			this.cbKieuThongKe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbKieuThongKe.FormattingEnabled = true;
			this.cbKieuThongKe.Items.AddRange(new object[] {
            "Thống kê ngày",
            "Thống kê tháng",
            "Thống kê năm"});
			this.cbKieuThongKe.Location = new System.Drawing.Point(8, 64);
			this.cbKieuThongKe.Name = "cbKieuThongKe";
			this.cbKieuThongKe.Size = new System.Drawing.Size(200, 24);
			this.cbKieuThongKe.TabIndex = 1;
			this.cbKieuThongKe.Text = "Chọn kiểu thống kê";
			this.cbKieuThongKe.SelectedIndexChanged += new System.EventHandler(this.cbKieuThongKe_SelectedIndexChanged);
			// 
			// groupBoxchitiet
			// 
			this.groupBoxchitiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.groupBoxchitiet.Controls.Add(this.dgThongKepx);
			this.groupBoxchitiet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxchitiet.Location = new System.Drawing.Point(0, 160);
			this.groupBoxchitiet.Name = "groupBoxchitiet";
			this.groupBoxchitiet.Size = new System.Drawing.Size(880, 192);
			this.groupBoxchitiet.TabIndex = 1;
			this.groupBoxchitiet.TabStop = false;
			this.groupBoxchitiet.Text = "Chi tiết";
			// 
			// dgThongKepx
			// 
			this.dgThongKepx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgThongKepx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgThongKepx.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgThongKepx.Location = new System.Drawing.Point(3, 29);
			this.dgThongKepx.Name = "dgThongKepx";
			this.dgThongKepx.Size = new System.Drawing.Size(874, 160);
			this.dgThongKepx.TabIndex = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.splitContainer1.Panel1.Controls.Add(this.lbThongKePhieuXuat);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxchitiet);
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxthongtin);
			this.splitContainer1.Size = new System.Drawing.Size(877, 450);
			this.splitContainer1.SplitterDistance = 58;
			this.splitContainer1.TabIndex = 1;
			// 
			// lbThongKePhieuXuat
			// 
			this.lbThongKePhieuXuat.AutoSize = true;
			this.lbThongKePhieuXuat.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbThongKePhieuXuat.Location = new System.Drawing.Point(256, 8);
			this.lbThongKePhieuXuat.Name = "lbThongKePhieuXuat";
			this.lbThongKePhieuXuat.Size = new System.Drawing.Size(298, 29);
			this.lbThongKePhieuXuat.TabIndex = 0;
			this.lbThongKePhieuXuat.Text = "THỐNG KÊ PHIẾU XUẤT";
			// 
			// frmThongKePhieuXuat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(877, 450);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmThongKePhieuXuat";
			this.Text = "frmThongKePhieuXuat";
			this.Load += new System.EventHandler(this.frmThongKePhieuXuat_Load);
			this.groupBoxthongtin.ResumeLayout(false);
			this.groupBoxthongtin.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBoxchitiet.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgThongKepx)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbTừNgày;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton tsThoat;
		private System.Windows.Forms.GroupBox groupBoxthongtin;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.Button btTongTien;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsThongKe;
		private System.Windows.Forms.Label lbDenNgay;
		private System.Windows.Forms.DateTimePicker dtpDenNgay;
		private System.Windows.Forms.DateTimePicker dtpTuNgay;
		private System.Windows.Forms.ComboBox cbKieuThongKe;
		private System.Windows.Forms.GroupBox groupBoxchitiet;
		private System.Windows.Forms.DataGridView dgThongKepx;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label lbThongKePhieuXuat;
	}
}