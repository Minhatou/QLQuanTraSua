namespace QLQuanTraSua
{
	partial class frmQuanLyNhanVien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhanVien));
			this.cbTimKiem = new System.Windows.Forms.ComboBox();
			this.lbtimkem = new System.Windows.Forms.Label();
			this.dgNhanVien = new System.Windows.Forms.DataGridView();
			this.cbGioiTinh = new System.Windows.Forms.ComboBox();
			this.txtSoCMND = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtDienThoai = new System.Windows.Forms.TextBox();
			this.txtTennv = new System.Windows.Forms.TextBox();
			this.lbSoCMND = new System.Windows.Forms.Label();
			this.lbDiaChi = new System.Windows.Forms.Label();
			this.lbDienThoai = new System.Windows.Forms.Label();
			this.lbGioiTinh = new System.Windows.Forms.Label();
			this.lbTenNhanVien = new System.Windows.Forms.Label();
			this.lbMaNhanVien = new System.Windows.Forms.Label();
			this.toolStripqlnv = new System.Windows.Forms.ToolStrip();
			this.lbQuanLyNhanVien = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.grbThongTin = new System.Windows.Forms.GroupBox();
			this.txtManv = new System.Windows.Forms.TextBox();
			this.tsLamMoi = new System.Windows.Forms.ToolStripButton();
			this.tsThem = new System.Windows.Forms.ToolStripButton();
			this.tsSua = new System.Windows.Forms.ToolStripButton();
			this.tsXoa = new System.Windows.Forms.ToolStripButton();
			this.tsTimKiem = new System.Windows.Forms.ToolStripButton();
			this.tsThoat = new System.Windows.Forms.ToolStripButton();
			this.tsQuayLai = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).BeginInit();
			this.toolStripqlnv.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.grbThongTin.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbTimKiem
			// 
			this.cbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbTimKiem.FormattingEnabled = true;
			this.cbTimKiem.Items.AddRange(new object[] {
            "Tìm kiếm theo mã",
            "Tìm kiếm theo tên",
            "\t"});
			this.cbTimKiem.Location = new System.Drawing.Point(133, 152);
			this.cbTimKiem.Name = "cbTimKiem";
			this.cbTimKiem.Size = new System.Drawing.Size(240, 24);
			this.cbTimKiem.TabIndex = 14;
			// 
			// lbtimkem
			// 
			this.lbtimkem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbtimkem.AutoSize = true;
			this.lbtimkem.Location = new System.Drawing.Point(28, 155);
			this.lbtimkem.Name = "lbtimkem";
			this.lbtimkem.Size = new System.Drawing.Size(92, 16);
			this.lbtimkem.TabIndex = 13;
			this.lbtimkem.Text = " Kiểu Tìm kiếm";
			// 
			// dgNhanVien
			// 
			this.dgNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dgNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgNhanVien.Location = new System.Drawing.Point(8, 196);
			this.dgNhanVien.Name = "dgNhanVien";
			this.dgNhanVien.Size = new System.Drawing.Size(781, 144);
			this.dgNhanVien.TabIndex = 12;
			this.dgNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNhanVien_CellContentClick);
			// 
			// cbGioiTinh
			// 
			this.cbGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbGioiTinh.FormattingEnabled = true;
			this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
			this.cbGioiTinh.Location = new System.Drawing.Point(133, 72);
			this.cbGioiTinh.Name = "cbGioiTinh";
			this.cbGioiTinh.Size = new System.Drawing.Size(240, 24);
			this.cbGioiTinh.TabIndex = 5;
			// 
			// txtSoCMND
			// 
			this.txtSoCMND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSoCMND.Location = new System.Drawing.Point(517, 120);
			this.txtSoCMND.Name = "txtSoCMND";
			this.txtSoCMND.Size = new System.Drawing.Size(240, 23);
			this.txtSoCMND.TabIndex = 11;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDiaChi.Location = new System.Drawing.Point(133, 113);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(240, 23);
			this.txtDiaChi.TabIndex = 9;
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDienThoai.Location = new System.Drawing.Point(517, 72);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(240, 23);
			this.txtDienThoai.TabIndex = 7;
			// 
			// txtTennv
			// 
			this.txtTennv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTennv.Location = new System.Drawing.Point(517, 32);
			this.txtTennv.Name = "txtTennv";
			this.txtTennv.Size = new System.Drawing.Size(240, 23);
			this.txtTennv.TabIndex = 3;
			// 
			// lbSoCMND
			// 
			this.lbSoCMND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbSoCMND.AutoSize = true;
			this.lbSoCMND.Location = new System.Drawing.Point(389, 120);
			this.lbSoCMND.Name = "lbSoCMND";
			this.lbSoCMND.Size = new System.Drawing.Size(60, 16);
			this.lbSoCMND.TabIndex = 10;
			this.lbSoCMND.Text = "Số CMND";
			// 
			// lbDiaChi
			// 
			this.lbDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbDiaChi.AutoSize = true;
			this.lbDiaChi.Location = new System.Drawing.Point(37, 120);
			this.lbDiaChi.Name = "lbDiaChi";
			this.lbDiaChi.Size = new System.Drawing.Size(46, 16);
			this.lbDiaChi.TabIndex = 8;
			this.lbDiaChi.Text = "Địa chỉ";
			// 
			// lbDienThoai
			// 
			this.lbDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbDienThoai.AutoSize = true;
			this.lbDienThoai.Location = new System.Drawing.Point(389, 80);
			this.lbDienThoai.Name = "lbDienThoai";
			this.lbDienThoai.Size = new System.Drawing.Size(65, 16);
			this.lbDienThoai.TabIndex = 6;
			this.lbDienThoai.Text = "Điện thoại";
			// 
			// lbGioiTinh
			// 
			this.lbGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbGioiTinh.AutoSize = true;
			this.lbGioiTinh.Location = new System.Drawing.Point(37, 75);
			this.lbGioiTinh.Name = "lbGioiTinh";
			this.lbGioiTinh.Size = new System.Drawing.Size(53, 16);
			this.lbGioiTinh.TabIndex = 4;
			this.lbGioiTinh.Text = "Giới tính";
			// 
			// lbTenNhanVien
			// 
			this.lbTenNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTenNhanVien.AutoSize = true;
			this.lbTenNhanVien.Location = new System.Drawing.Point(389, 40);
			this.lbTenNhanVien.Name = "lbTenNhanVien";
			this.lbTenNhanVien.Size = new System.Drawing.Size(88, 16);
			this.lbTenNhanVien.TabIndex = 2;
			this.lbTenNhanVien.Text = "Tên nhân viên";
			// 
			// lbMaNhanVien
			// 
			this.lbMaNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbMaNhanVien.AutoSize = true;
			this.lbMaNhanVien.Location = new System.Drawing.Point(37, 40);
			this.lbMaNhanVien.Name = "lbMaNhanVien";
			this.lbMaNhanVien.Size = new System.Drawing.Size(83, 16);
			this.lbMaNhanVien.TabIndex = 0;
			this.lbMaNhanVien.Text = "Mã nhân viên";
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
			// lbQuanLyNhanVien
			// 
			this.lbQuanLyNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbQuanLyNhanVien.AutoSize = true;
			this.lbQuanLyNhanVien.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbQuanLyNhanVien.Location = new System.Drawing.Point(266, 19);
			this.lbQuanLyNhanVien.Name = "lbQuanLyNhanVien";
			this.lbQuanLyNhanVien.Size = new System.Drawing.Size(269, 29);
			this.lbQuanLyNhanVien.TabIndex = 0;
			this.lbQuanLyNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
			this.lbQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.splitContainer1.Panel1.Controls.Add(this.lbQuanLyNhanVien);
			this.splitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.toolStripqlnv);
			this.splitContainer1.Panel2.Controls.Add(this.grbThongTin);
			this.splitContainer1.Size = new System.Drawing.Size(800, 450);
			this.splitContainer1.SplitterDistance = 62;
			this.splitContainer1.TabIndex = 1;
			// 
			// grbThongTin
			// 
			this.grbThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.grbThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.grbThongTin.Controls.Add(this.txtManv);
			this.grbThongTin.Controls.Add(this.cbTimKiem);
			this.grbThongTin.Controls.Add(this.lbtimkem);
			this.grbThongTin.Controls.Add(this.dgNhanVien);
			this.grbThongTin.Controls.Add(this.cbGioiTinh);
			this.grbThongTin.Controls.Add(this.txtSoCMND);
			this.grbThongTin.Controls.Add(this.txtDiaChi);
			this.grbThongTin.Controls.Add(this.txtDienThoai);
			this.grbThongTin.Controls.Add(this.txtTennv);
			this.grbThongTin.Controls.Add(this.lbSoCMND);
			this.grbThongTin.Controls.Add(this.lbDiaChi);
			this.grbThongTin.Controls.Add(this.lbDienThoai);
			this.grbThongTin.Controls.Add(this.lbGioiTinh);
			this.grbThongTin.Controls.Add(this.lbTenNhanVien);
			this.grbThongTin.Controls.Add(this.lbMaNhanVien);
			this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbThongTin.Location = new System.Drawing.Point(3, 32);
			this.grbThongTin.Name = "grbThongTin";
			this.grbThongTin.Size = new System.Drawing.Size(797, 352);
			this.grbThongTin.TabIndex = 1;
			this.grbThongTin.TabStop = false;
			this.grbThongTin.Text = "Thông tin";
			// 
			// txtManv
			// 
			this.txtManv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtManv.Location = new System.Drawing.Point(133, 37);
			this.txtManv.Name = "txtManv";
			this.txtManv.Size = new System.Drawing.Size(240, 23);
			this.txtManv.TabIndex = 4;
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
			this.tsQuayLai.Size = new System.Drawing.Size(70, 22);
			this.tsQuayLai.Text = "Quay lai";
			this.tsQuayLai.Click += new System.EventHandler(this.tsQuayLai_Click);
			// 
			// frmQuanLyNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmQuanLyNhanVien";
			this.Text = "Quản lý nhân viên";
			this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).EndInit();
			this.toolStripqlnv.ResumeLayout(false);
			this.toolStripqlnv.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.grbThongTin.ResumeLayout(false);
			this.grbThongTin.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ComboBox cbTimKiem;
		private System.Windows.Forms.Label lbtimkem;
		private System.Windows.Forms.DataGridView dgNhanVien;
		private System.Windows.Forms.ComboBox cbGioiTinh;
		private System.Windows.Forms.TextBox txtSoCMND;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.TextBox txtTennv;
		private System.Windows.Forms.Label lbSoCMND;
		private System.Windows.Forms.Label lbDiaChi;
		private System.Windows.Forms.Label lbDienThoai;
		private System.Windows.Forms.Label lbGioiTinh;
		private System.Windows.Forms.Label lbTenNhanVien;
		private System.Windows.Forms.Label lbMaNhanVien;
		private System.Windows.Forms.ToolStripButton tsThoat;
		private System.Windows.Forms.ToolStripButton tsTimKiem;
		private System.Windows.Forms.ToolStripButton tsXoa;
		private System.Windows.Forms.ToolStripButton tsSua;
		private System.Windows.Forms.ToolStripButton tsThem;
		private System.Windows.Forms.ToolStripButton tsLamMoi;
		private System.Windows.Forms.ToolStrip toolStripqlnv;
		private System.Windows.Forms.ToolStripButton tsQuayLai;
		private System.Windows.Forms.Label lbQuanLyNhanVien;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox grbThongTin;
		private System.Windows.Forms.TextBox txtManv;
	}
}