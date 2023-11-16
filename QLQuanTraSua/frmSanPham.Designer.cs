namespace QLQuanTraSua
{
	partial class frmSanPham
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lbQuanLySanPham = new System.Windows.Forms.Label();
			this.toolStripqlnv = new System.Windows.Forms.ToolStrip();
			this.tsLamMoi = new System.Windows.Forms.ToolStripButton();
			this.tsThem = new System.Windows.Forms.ToolStripButton();
			this.tsSua = new System.Windows.Forms.ToolStripButton();
			this.tsXoa = new System.Windows.Forms.ToolStripButton();
			this.tsTimKiem = new System.Windows.Forms.ToolStripButton();
			this.tsThoat = new System.Windows.Forms.ToolStripButton();
			this.tsQuayLai = new System.Windows.Forms.ToolStripButton();
			this.grbThongTin = new System.Windows.Forms.GroupBox();
			this.txtTensp = new System.Windows.Forms.ComboBox();
			this.cbDonViTinh = new System.Windows.Forms.ComboBox();
			this.cbTimKiem = new System.Windows.Forms.ComboBox();
			this.lbtimkem = new System.Windows.Forms.Label();
			this.dgSanPham = new System.Windows.Forms.DataGridView();
			this.cbLoaisanpham = new System.Windows.Forms.ComboBox();
			this.txtgiaban = new System.Windows.Forms.TextBox();
			this.lbloaisp = new System.Windows.Forms.Label();
			this.lbDionvitinh = new System.Windows.Forms.Label();
			this.lbGiaban = new System.Windows.Forms.Label();
			this.lbTenSanPham = new System.Windows.Forms.Label();
			this.lbMaSanPham = new System.Windows.Forms.Label();
			this.txtMasp = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.toolStripqlnv.SuspendLayout();
			this.grbThongTin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).BeginInit();
			this.SuspendLayout();
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
			this.splitContainer1.Panel1.Controls.Add(this.lbQuanLySanPham);
			this.splitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.toolStripqlnv);
			this.splitContainer1.Panel2.Controls.Add(this.grbThongTin);
			this.splitContainer1.Size = new System.Drawing.Size(800, 450);
			this.splitContainer1.SplitterDistance = 61;
			this.splitContainer1.TabIndex = 3;
			// 
			// lbQuanLySanPham
			// 
			this.lbQuanLySanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbQuanLySanPham.AutoSize = true;
			this.lbQuanLySanPham.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbQuanLySanPham.Location = new System.Drawing.Point(243, 20);
			this.lbQuanLySanPham.Name = "lbQuanLySanPham";
			this.lbQuanLySanPham.Size = new System.Drawing.Size(256, 29);
			this.lbQuanLySanPham.TabIndex = 0;
			this.lbQuanLySanPham.Text = "QUẢN LÝ SẢN PHẨM\r\n";
			this.lbQuanLySanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// toolStripqlnv
			// 
			this.toolStripqlnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.toolStripqlnv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLamMoi,
            this.tsThem,
            this.tsSua,
            this.tsXoa,
            this.tsTimKiem,
            this.tsThoat,
            this.tsQuayLai});
			this.toolStripqlnv.Location = new System.Drawing.Point(0, 0);
			this.toolStripqlnv.Name = "toolStripqlnv";
			this.toolStripqlnv.Size = new System.Drawing.Size(800, 25);
			this.toolStripqlnv.TabIndex = 0;
			this.toolStripqlnv.Text = "toolStrip1";
			// 
			// tsLamMoi
			// 
			this.tsLamMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("tsLamMoi.Image")));
			this.tsLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsLamMoi.Name = "tsLamMoi";
			this.tsLamMoi.Size = new System.Drawing.Size(76, 22);
			this.tsLamMoi.Text = "Làm mới";
			this.tsLamMoi.Click += new System.EventHandler(this.tsLamMoi_Click);
			// 
			// tsThem
			// 
			this.tsThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsThem.Image = ((System.Drawing.Image)(resources.GetObject("tsThem.Image")));
			this.tsThem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsThem.Name = "tsThem";
			this.tsThem.Size = new System.Drawing.Size(60, 22);
			this.tsThem.Text = "Thêm";
			this.tsThem.Click += new System.EventHandler(this.tsThem_Click);
			// 
			// tsSua
			// 
			this.tsSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsSua.Image = ((System.Drawing.Image)(resources.GetObject("tsSua.Image")));
			this.tsSua.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsSua.Name = "tsSua";
			this.tsSua.Size = new System.Drawing.Size(50, 22);
			this.tsSua.Text = "Sửa";
			this.tsSua.Click += new System.EventHandler(this.tsSua_Click);
			// 
			// tsXoa
			// 
			this.tsXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsXoa.Image")));
			this.tsXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsXoa.Name = "tsXoa";
			this.tsXoa.Size = new System.Drawing.Size(49, 22);
			this.tsXoa.Text = "Xóa";
			this.tsXoa.Click += new System.EventHandler(this.tsXoa_Click);
			// 
			// tsTimKiem
			// 
			this.tsTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsTimKiem.Image")));
			this.tsTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsTimKiem.Name = "tsTimKiem";
			this.tsTimKiem.Size = new System.Drawing.Size(80, 22);
			this.tsTimKiem.Text = "Tìm kiếm";
			this.tsTimKiem.Click += new System.EventHandler(this.tsTimKiem_Click);
			// 
			// tsThoat
			// 
			this.tsThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsThoat.Image = ((System.Drawing.Image)(resources.GetObject("tsThoat.Image")));
			this.tsThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsThoat.Name = "tsThoat";
			this.tsThoat.Size = new System.Drawing.Size(60, 22);
			this.tsThoat.Text = "Thoát";
			this.tsThoat.Click += new System.EventHandler(this.tsThoat_Click);
			// 
			// tsQuayLai
			// 
			this.tsQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("tsQuayLai.Image")));
			this.tsQuayLai.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsQuayLai.Name = "tsQuayLai";
			this.tsQuayLai.Size = new System.Drawing.Size(73, 22);
			this.tsQuayLai.Text = "Quay Lại";
			this.tsQuayLai.Click += new System.EventHandler(this.tsQuayLai_Click);
			// 
			// grbThongTin
			// 
			this.grbThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grbThongTin.Controls.Add(this.txtMasp);
			this.grbThongTin.Controls.Add(this.txtTensp);
			this.grbThongTin.Controls.Add(this.cbDonViTinh);
			this.grbThongTin.Controls.Add(this.cbTimKiem);
			this.grbThongTin.Controls.Add(this.lbtimkem);
			this.grbThongTin.Controls.Add(this.dgSanPham);
			this.grbThongTin.Controls.Add(this.cbLoaisanpham);
			this.grbThongTin.Controls.Add(this.txtgiaban);
			this.grbThongTin.Controls.Add(this.lbloaisp);
			this.grbThongTin.Controls.Add(this.lbDionvitinh);
			this.grbThongTin.Controls.Add(this.lbGiaban);
			this.grbThongTin.Controls.Add(this.lbTenSanPham);
			this.grbThongTin.Controls.Add(this.lbMaSanPham);
			this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbThongTin.Location = new System.Drawing.Point(0, 28);
			this.grbThongTin.Name = "grbThongTin";
			this.grbThongTin.Size = new System.Drawing.Size(826, 376);
			this.grbThongTin.TabIndex = 1;
			this.grbThongTin.TabStop = false;
			this.grbThongTin.Text = "Thông tin";
			// 
			// txtTensp
			// 
			this.txtTensp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTensp.FormattingEnabled = true;
			this.txtTensp.Items.AddRange(new object[] {
            "cafe den",
            "cafe trứng",
            "coca cola",
            "cafe"});
			this.txtTensp.Location = new System.Drawing.Point(488, 31);
			this.txtTensp.Name = "txtTensp";
			this.txtTensp.Size = new System.Drawing.Size(234, 24);
			this.txtTensp.TabIndex = 15;
			// 
			// cbDonViTinh
			// 
			this.cbDonViTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbDonViTinh.FormattingEnabled = true;
			this.cbDonViTinh.Items.AddRange(new object[] {
            "Chai",
            "Lon",
            "Cốc",
            "Que",
            "Ly",
            "Đĩa",
            "Gói"});
			this.cbDonViTinh.Location = new System.Drawing.Point(104, 112);
			this.cbDonViTinh.Name = "cbDonViTinh";
			this.cbDonViTinh.Size = new System.Drawing.Size(234, 24);
			this.cbDonViTinh.TabIndex = 9;
			// 
			// cbTimKiem
			// 
			this.cbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbTimKiem.FormattingEnabled = true;
			this.cbTimKiem.Items.AddRange(new object[] {
            "tim kiem theo ma",
            "tim kiem theo ten"});
			this.cbTimKiem.Location = new System.Drawing.Point(488, 112);
			this.cbTimKiem.Name = "cbTimKiem";
			this.cbTimKiem.Size = new System.Drawing.Size(234, 24);
			this.cbTimKiem.TabIndex = 13;
			// 
			// lbtimkem
			// 
			this.lbtimkem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbtimkem.AutoSize = true;
			this.lbtimkem.Location = new System.Drawing.Point(376, 120);
			this.lbtimkem.Name = "lbtimkem";
			this.lbtimkem.Size = new System.Drawing.Size(88, 16);
			this.lbtimkem.TabIndex = 12;
			this.lbtimkem.Text = "Kiểu Tìm kiếm";
			// 
			// dgSanPham
			// 
			this.dgSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgSanPham.Location = new System.Drawing.Point(8, 152);
			this.dgSanPham.Name = "dgSanPham";
			this.dgSanPham.Size = new System.Drawing.Size(818, 200);
			this.dgSanPham.TabIndex = 14;
			this.dgSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSanPham_CellClick);
			// 
			// cbLoaisanpham
			// 
			this.cbLoaisanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbLoaisanpham.FormattingEnabled = true;
			this.cbLoaisanpham.Items.AddRange(new object[] {
            "Không pha chế",
            "Pha chế"});
			this.cbLoaisanpham.Location = new System.Drawing.Point(488, 72);
			this.cbLoaisanpham.Name = "cbLoaisanpham";
			this.cbLoaisanpham.Size = new System.Drawing.Size(234, 24);
			this.cbLoaisanpham.TabIndex = 11;
			// 
			// txtgiaban
			// 
			this.txtgiaban.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtgiaban.Location = new System.Drawing.Point(104, 72);
			this.txtgiaban.Name = "txtgiaban";
			this.txtgiaban.Size = new System.Drawing.Size(234, 23);
			this.txtgiaban.TabIndex = 5;
			// 
			// lbloaisp
			// 
			this.lbloaisp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbloaisp.AutoSize = true;
			this.lbloaisp.Location = new System.Drawing.Point(376, 80);
			this.lbloaisp.Name = "lbloaisp";
			this.lbloaisp.Size = new System.Drawing.Size(90, 16);
			this.lbloaisp.TabIndex = 10;
			this.lbloaisp.Text = "Loại sản phẩm";
			// 
			// lbDionvitinh
			// 
			this.lbDionvitinh.AutoSize = true;
			this.lbDionvitinh.Location = new System.Drawing.Point(8, 104);
			this.lbDionvitinh.Name = "lbDionvitinh";
			this.lbDionvitinh.Size = new System.Drawing.Size(68, 16);
			this.lbDionvitinh.TabIndex = 8;
			this.lbDionvitinh.Text = "Đơn vị tính";
			// 
			// lbGiaban
			// 
			this.lbGiaban.AutoSize = true;
			this.lbGiaban.Location = new System.Drawing.Point(8, 72);
			this.lbGiaban.Name = "lbGiaban";
			this.lbGiaban.Size = new System.Drawing.Size(50, 16);
			this.lbGiaban.TabIndex = 4;
			this.lbGiaban.Text = "Giá bán";
			// 
			// lbTenSanPham
			// 
			this.lbTenSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTenSanPham.AutoSize = true;
			this.lbTenSanPham.Location = new System.Drawing.Point(376, 40);
			this.lbTenSanPham.Name = "lbTenSanPham";
			this.lbTenSanPham.Size = new System.Drawing.Size(89, 16);
			this.lbTenSanPham.TabIndex = 2;
			this.lbTenSanPham.Text = "Tên sản phẩm";
			// 
			// lbMaSanPham
			// 
			this.lbMaSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbMaSanPham.AutoSize = true;
			this.lbMaSanPham.Location = new System.Drawing.Point(8, 40);
			this.lbMaSanPham.Name = "lbMaSanPham";
			this.lbMaSanPham.Size = new System.Drawing.Size(84, 16);
			this.lbMaSanPham.TabIndex = 0;
			this.lbMaSanPham.Text = "Mã sản phẩm";
			// 
			// txtMasp
			// 
			this.txtMasp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMasp.Location = new System.Drawing.Point(104, 33);
			this.txtMasp.Name = "txtMasp";
			this.txtMasp.Size = new System.Drawing.Size(234, 23);
			this.txtMasp.TabIndex = 16;
			// 
			// frmSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmSanPham";
			this.Text = "frmSanPham";
			this.Load += new System.EventHandler(this.frmSanPham_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.toolStripqlnv.ResumeLayout(false);
			this.toolStripqlnv.PerformLayout();
			this.grbThongTin.ResumeLayout(false);
			this.grbThongTin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgSanPham)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label lbQuanLySanPham;
		private System.Windows.Forms.ToolStrip toolStripqlnv;
		private System.Windows.Forms.ToolStripButton tsLamMoi;
		private System.Windows.Forms.ToolStripButton tsThem;
		private System.Windows.Forms.ToolStripButton tsSua;
		private System.Windows.Forms.ToolStripButton tsXoa;
		private System.Windows.Forms.ToolStripButton tsTimKiem;
		private System.Windows.Forms.ToolStripButton tsThoat;
		private System.Windows.Forms.ToolStripButton tsQuayLai;
		private System.Windows.Forms.GroupBox grbThongTin;
		private System.Windows.Forms.ComboBox txtTensp;
		private System.Windows.Forms.ComboBox cbDonViTinh;
		private System.Windows.Forms.ComboBox cbTimKiem;
		private System.Windows.Forms.Label lbtimkem;
		private System.Windows.Forms.DataGridView dgSanPham;
		private System.Windows.Forms.ComboBox cbLoaisanpham;
		private System.Windows.Forms.TextBox txtgiaban;
		private System.Windows.Forms.Label lbloaisp;
		private System.Windows.Forms.Label lbDionvitinh;
		private System.Windows.Forms.Label lbGiaban;
		private System.Windows.Forms.Label lbTenSanPham;
		private System.Windows.Forms.Label lbMaSanPham;
		private System.Windows.Forms.TextBox txtMasp;
	}
}