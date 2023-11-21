namespace CoffeManager
{
    partial class fLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
			this.fLoginButton = new Guna.UI2.WinForms.Guna2Button();
			this.fUsernameInput = new Guna.UI2.WinForms.Guna2TextBox();
			this.fPassInput = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.fCMSLoginPanel = new System.Windows.Forms.Panel();
			this.fNotice = new Guna.UI2.WinForms.Guna2HtmlLabel();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
			this.fCMSLoginPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// fLoginButton
			// 
			this.fLoginButton.BorderRadius = 5;
			this.fLoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.fLoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.fLoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.fLoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.fLoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.fLoginButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fLoginButton.ForeColor = System.Drawing.Color.White;
			this.fLoginButton.Location = new System.Drawing.Point(292, 275);
			this.fLoginButton.Margin = new System.Windows.Forms.Padding(2);
			this.fLoginButton.Name = "fLoginButton";
			this.fLoginButton.Size = new System.Drawing.Size(281, 45);
			this.fLoginButton.TabIndex = 6;
			this.fLoginButton.Text = "Đăng nhập";
			this.fLoginButton.Click += new System.EventHandler(this.fLogInButton_Click);
			// 
			// fUsernameInput
			// 
			this.fUsernameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fUsernameInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.fUsernameInput.BorderRadius = 5;
			this.fUsernameInput.BorderThickness = 2;
			this.fUsernameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.fUsernameInput.DefaultText = "";
			this.fUsernameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.fUsernameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.fUsernameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.fUsernameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.fUsernameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.fUsernameInput.Font = new System.Drawing.Font("Tahoma", 12F);
			this.fUsernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.fUsernameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.fUsernameInput.Location = new System.Drawing.Point(292, 106);
			this.fUsernameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.fUsernameInput.Name = "fUsernameInput";
			this.fUsernameInput.PasswordChar = '\0';
			this.fUsernameInput.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.fUsernameInput.PlaceholderText = "Tên tài khoản";
			this.fUsernameInput.SelectedText = "";
			this.fUsernameInput.ShortcutsEnabled = false;
			this.fUsernameInput.Size = new System.Drawing.Size(281, 37);
			this.fUsernameInput.TabIndex = 1;
			this.fUsernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.fUsernameInput.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
			// 
			// fPassInput
			// 
			this.fPassInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.fPassInput.BorderRadius = 5;
			this.fPassInput.BorderThickness = 2;
			this.fPassInput.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.fPassInput.DefaultText = "";
			this.fPassInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.fPassInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.fPassInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.fPassInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.fPassInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.fPassInput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fPassInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.fPassInput.Location = new System.Drawing.Point(292, 166);
			this.fPassInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.fPassInput.Name = "fPassInput";
			this.fPassInput.PasswordChar = '*';
			this.fPassInput.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.fPassInput.PlaceholderText = "Mật khẩu";
			this.fPassInput.SelectedText = "";
			this.fPassInput.Size = new System.Drawing.Size(281, 37);
			this.fPassInput.TabIndex = 2;
			this.fPassInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.fPassInput.TextChanged += new System.EventHandler(this.fPassInput_TextChanged);
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(566, 2);
			this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(20, 21);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 8;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click_2);
			// 
			// guna2PictureBox4
			// 
			this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox4.FillColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox4.Image = global::CoffeManager.Properties.Resources.Logo_Tocotoco_V;
			this.guna2PictureBox4.ImageRotate = 0F;
			this.guna2PictureBox4.Location = new System.Drawing.Point(57, 58);
			this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(2);
			this.guna2PictureBox4.Name = "guna2PictureBox4";
			this.guna2PictureBox4.Size = new System.Drawing.Size(192, 191);
			this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox4.TabIndex = 17;
			this.guna2PictureBox4.TabStop = false;
			// 
			// fCMSLoginPanel
			// 
			this.fCMSLoginPanel.BackColor = System.Drawing.Color.Transparent;
			this.fCMSLoginPanel.Controls.Add(this.guna2PictureBox4);
			this.fCMSLoginPanel.Controls.Add(this.guna2PictureBox1);
			this.fCMSLoginPanel.Controls.Add(this.fPassInput);
			this.fCMSLoginPanel.Controls.Add(this.fUsernameInput);
			this.fCMSLoginPanel.Controls.Add(this.fLoginButton);
			this.fCMSLoginPanel.Location = new System.Drawing.Point(4, 10);
			this.fCMSLoginPanel.Margin = new System.Windows.Forms.Padding(2);
			this.fCMSLoginPanel.Name = "fCMSLoginPanel";
			this.fCMSLoginPanel.Size = new System.Drawing.Size(592, 346);
			this.fCMSLoginPanel.TabIndex = 0;
			this.fCMSLoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// fNotice
			// 
			this.fNotice.BackColor = System.Drawing.Color.Transparent;
			this.fNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.fNotice.Location = new System.Drawing.Point(292, 231);
			this.fNotice.Margin = new System.Windows.Forms.Padding(2);
			this.fNotice.Name = "fNotice";
			this.fNotice.Size = new System.Drawing.Size(86, 15);
			this.fNotice.TabIndex = 7;
			this.fNotice.Text = "guna2HtmlLabel1";
			this.fNotice.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
			this.fNotice.Visible = false;
			this.fNotice.Click += new System.EventHandler(this.fNotice_Click);
			// 
			// fLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CoffeManager.Properties.Resources.abstract_modern_yellow_gradient_diagonal_lines_background_free_vector;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.fCMSLoginPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "fLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
			this.Load += new System.EventHandler(this.fLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
			this.fCMSLoginPanel.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private Guna.UI2.WinForms.Guna2Button fLoginButton;
		private Guna.UI2.WinForms.Guna2TextBox fUsernameInput;
		private Guna.UI2.WinForms.Guna2TextBox fPassInput;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
		private System.Windows.Forms.Panel fCMSLoginPanel;
		private Guna.UI2.WinForms.Guna2HtmlLabel fNotice;
	}
}

