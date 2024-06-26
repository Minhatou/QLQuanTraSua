﻿namespace CoffeManager
{
    partial class fTableManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
			this.fTableControlPanel = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtMon = new Guna.UI2.WinForms.Guna2TextBox();
			this.fCheck = new Guna.UI2.WinForms.Guna2Button();
			this.fDiscountValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.f3T = new Guna.UI2.WinForms.Guna2TextBox();
			this.fAddMenu = new Guna.UI2.WinForms.Guna2Button();
			this.fMenuValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.fBevName = new Guna.UI2.WinForms.Guna2ComboBox();
			this.fBillPanel = new System.Windows.Forms.Panel();
			this.fBillInfo = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.fAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.fUserAcc = new System.Windows.Forms.ToolStripMenuItem();
			this.accountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fHome = new System.Windows.Forms.ToolStripMenuItem();
			this.quayVềTrangĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fTableList = new System.Windows.Forms.FlowLayoutPanel();
			this.fBevMenu = new System.Windows.Forms.ComboBox();
			this.fTableControlPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fDiscountValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fMenuValue)).BeginInit();
			this.fBillPanel.SuspendLayout();
			this.fMenuStrip.SuspendLayout();
			this.fTableList.SuspendLayout();
			this.SuspendLayout();
			// 
			// fTableControlPanel
			// 
			this.fTableControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fTableControlPanel.AutoSize = true;
			this.fTableControlPanel.Controls.Add(this.label5);
			this.fTableControlPanel.Controls.Add(this.label4);
			this.fTableControlPanel.Controls.Add(this.txtDonGia);
			this.fTableControlPanel.Controls.Add(this.txtMon);
			this.fTableControlPanel.Controls.Add(this.fCheck);
			this.fTableControlPanel.Controls.Add(this.fDiscountValue);
			this.fTableControlPanel.Controls.Add(this.label2);
			this.fTableControlPanel.Controls.Add(this.label3);
			this.fTableControlPanel.Controls.Add(this.label1);
			this.fTableControlPanel.Controls.Add(this.f3T);
			this.fTableControlPanel.Controls.Add(this.fAddMenu);
			this.fTableControlPanel.Controls.Add(this.fMenuValue);
			this.fTableControlPanel.Location = new System.Drawing.Point(9, 399);
			this.fTableControlPanel.Margin = new System.Windows.Forms.Padding(2);
			this.fTableControlPanel.Name = "fTableControlPanel";
			this.fTableControlPanel.Padding = new System.Windows.Forms.Padding(8);
			this.fTableControlPanel.Size = new System.Drawing.Size(506, 243);
			this.fTableControlPanel.TabIndex = 2;
			this.fTableControlPanel.TabStop = true;
			this.fTableControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.fTableControlPanel_Paint);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label5.Location = new System.Drawing.Point(231, 43);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 19);
			this.label5.TabIndex = 19;
			this.label5.Text = "Đơn giá";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label4.Location = new System.Drawing.Point(10, 43);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 19);
			this.label4.TabIndex = 18;
			this.label4.Text = "Tên món";
			// 
			// txtDonGia
			// 
			this.txtDonGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtDonGia.BorderRadius = 5;
			this.txtDonGia.BorderThickness = 2;
			this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDonGia.DefaultText = "";
			this.txtDonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtDonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtDonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtDonGia.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtDonGia.Location = new System.Drawing.Point(226, 65);
			this.txtDonGia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.PasswordChar = '\0';
			this.txtDonGia.PlaceholderText = "";
			this.txtDonGia.ReadOnly = true;
			this.txtDonGia.SelectedText = "";
			this.txtDonGia.Size = new System.Drawing.Size(200, 34);
			this.txtDonGia.TabIndex = 17;
			this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtMon
			// 
			this.txtMon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtMon.BorderRadius = 5;
			this.txtMon.BorderThickness = 2;
			this.txtMon.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMon.DefaultText = "";
			this.txtMon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMon.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMon.Location = new System.Drawing.Point(10, 65);
			this.txtMon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtMon.Name = "txtMon";
			this.txtMon.PasswordChar = '\0';
			this.txtMon.PlaceholderText = "";
			this.txtMon.ReadOnly = true;
			this.txtMon.SelectedText = "";
			this.txtMon.Size = new System.Drawing.Size(200, 34);
			this.txtMon.TabIndex = 16;
			this.txtMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// fCheck
			// 
			this.fCheck.BorderRadius = 5;
			this.fCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.fCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.fCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.fCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.fCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.fCheck.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fCheck.ForeColor = System.Drawing.Color.White;
			this.fCheck.Location = new System.Drawing.Point(302, 197);
			this.fCheck.Margin = new System.Windows.Forms.Padding(2);
			this.fCheck.Name = "fCheck";
			this.fCheck.Size = new System.Drawing.Size(149, 35);
			this.fCheck.TabIndex = 10;
			this.fCheck.Text = "Thanh toán";
			this.fCheck.Click += new System.EventHandler(this.fCheck_Click);
			// 
			// fDiscountValue
			// 
			this.fDiscountValue.BackColor = System.Drawing.Color.Transparent;
			this.fDiscountValue.BorderRadius = 5;
			this.fDiscountValue.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.fDiscountValue.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.fDiscountValue.Location = new System.Drawing.Point(129, 197);
			this.fDiscountValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.fDiscountValue.Name = "fDiscountValue";
			this.fDiscountValue.Size = new System.Drawing.Size(159, 35);
			this.fDiscountValue.TabIndex = 13;
			this.fDiscountValue.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.fDiscountValue.ValueChanged += new System.EventHandler(this.fDiscountValue_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Location = new System.Drawing.Point(0, 202);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 19);
			this.label2.TabIndex = 13;
			this.label2.Text = "Giảm giá (%)";
			this.label2.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label3.Location = new System.Drawing.Point(0, 124);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 19);
			this.label3.TabIndex = 13;
			this.label3.Text = "Số lượng";
			this.label3.Click += new System.EventHandler(this.label1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(0, 165);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 19);
			this.label1.TabIndex = 13;
			this.label1.Text = "Tổng tiền tạm tính";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// f3T
			// 
			this.f3T.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.f3T.BorderRadius = 5;
			this.f3T.BorderThickness = 2;
			this.f3T.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.f3T.DefaultText = "0000";
			this.f3T.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.f3T.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.f3T.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.f3T.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.f3T.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.f3T.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.f3T.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.f3T.Location = new System.Drawing.Point(168, 157);
			this.f3T.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.f3T.Name = "f3T";
			this.f3T.PasswordChar = '\0';
			this.f3T.PlaceholderText = "";
			this.f3T.ReadOnly = true;
			this.f3T.SelectedText = "";
			this.f3T.Size = new System.Drawing.Size(284, 34);
			this.f3T.TabIndex = 0;
			this.f3T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.f3T.TextChanged += new System.EventHandler(this.f3T_TextChanged);
			// 
			// fAddMenu
			// 
			this.fAddMenu.BorderRadius = 5;
			this.fAddMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.fAddMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.fAddMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.fAddMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.fAddMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.fAddMenu.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fAddMenu.ForeColor = System.Drawing.Color.White;
			this.fAddMenu.Location = new System.Drawing.Point(208, 111);
			this.fAddMenu.Margin = new System.Windows.Forms.Padding(2);
			this.fAddMenu.Name = "fAddMenu";
			this.fAddMenu.Size = new System.Drawing.Size(244, 40);
			this.fAddMenu.TabIndex = 9;
			this.fAddMenu.Text = "Thêm món";
			this.fAddMenu.Click += new System.EventHandler(this.fAddMenu_Click);
			// 
			// fMenuValue
			// 
			this.fMenuValue.BackColor = System.Drawing.Color.Transparent;
			this.fMenuValue.BorderRadius = 5;
			this.fMenuValue.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.fMenuValue.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.fMenuValue.Location = new System.Drawing.Point(88, 110);
			this.fMenuValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.fMenuValue.Name = "fMenuValue";
			this.fMenuValue.Size = new System.Drawing.Size(112, 40);
			this.fMenuValue.TabIndex = 6;
			this.fMenuValue.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.fMenuValue.ValueChanged += new System.EventHandler(this.fMenuValue_ValueChanged);
			// 
			// fBevName
			// 
			this.fBevName.BackColor = System.Drawing.Color.Transparent;
			this.fBevName.BorderRadius = 5;
			this.fBevName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.fBevName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fBevName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.fBevName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.fBevName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fBevName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.fBevName.IntegralHeight = false;
			this.fBevName.ItemHeight = 30;
			this.fBevName.ItemsAppearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fBevName.Location = new System.Drawing.Point(2, 2);
			this.fBevName.Margin = new System.Windows.Forms.Padding(2);
			this.fBevName.Name = "fBevName";
			this.fBevName.Size = new System.Drawing.Size(245, 36);
			this.fBevName.TabIndex = 11;
			this.fBevName.SelectedIndexChanged += new System.EventHandler(this.fBevName_SelectedIndexChanged);
			// 
			// fBillPanel
			// 
			this.fBillPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.fBillPanel.AutoSize = true;
			this.fBillPanel.Controls.Add(this.fBillInfo);
			this.fBillPanel.Location = new System.Drawing.Point(519, 397);
			this.fBillPanel.Margin = new System.Windows.Forms.Padding(2);
			this.fBillPanel.Name = "fBillPanel";
			this.fBillPanel.Size = new System.Drawing.Size(728, 238);
			this.fBillPanel.TabIndex = 3;
			// 
			// fBillInfo
			// 
			this.fBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.fBillInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fBillInfo.GridLines = true;
			this.fBillInfo.HideSelection = false;
			this.fBillInfo.Location = new System.Drawing.Point(2, 19);
			this.fBillInfo.Margin = new System.Windows.Forms.Padding(2);
			this.fBillInfo.Name = "fBillInfo";
			this.fBillInfo.Size = new System.Drawing.Size(724, 215);
			this.fBillInfo.TabIndex = 0;
			this.fBillInfo.UseCompatibleStateImageBehavior = false;
			this.fBillInfo.View = System.Windows.Forms.View.Details;
			this.fBillInfo.SelectedIndexChanged += new System.EventHandler(this.fBillInfo_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên thực đơn";
			this.columnHeader1.Width = 252;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số lượng";
			this.columnHeader2.Width = 90;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Đơn giá";
			this.columnHeader3.Width = 170;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tổng tiền";
			this.columnHeader4.Width = 226;
			// 
			// fAdmin
			// 
			this.fAdmin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.fAdmin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.fAdmin.Name = "fAdmin";
			this.fAdmin.Size = new System.Drawing.Size(67, 22);
			this.fAdmin.Text = "Quản lý";
			this.fAdmin.Click += new System.EventHandler(this.fAdmin1_Click);
			// 
			// fUserAcc
			// 
			this.fUserAcc.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.fUserAcc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountInfoToolStripMenuItem,
            this.logOutToolStripMenuItem});
			this.fUserAcc.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fUserAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.fUserAcc.Name = "fUserAcc";
			this.fUserAcc.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fUserAcc.Size = new System.Drawing.Size(84, 22);
			this.fUserAcc.Text = "Tài khoản";
			// 
			// accountInfoToolStripMenuItem
			// 
			this.accountInfoToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.accountInfoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.accountInfoToolStripMenuItem.Name = "accountInfoToolStripMenuItem";
			this.accountInfoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.accountInfoToolStripMenuItem.Text = "Thông tin tài khoản";
			this.accountInfoToolStripMenuItem.Click += new System.EventHandler(this.accountInfoToolStripMenuItem_Click);
			// 
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.logOutToolStripMenuItem.Text = "Đăng xuất";
			this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
			// 
			// fHome
			// 
			this.fHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.fHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayVềTrangĐăngNhậpToolStripMenuItem});
			this.fHome.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fHome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.fHome.Name = "fHome";
			this.fHome.Size = new System.Drawing.Size(117, 22);
			this.fHome.Text = "Màn hình chính";
			this.fHome.Click += new System.EventHandler(this.fHome_Click);
			this.fHome.TextChanged += new System.EventHandler(this.fHome_TextChanged);
			// 
			// quayVềTrangĐăngNhậpToolStripMenuItem
			// 
			this.quayVềTrangĐăngNhậpToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quayVềTrangĐăngNhậpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.quayVềTrangĐăngNhậpToolStripMenuItem.Name = "quayVềTrangĐăngNhậpToolStripMenuItem";
			this.quayVềTrangĐăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.quayVềTrangĐăngNhậpToolStripMenuItem.Text = "Thoát";
			this.quayVềTrangĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.quayVềTrangĐăngNhậpToolStripMenuItem_Click);
			// 
			// fMenuStrip
			// 
			this.fMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.fMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.fMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fHome,
            this.fUserAcc,
            this.fAdmin});
			this.fMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.fMenuStrip.Name = "fMenuStrip";
			this.fMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.fMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.fMenuStrip.Size = new System.Drawing.Size(1256, 26);
			this.fMenuStrip.TabIndex = 0;
			this.fMenuStrip.Text = "menuStrip1";
			// 
			// fTableList
			// 
			this.fTableList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fTableList.AutoScroll = true;
			this.fTableList.Controls.Add(this.fBevName);
			this.fTableList.Location = new System.Drawing.Point(9, 74);
			this.fTableList.Margin = new System.Windows.Forms.Padding(2);
			this.fTableList.Name = "fTableList";
			this.fTableList.Size = new System.Drawing.Size(1238, 299);
			this.fTableList.TabIndex = 4;
			this.fTableList.Paint += new System.Windows.Forms.PaintEventHandler(this.fTableList_Paint);
			// 
			// fBevMenu
			// 
			this.fBevMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fBevMenu.FormattingEnabled = true;
			this.fBevMenu.Location = new System.Drawing.Point(13, 41);
			this.fBevMenu.Name = "fBevMenu";
			this.fBevMenu.Size = new System.Drawing.Size(241, 28);
			this.fBevMenu.TabIndex = 5;
			this.fBevMenu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// fTableManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1256, 645);
			this.Controls.Add(this.fBevMenu);
			this.Controls.Add(this.fTableControlPanel);
			this.Controls.Add(this.fTableList);
			this.Controls.Add(this.fBillPanel);
			this.Controls.Add(this.fMenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.fMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "fTableManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý trà sữa";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTableManager_FormClosing);
			this.Load += new System.EventHandler(this.fTableManager_Load);
			this.fTableControlPanel.ResumeLayout(false);
			this.fTableControlPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fDiscountValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fMenuValue)).EndInit();
			this.fBillPanel.ResumeLayout(false);
			this.fMenuStrip.ResumeLayout(false);
			this.fMenuStrip.PerformLayout();
			this.fTableList.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel fTableControlPanel;
        private System.Windows.Forms.Panel fBillPanel;
        private System.Windows.Forms.ListView fBillInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2Button fAddMenu;
        private Guna.UI2.WinForms.Guna2Button fCheck;
        private Guna.UI2.WinForms.Guna2NumericUpDown fMenuValue;
        private System.Windows.Forms.MenuStrip fMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fAdmin;
        private System.Windows.Forms.ToolStripMenuItem fUserAcc;
        private System.Windows.Forms.ToolStripMenuItem accountInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fHome;
        private System.Windows.Forms.FlowLayoutPanel fTableList;
        private Guna.UI2.WinForms.Guna2TextBox f3T;
        private Guna.UI2.WinForms.Guna2NumericUpDown fDiscountValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem quayVềTrangĐăngNhậpToolStripMenuItem;
		private Guna.UI2.WinForms.Guna2TextBox txtDonGia;
		private Guna.UI2.WinForms.Guna2TextBox txtMon;
		private Guna.UI2.WinForms.Guna2ComboBox fBevName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox fBevMenu;
	}
}