namespace QLQuanTraSua
{
	partial class frmQuanLyPhieuXuat
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyPhieuXuat));
			this.txtMapx = new System.Windows.Forms.ComboBox();
			this.cbManv = new System.Windows.Forms.ComboBox();
			this.lbMaNhanVien = new System.Windows.Forms.Label();
			this.cbBanSo = new System.Windows.Forms.ComboBox();
			this.lbBanSo = new System.Windows.Forms.Label();
			this.lbMaPhieuXuat = new System.Windows.Forms.Label();
			this.dgPhieuXuat = new System.Windows.Forms.DataGridView();
			this.lbNgayXuat = new System.Windows.Forms.Label();
			this.groupBoxdasachpx = new System.Windows.Forms.GroupBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lbQuanLyPhieuXuat = new System.Windows.Forms.Label();
			this.groupBoxchucnangpx = new System.Windows.Forms.GroupBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tstThem = new System.Windows.Forms.ToolStripButton();
			this.tstLamMoi = new System.Windows.Forms.ToolStripButton();
			this.tstChiTietPhieuXuat = new System.Windows.Forms.ToolStripButton();
			this.tsXoa = new System.Windows.Forms.ToolStripButton();
			this.tsTimKiem = new System.Windows.Forms.ToolStripButton();
			this.tstThoat = new System.Windows.Forms.ToolStripButton();
			this.tsQuayLai = new System.Windows.Forms.ToolStripButton();
			this.grbThongTin = new System.Windows.Forms.GroupBox();
			this.msNgayBan = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgPhieuXuat)).BeginInit();
			this.groupBoxdasachpx.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBoxchucnangpx.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.grbThongTin.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtMapx
			// 
			this.txtMapx.FormattingEnabled = true;
			this.txtMapx.Items.AddRange(new object[] {
            "px01",
            "px02",
            "px03",
            "px04",
            "px05",
            "px06",
            "px07",
            "px08",
            "px09"});
			this.txtMapx.Location = new System.Drawing.Point(104, 27);
			this.txtMapx.Name = "txtMapx";
			this.txtMapx.Size = new System.Drawing.Size(248, 21);
			this.txtMapx.TabIndex = 16;
			// 
			// cbManv
			// 
			this.cbManv.FormattingEnabled = true;
			this.cbManv.Location = new System.Drawing.Point(464, 27);
			this.cbManv.Name = "cbManv";
			this.cbManv.Size = new System.Drawing.Size(248, 21);
			this.cbManv.TabIndex = 3;
			// 
			// lbMaNhanVien
			// 
			this.lbMaNhanVien.AutoSize = true;
			this.lbMaNhanVien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaNhanVien.Location = new System.Drawing.Point(372, 33);
			this.lbMaNhanVien.Name = "lbMaNhanVien";
			this.lbMaNhanVien.Size = new System.Drawing.Size(83, 16);
			this.lbMaNhanVien.TabIndex = 2;
			this.lbMaNhanVien.Text = "Mã nhân viên";
			// 
			// cbBanSo
			// 
			this.cbBanSo.FormattingEnabled = true;
			this.cbBanSo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
			this.cbBanSo.Location = new System.Drawing.Point(464, 64);
			this.cbBanSo.Name = "cbBanSo";
			this.cbBanSo.Size = new System.Drawing.Size(248, 21);
			this.cbBanSo.TabIndex = 7;
			// 
			// lbBanSo
			// 
			this.lbBanSo.AutoSize = true;
			this.lbBanSo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBanSo.Location = new System.Drawing.Point(372, 65);
			this.lbBanSo.Name = "lbBanSo";
			this.lbBanSo.Size = new System.Drawing.Size(45, 16);
			this.lbBanSo.TabIndex = 6;
			this.lbBanSo.Text = "Bàn số";
			// 
			// lbMaPhieuXuat
			// 
			this.lbMaPhieuXuat.AutoSize = true;
			this.lbMaPhieuXuat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaPhieuXuat.Location = new System.Drawing.Point(13, 28);
			this.lbMaPhieuXuat.Name = "lbMaPhieuXuat";
			this.lbMaPhieuXuat.Size = new System.Drawing.Size(87, 16);
			this.lbMaPhieuXuat.TabIndex = 0;
			this.lbMaPhieuXuat.Text = "Mã phiếu xuất";
			// 
			// dgPhieuXuat
			// 
			this.dgPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgPhieuXuat.Location = new System.Drawing.Point(8, 16);
			this.dgPhieuXuat.Name = "dgPhieuXuat";
			this.dgPhieuXuat.Size = new System.Drawing.Size(736, 192);
			this.dgPhieuXuat.TabIndex = 0;
			this.dgPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhieuXuat_CellClick);
			// 
			// lbNgayXuat
			// 
			this.lbNgayXuat.AutoSize = true;
			this.lbNgayXuat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNgayXuat.Location = new System.Drawing.Point(8, 64);
			this.lbNgayXuat.Name = "lbNgayXuat";
			this.lbNgayXuat.Size = new System.Drawing.Size(63, 16);
			this.lbNgayXuat.TabIndex = 4;
			this.lbNgayXuat.Text = "Ngày xuất";
			// 
			// groupBoxdasachpx
			// 
			this.groupBoxdasachpx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.groupBoxdasachpx.Controls.Add(this.dgPhieuXuat);
			this.groupBoxdasachpx.Location = new System.Drawing.Point(8, 160);
			this.groupBoxdasachpx.Name = "groupBoxdasachpx";
			this.groupBoxdasachpx.Size = new System.Drawing.Size(744, 216);
			this.groupBoxdasachpx.TabIndex = 2;
			this.groupBoxdasachpx.TabStop = false;
			this.groupBoxdasachpx.Text = "Danh sách";
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
			this.splitContainer1.Panel1.Controls.Add(this.lbQuanLyPhieuXuat);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxdasachpx);
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxchucnangpx);
			this.splitContainer1.Panel2.Controls.Add(this.grbThongTin);
			this.splitContainer1.Size = new System.Drawing.Size(800, 450);
			this.splitContainer1.SplitterDistance = 58;
			this.splitContainer1.TabIndex = 4;
			// 
			// lbQuanLyPhieuXuat
			// 
			this.lbQuanLyPhieuXuat.AutoSize = true;
			this.lbQuanLyPhieuXuat.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbQuanLyPhieuXuat.Location = new System.Drawing.Point(216, 16);
			this.lbQuanLyPhieuXuat.Name = "lbQuanLyPhieuXuat";
			this.lbQuanLyPhieuXuat.Size = new System.Drawing.Size(279, 29);
			this.lbQuanLyPhieuXuat.TabIndex = 0;
			this.lbQuanLyPhieuXuat.Text = "QUẢN LÝ PHIẾU XUẤT";
			// 
			// groupBoxchucnangpx
			// 
			this.groupBoxchucnangpx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.groupBoxchucnangpx.Controls.Add(this.toolStrip1);
			this.groupBoxchucnangpx.Location = new System.Drawing.Point(8, 120);
			this.groupBoxchucnangpx.Name = "groupBoxchucnangpx";
			this.groupBoxchucnangpx.Size = new System.Drawing.Size(744, 48);
			this.groupBoxchucnangpx.TabIndex = 1;
			this.groupBoxchucnangpx.TabStop = false;
			this.groupBoxchucnangpx.Text = "Chức năng";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstThem,
            this.tstLamMoi,
            this.tstChiTietPhieuXuat,
            this.tsXoa,
            this.tsTimKiem,
            this.tstThoat,
            this.tsQuayLai});
			this.toolStrip1.Location = new System.Drawing.Point(3, 16);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(738, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tstThem
			// 
			this.tstThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tstThem.Image = ((System.Drawing.Image)(resources.GetObject("tstThem.Image")));
			this.tstThem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tstThem.Name = "tstThem";
			this.tstThem.Size = new System.Drawing.Size(60, 22);
			this.tstThem.Text = "Thêm";
			this.tstThem.Click += new System.EventHandler(this.tstThem_Click);
			// 
			// tstLamMoi
			// 
			this.tstLamMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tstLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("tstLamMoi.Image")));
			this.tstLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tstLamMoi.Name = "tstLamMoi";
			this.tstLamMoi.Size = new System.Drawing.Size(76, 22);
			this.tstLamMoi.Text = "Làm mới";
			this.tstLamMoi.Click += new System.EventHandler(this.tstLamMoi_Click);
			// 
			// tstChiTietPhieuXuat
			// 
			this.tstChiTietPhieuXuat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tstChiTietPhieuXuat.Image = ((System.Drawing.Image)(resources.GetObject("tstChiTietPhieuXuat.Image")));
			this.tstChiTietPhieuXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tstChiTietPhieuXuat.Name = "tstChiTietPhieuXuat";
			this.tstChiTietPhieuXuat.Size = new System.Drawing.Size(130, 22);
			this.tstChiTietPhieuXuat.Text = "Chi tiết phiếu xuất";
			this.tstChiTietPhieuXuat.Click += new System.EventHandler(this.tstChiTietPhieuXuat_Click);
			// 
			// tsXoa
			// 
			this.tsXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsXoa.Image")));
			this.tsXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsXoa.Name = "tsXoa";
			this.tsXoa.Size = new System.Drawing.Size(47, 22);
			this.tsXoa.Text = "Xóa";
			this.tsXoa.Click += new System.EventHandler(this.tsXoa_Click);
			// 
			// tsTimKiem
			// 
			this.tsTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsTimKiem.Image")));
			this.tsTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsTimKiem.Name = "tsTimKiem";
			this.tsTimKiem.Size = new System.Drawing.Size(81, 22);
			this.tsTimKiem.Text = "Tìm Kiếm";
			this.tsTimKiem.Click += new System.EventHandler(this.tsTimKiem_Click);
			// 
			// tstThoat
			// 
			this.tstThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tstThoat.Image = ((System.Drawing.Image)(resources.GetObject("tstThoat.Image")));
			this.tstThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tstThoat.Name = "tstThoat";
			this.tstThoat.Size = new System.Drawing.Size(60, 22);
			this.tstThoat.Text = "Thoát";
			this.tstThoat.Click += new System.EventHandler(this.tstThoat_Click);
			// 
			// tsQuayLai
			// 
			this.tsQuayLai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("tsQuayLai.Image")));
			this.tsQuayLai.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsQuayLai.Name = "tsQuayLai";
			this.tsQuayLai.Size = new System.Drawing.Size(64, 22);
			this.tsQuayLai.Text = "Trở lại";
			this.tsQuayLai.Click += new System.EventHandler(this.tsQuayLai_Click);
			// 
			// grbThongTin
			// 
			this.grbThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grbThongTin.Controls.Add(this.msNgayBan);
			this.grbThongTin.Controls.Add(this.txtMapx);
			this.grbThongTin.Controls.Add(this.cbManv);
			this.grbThongTin.Controls.Add(this.lbMaNhanVien);
			this.grbThongTin.Controls.Add(this.cbBanSo);
			this.grbThongTin.Controls.Add(this.lbBanSo);
			this.grbThongTin.Controls.Add(this.lbNgayXuat);
			this.grbThongTin.Controls.Add(this.lbMaPhieuXuat);
			this.grbThongTin.Location = new System.Drawing.Point(0, 16);
			this.grbThongTin.Name = "grbThongTin";
			this.grbThongTin.Size = new System.Drawing.Size(752, 104);
			this.grbThongTin.TabIndex = 0;
			this.grbThongTin.TabStop = false;
			this.grbThongTin.Text = "Thông tin";
			// 
			// msNgayBan
			// 
			this.msNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.msNgayBan.Location = new System.Drawing.Point(104, 62);
			this.msNgayBan.Name = "msNgayBan";
			this.msNgayBan.Size = new System.Drawing.Size(247, 20);
			this.msNgayBan.TabIndex = 17;
			// 
			// frmQuanLyPhieuXuat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmQuanLyPhieuXuat";
			this.Text = "frmQuanLyPhieuXuat";
			this.Load += new System.EventHandler(this.frmQuanLyPhieuXuat_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgPhieuXuat)).EndInit();
			this.groupBoxdasachpx.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBoxchucnangpx.ResumeLayout(false);
			this.groupBoxchucnangpx.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.grbThongTin.ResumeLayout(false);
			this.grbThongTin.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox txtMapx;
		private System.Windows.Forms.ComboBox cbManv;
		private System.Windows.Forms.Label lbMaNhanVien;
		private System.Windows.Forms.ComboBox cbBanSo;
		private System.Windows.Forms.Label lbBanSo;
		private System.Windows.Forms.Label lbMaPhieuXuat;
		private System.Windows.Forms.DataGridView dgPhieuXuat;
		private System.Windows.Forms.Label lbNgayXuat;
		private System.Windows.Forms.GroupBox groupBoxdasachpx;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label lbQuanLyPhieuXuat;
		private System.Windows.Forms.GroupBox groupBoxchucnangpx;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tstThem;
		private System.Windows.Forms.ToolStripButton tstLamMoi;
		private System.Windows.Forms.ToolStripButton tstChiTietPhieuXuat;
		private System.Windows.Forms.ToolStripButton tsXoa;
		private System.Windows.Forms.ToolStripButton tsTimKiem;
		private System.Windows.Forms.ToolStripButton tstThoat;
		private System.Windows.Forms.ToolStripButton tsQuayLai;
		private System.Windows.Forms.GroupBox grbThongTin;
		private System.Windows.Forms.DateTimePicker msNgayBan;
	}
}