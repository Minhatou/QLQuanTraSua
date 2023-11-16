namespace QLQuanTraSua
{
	partial class frmChiTietPhieuXuat
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
			this.btSanPham = new System.Windows.Forms.Button();
			this.bttrolai = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTongtien = new System.Windows.Forms.TextBox();
			this.labeltongtien = new System.Windows.Forms.Label();
			this.btLamMoi = new System.Windows.Forms.Button();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.lbDonGia = new System.Windows.Forms.Label();
			this.cbMaPhieuXuat = new System.Windows.Forms.ComboBox();
			this.btThoat = new System.Windows.Forms.Button();
			this.btThem = new System.Windows.Forms.Button();
			this.btXoa = new System.Windows.Forms.Button();
			this.cbMaSanPham = new System.Windows.Forms.ComboBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.lbSoLuong = new System.Windows.Forms.Label();
			this.lbMasp = new System.Windows.Forms.Label();
			this.txtThanhTien = new System.Windows.Forms.TextBox();
			this.lbTongTien = new System.Windows.Forms.Label();
			this.lbMaPhieuXuat = new System.Windows.Forms.Label();
			this.dgChiTietPhieuXuat = new System.Windows.Forms.DataGridView();
			this.btTimKiem = new System.Windows.Forms.Button();
			this.cbTimKiem = new System.Windows.Forms.ComboBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lbChiTietPhieuXuat = new System.Windows.Forms.Label();
			this.btnIn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgChiTietPhieuXuat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btSanPham
			// 
			this.btSanPham.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSanPham.Location = new System.Drawing.Point(600, 160);
			this.btSanPham.Name = "btSanPham";
			this.btSanPham.Size = new System.Drawing.Size(75, 23);
			this.btSanPham.TabIndex = 42;
			this.btSanPham.Text = "Tra SP";
			this.btSanPham.UseVisualStyleBackColor = true;
			this.btSanPham.Click += new System.EventHandler(this.btSanPham_Click);
			// 
			// bttrolai
			// 
			this.bttrolai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bttrolai.Location = new System.Drawing.Point(520, 160);
			this.bttrolai.Name = "bttrolai";
			this.bttrolai.Size = new System.Drawing.Size(75, 23);
			this.bttrolai.TabIndex = 41;
			this.bttrolai.Text = "Trở lại";
			this.bttrolai.UseVisualStyleBackColor = true;
			this.bttrolai.Click += new System.EventHandler(this.bttrolai_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(696, 344);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 16);
			this.label2.TabIndex = 40;
			this.label2.Text = "Đ";
			// 
			// txtTongtien
			// 
			this.txtTongtien.Location = new System.Drawing.Point(592, 344);
			this.txtTongtien.Name = "txtTongtien";
			this.txtTongtien.Size = new System.Drawing.Size(100, 20);
			this.txtTongtien.TabIndex = 39;
			// 
			// labeltongtien
			// 
			this.labeltongtien.AutoSize = true;
			this.labeltongtien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeltongtien.Location = new System.Drawing.Point(520, 344);
			this.labeltongtien.Name = "labeltongtien";
			this.labeltongtien.Size = new System.Drawing.Size(65, 16);
			this.labeltongtien.TabIndex = 38;
			this.labeltongtien.Text = "Tổng Tiền";
			// 
			// btLamMoi
			// 
			this.btLamMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLamMoi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btLamMoi.Location = new System.Drawing.Point(8, 160);
			this.btLamMoi.Name = "btLamMoi";
			this.btLamMoi.Size = new System.Drawing.Size(75, 23);
			this.btLamMoi.TabIndex = 37;
			this.btLamMoi.Text = "Làm Mới";
			this.btLamMoi.UseVisualStyleBackColor = true;
			this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(464, 64);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(240, 20);
			this.txtDonGia.TabIndex = 36;
			this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
			// 
			// lbDonGia
			// 
			this.lbDonGia.AutoSize = true;
			this.lbDonGia.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDonGia.Location = new System.Drawing.Point(400, 64);
			this.lbDonGia.Name = "lbDonGia";
			this.lbDonGia.Size = new System.Drawing.Size(52, 16);
			this.lbDonGia.TabIndex = 35;
			this.lbDonGia.Text = "Đơn Giá";
			// 
			// cbMaPhieuXuat
			// 
			this.cbMaPhieuXuat.FormattingEnabled = true;
			this.cbMaPhieuXuat.Location = new System.Drawing.Point(104, 16);
			this.cbMaPhieuXuat.Name = "cbMaPhieuXuat";
			this.cbMaPhieuXuat.Size = new System.Drawing.Size(248, 21);
			this.cbMaPhieuXuat.TabIndex = 34;
			// 
			// btThoat
			// 
			this.btThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btThoat.Location = new System.Drawing.Point(680, 160);
			this.btThoat.Name = "btThoat";
			this.btThoat.Size = new System.Drawing.Size(75, 23);
			this.btThoat.TabIndex = 33;
			this.btThoat.Text = "Thoát";
			this.btThoat.UseVisualStyleBackColor = true;
			this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
			// 
			// btThem
			// 
			this.btThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btThem.Location = new System.Drawing.Point(88, 160);
			this.btThem.Name = "btThem";
			this.btThem.Size = new System.Drawing.Size(75, 23);
			this.btThem.TabIndex = 32;
			this.btThem.Text = "Thêm";
			this.btThem.UseVisualStyleBackColor = true;
			this.btThem.Click += new System.EventHandler(this.btThem_Click);
			// 
			// btXoa
			// 
			this.btXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btXoa.Location = new System.Drawing.Point(168, 160);
			this.btXoa.Name = "btXoa";
			this.btXoa.Size = new System.Drawing.Size(75, 23);
			this.btXoa.TabIndex = 31;
			this.btXoa.Text = "Xóa";
			this.btXoa.UseVisualStyleBackColor = true;
			this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
			// 
			// cbMaSanPham
			// 
			this.cbMaSanPham.FormattingEnabled = true;
			this.cbMaSanPham.Location = new System.Drawing.Point(104, 64);
			this.cbMaSanPham.Name = "cbMaSanPham";
			this.cbMaSanPham.Size = new System.Drawing.Size(248, 21);
			this.cbMaSanPham.TabIndex = 30;
			this.cbMaSanPham.SelectedIndexChanged += new System.EventHandler(this.cbMaSanPham_SelectedIndexChanged);
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(464, 16);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(240, 20);
			this.txtSoLuong.TabIndex = 27;
			// 
			// lbSoLuong
			// 
			this.lbSoLuong.AutoSize = true;
			this.lbSoLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSoLuong.Location = new System.Drawing.Point(400, 16);
			this.lbSoLuong.Name = "lbSoLuong";
			this.lbSoLuong.Size = new System.Drawing.Size(58, 16);
			this.lbSoLuong.TabIndex = 26;
			this.lbSoLuong.Text = "Số lượng";
			// 
			// lbMasp
			// 
			this.lbMasp.AutoSize = true;
			this.lbMasp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMasp.Location = new System.Drawing.Point(8, 64);
			this.lbMasp.Name = "lbMasp";
			this.lbMasp.Size = new System.Drawing.Size(84, 16);
			this.lbMasp.TabIndex = 25;
			this.lbMasp.Text = "Mã sản phẩm";
			// 
			// txtThanhTien
			// 
			this.txtThanhTien.Location = new System.Drawing.Point(464, 112);
			this.txtThanhTien.Name = "txtThanhTien";
			this.txtThanhTien.Size = new System.Drawing.Size(240, 20);
			this.txtThanhTien.TabIndex = 29;
			// 
			// lbTongTien
			// 
			this.lbTongTien.AutoSize = true;
			this.lbTongTien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTongTien.Location = new System.Drawing.Point(392, 112);
			this.lbTongTien.Name = "lbTongTien";
			this.lbTongTien.Size = new System.Drawing.Size(68, 16);
			this.lbTongTien.TabIndex = 28;
			this.lbTongTien.Text = "Thành tiền";
			// 
			// lbMaPhieuXuat
			// 
			this.lbMaPhieuXuat.AutoSize = true;
			this.lbMaPhieuXuat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaPhieuXuat.Location = new System.Drawing.Point(8, 16);
			this.lbMaPhieuXuat.Name = "lbMaPhieuXuat";
			this.lbMaPhieuXuat.Size = new System.Drawing.Size(87, 16);
			this.lbMaPhieuXuat.TabIndex = 18;
			this.lbMaPhieuXuat.Text = "Mã phiếu xuất";
			// 
			// dgChiTietPhieuXuat
			// 
			this.dgChiTietPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgChiTietPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgChiTietPhieuXuat.Location = new System.Drawing.Point(8, 192);
			this.dgChiTietPhieuXuat.Name = "dgChiTietPhieuXuat";
			this.dgChiTietPhieuXuat.Size = new System.Drawing.Size(824, 136);
			this.dgChiTietPhieuXuat.TabIndex = 2;
			this.dgChiTietPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChiTietPhieuXuat_CellClick);
			this.dgChiTietPhieuXuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChiTietPhieuXuat_CellContentClick);
			// 
			// btTimKiem
			// 
			this.btTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btTimKiem.Location = new System.Drawing.Point(440, 160);
			this.btTimKiem.Name = "btTimKiem";
			this.btTimKiem.Size = new System.Drawing.Size(75, 23);
			this.btTimKiem.TabIndex = 1;
			this.btTimKiem.Text = "Tính Tiền";
			this.btTimKiem.UseVisualStyleBackColor = true;
			this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
			// 
			// cbTimKiem
			// 
			this.cbTimKiem.FormattingEnabled = true;
			this.cbTimKiem.Location = new System.Drawing.Point(248, 160);
			this.cbTimKiem.Name = "cbTimKiem";
			this.cbTimKiem.Size = new System.Drawing.Size(184, 21);
			this.cbTimKiem.TabIndex = 0;
			this.cbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbTimKiem_SelectedIndexChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(12, 14);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.splitContainer1.Panel1.Controls.Add(this.lbChiTietPhieuXuat);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btnIn);
			this.splitContainer1.Panel2.Controls.Add(this.btSanPham);
			this.splitContainer1.Panel2.Controls.Add(this.bttrolai);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.txtTongtien);
			this.splitContainer1.Panel2.Controls.Add(this.labeltongtien);
			this.splitContainer1.Panel2.Controls.Add(this.btLamMoi);
			this.splitContainer1.Panel2.Controls.Add(this.txtDonGia);
			this.splitContainer1.Panel2.Controls.Add(this.lbDonGia);
			this.splitContainer1.Panel2.Controls.Add(this.cbMaPhieuXuat);
			this.splitContainer1.Panel2.Controls.Add(this.btThoat);
			this.splitContainer1.Panel2.Controls.Add(this.btThem);
			this.splitContainer1.Panel2.Controls.Add(this.btXoa);
			this.splitContainer1.Panel2.Controls.Add(this.cbMaSanPham);
			this.splitContainer1.Panel2.Controls.Add(this.txtSoLuong);
			this.splitContainer1.Panel2.Controls.Add(this.lbSoLuong);
			this.splitContainer1.Panel2.Controls.Add(this.lbMasp);
			this.splitContainer1.Panel2.Controls.Add(this.txtThanhTien);
			this.splitContainer1.Panel2.Controls.Add(this.lbTongTien);
			this.splitContainer1.Panel2.Controls.Add(this.lbMaPhieuXuat);
			this.splitContainer1.Panel2.Controls.Add(this.dgChiTietPhieuXuat);
			this.splitContainer1.Panel2.Controls.Add(this.btTimKiem);
			this.splitContainer1.Panel2.Controls.Add(this.cbTimKiem);
			this.splitContainer1.Size = new System.Drawing.Size(848, 424);
			this.splitContainer1.SplitterDistance = 46;
			this.splitContainer1.TabIndex = 1;
			// 
			// lbChiTietPhieuXuat
			// 
			this.lbChiTietPhieuXuat.AutoSize = true;
			this.lbChiTietPhieuXuat.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbChiTietPhieuXuat.Location = new System.Drawing.Point(208, 8);
			this.lbChiTietPhieuXuat.Name = "lbChiTietPhieuXuat";
			this.lbChiTietPhieuXuat.Size = new System.Drawing.Size(281, 29);
			this.lbChiTietPhieuXuat.TabIndex = 0;
			this.lbChiTietPhieuXuat.Text = "CHI TIẾT PHIẾU XUẤT";
			// 
			// btnIn
			// 
			this.btnIn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIn.Location = new System.Drawing.Point(757, 160);
			this.btnIn.Name = "btnIn";
			this.btnIn.Size = new System.Drawing.Size(75, 23);
			this.btnIn.TabIndex = 43;
			this.btnIn.Text = "In ra";
			this.btnIn.UseVisualStyleBackColor = true;
			this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
			// 
			// frmChiTietPhieuXuat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 450);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmChiTietPhieuXuat";
			this.Text = "Chi tiết phiếu xuất";
			this.Load += new System.EventHandler(this.frmChiTietPhieuXuat_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgChiTietPhieuXuat)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btSanPham;
		private System.Windows.Forms.Button bttrolai;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTongtien;
		private System.Windows.Forms.Label labeltongtien;
		private System.Windows.Forms.Button btLamMoi;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.Label lbDonGia;
		private System.Windows.Forms.ComboBox cbMaPhieuXuat;
		private System.Windows.Forms.Button btThoat;
		private System.Windows.Forms.Button btThem;
		private System.Windows.Forms.Button btXoa;
		private System.Windows.Forms.ComboBox cbMaSanPham;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Label lbSoLuong;
		private System.Windows.Forms.Label lbMasp;
		private System.Windows.Forms.TextBox txtThanhTien;
		private System.Windows.Forms.Label lbTongTien;
		private System.Windows.Forms.Label lbMaPhieuXuat;
		private System.Windows.Forms.DataGridView dgChiTietPhieuXuat;
		private System.Windows.Forms.Button btTimKiem;
		private System.Windows.Forms.ComboBox cbTimKiem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label lbChiTietPhieuXuat;
		private System.Windows.Forms.Button btnIn;
	}
}