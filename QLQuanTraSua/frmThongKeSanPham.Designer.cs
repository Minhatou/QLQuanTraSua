namespace QLQuanTraSua
{
	partial class frmThongKeSanPham
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeSanPham));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lbThongKesp = new System.Windows.Forms.Label();
			this.groupBoxdanhsach = new System.Windows.Forms.GroupBox();
			this.dgThongKesp = new System.Windows.Forms.DataGridView();
			this.groupBoxthongkesp = new System.Windows.Forms.GroupBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsThongKe = new System.Windows.Forms.ToolStripButton();
			this.tsLamMoi = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.tsThoat = new System.Windows.Forms.ToolStripButton();
			this.cbKieuThongKe = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBoxdanhsach.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgThongKesp)).BeginInit();
			this.groupBoxthongkesp.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(-8, 13);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.splitContainer1.Panel1.Controls.Add(this.lbThongKesp);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxdanhsach);
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxthongkesp);
			this.splitContainer1.Size = new System.Drawing.Size(816, 424);
			this.splitContainer1.SplitterDistance = 60;
			this.splitContainer1.TabIndex = 1;
			// 
			// lbThongKesp
			// 
			this.lbThongKesp.AutoSize = true;
			this.lbThongKesp.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbThongKesp.Location = new System.Drawing.Point(256, 16);
			this.lbThongKesp.Name = "lbThongKesp";
			this.lbThongKesp.Size = new System.Drawing.Size(275, 29);
			this.lbThongKesp.TabIndex = 0;
			this.lbThongKesp.Text = "THỐNG KÊ SẢN PHẨM";
			// 
			// groupBoxdanhsach
			// 
			this.groupBoxdanhsach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.groupBoxdanhsach.Controls.Add(this.dgThongKesp);
			this.groupBoxdanhsach.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxdanhsach.Location = new System.Drawing.Point(0, 112);
			this.groupBoxdanhsach.Name = "groupBoxdanhsach";
			this.groupBoxdanhsach.Size = new System.Drawing.Size(816, 248);
			this.groupBoxdanhsach.TabIndex = 1;
			this.groupBoxdanhsach.TabStop = false;
			this.groupBoxdanhsach.Text = "Danh sách";
			// 
			// dgThongKesp
			// 
			this.dgThongKesp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgThongKesp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgThongKesp.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgThongKesp.Location = new System.Drawing.Point(3, 45);
			this.dgThongKesp.Name = "dgThongKesp";
			this.dgThongKesp.Size = new System.Drawing.Size(810, 200);
			this.dgThongKesp.TabIndex = 0;
			this.dgThongKesp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgThongKesp_CellContentClick);
			// 
			// groupBoxthongkesp
			// 
			this.groupBoxthongkesp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.groupBoxthongkesp.Controls.Add(this.toolStrip1);
			this.groupBoxthongkesp.Controls.Add(this.cbKieuThongKe);
			this.groupBoxthongkesp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBoxthongkesp.Location = new System.Drawing.Point(0, 8);
			this.groupBoxthongkesp.Name = "groupBoxthongkesp";
			this.groupBoxthongkesp.Size = new System.Drawing.Size(816, 96);
			this.groupBoxthongkesp.TabIndex = 0;
			this.groupBoxthongkesp.TabStop = false;
			this.groupBoxthongkesp.Text = "Thống kê";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThongKe,
            this.tsLamMoi,
            this.toolStripButton1,
            this.tsThoat});
			this.toolStrip1.Location = new System.Drawing.Point(3, 19);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(810, 25);
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
			// tsLamMoi
			// 
			this.tsLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("tsLamMoi.Image")));
			this.tsLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsLamMoi.Name = "tsLamMoi";
			this.tsLamMoi.Size = new System.Drawing.Size(74, 22);
			this.tsLamMoi.Text = "Làm mới";
			this.tsLamMoi.Click += new System.EventHandler(this.tsLamMoi_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(64, 22);
			this.toolStripButton1.Text = "Trở lại";
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
			// cbKieuThongKe
			// 
			this.cbKieuThongKe.FormattingEnabled = true;
			this.cbKieuThongKe.Items.AddRange(new object[] {
            "Thống kê sản phẩm bán chạy",
            "Thống kê sản phẩm bán chậm"});
			this.cbKieuThongKe.Location = new System.Drawing.Point(16, 56);
			this.cbKieuThongKe.Name = "cbKieuThongKe";
			this.cbKieuThongKe.Size = new System.Drawing.Size(264, 24);
			this.cbKieuThongKe.TabIndex = 1;
			this.cbKieuThongKe.Tag = "";
			this.cbKieuThongKe.Text = "Chọn kiểu thống kê";
			// 
			// frmThongKeSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(809, 450);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmThongKeSanPham";
			this.Text = "Thống kê sản phẩm";
			this.Load += new System.EventHandler(this.frmThongKeSanPham_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBoxdanhsach.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgThongKesp)).EndInit();
			this.groupBoxthongkesp.ResumeLayout(false);
			this.groupBoxthongkesp.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label lbThongKesp;
		private System.Windows.Forms.GroupBox groupBoxdanhsach;
		private System.Windows.Forms.DataGridView dgThongKesp;
		private System.Windows.Forms.GroupBox groupBoxthongkesp;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsThongKe;
		private System.Windows.Forms.ToolStripButton tsLamMoi;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton tsThoat;
		private System.Windows.Forms.ComboBox cbKieuThongKe;
	}
}