namespace KeyAuth
{
	// Token: 0x02000006 RID: 6
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00005566 File Offset: 0x00003766
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000558C File Offset: 0x0000378C
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation3 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.key = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.username = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.password = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.RgstrBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.status = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.siticoneRoundedButton2 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(235, 3);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.PressedColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.BorderColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(199, 3);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.PressedColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(50);
            animation3.RotateCoeff = 1F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 27;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderColor = System.Drawing.Color.Red;
            this.LoginBtn.BorderThickness = 1;
            this.LoginBtn.CheckedState.Parent = this.LoginBtn;
            this.LoginBtn.CustomImages.Parent = this.LoginBtn;
            this.siticoneTransition1.SetDecoration(this.LoginBtn, Siticone.UI.AnimatorNS.DecorationType.None);
            this.LoginBtn.Enabled = false;
            this.LoginBtn.FillColor = System.Drawing.Color.Red;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.LoginBtn.HoveredState.Parent = this.LoginBtn;
            this.LoginBtn.Location = new System.Drawing.Point(186, 310);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
            this.LoginBtn.Size = new System.Drawing.Size(139, 27);
            this.LoginBtn.TabIndex = 26;
            this.LoginBtn.Text = "Pedofobia";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // key
            // 
            this.key.AllowDrop = true;
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.key.BorderColor = System.Drawing.Color.Red;
            this.key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.key, Siticone.UI.AnimatorNS.DecorationType.None);
            this.key.DefaultText = "Ghey";
            this.key.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.key.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.key.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.key.DisabledState.Parent = this.key;
            this.key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.key.Enabled = false;
            this.key.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.key.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.key.FocusedState.Parent = this.key;
            this.key.HoveredState.BorderColor = System.Drawing.Color.Red;
            this.key.HoveredState.Parent = this.key;
            this.key.Location = new System.Drawing.Point(49, 273);
            this.key.Margin = new System.Windows.Forms.Padding(4);
            this.key.Name = "key";
            this.key.PasswordChar = '\0';
            this.key.PlaceholderText = "";
            this.key.SelectedText = "";
            this.key.ShadowDecoration.Parent = this.key;
            this.key.Size = new System.Drawing.Size(267, 30);
            this.key.TabIndex = 32;
            this.key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // username
            // 
            this.username.AllowDrop = true;
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.username.BorderColor = System.Drawing.Color.Red;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.username, Siticone.UI.AnimatorNS.DecorationType.None);
            this.username.DefaultText = "nazi zombi";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.Enabled = false;
            this.username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.username.FocusedState.Parent = this.username;
            this.username.HoveredState.BorderColor = System.Drawing.Color.Red;
            this.username.HoveredState.Parent = this.username;
            this.username.Location = new System.Drawing.Point(49, 197);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(267, 30);
            this.username.TabIndex = 33;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.AllowDrop = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.BorderColor = System.Drawing.Color.Red;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.password, Siticone.UI.AnimatorNS.DecorationType.None);
            this.password.DefaultText = "Password";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.Enabled = false;
            this.password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.password.FocusedState.Parent = this.password;
            this.password.HoveredState.BorderColor = System.Drawing.Color.Red;
            this.password.HoveredState.Parent = this.password;
            this.password.Location = new System.Drawing.Point(49, 235);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderText = "";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(267, 30);
            this.password.TabIndex = 34;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.UseSystemPasswordChar = true;
            // 
            // RgstrBtn
            // 
            this.RgstrBtn.BackColor = System.Drawing.Color.Transparent;
            this.RgstrBtn.BorderColor = System.Drawing.Color.Red;
            this.RgstrBtn.BorderThickness = 1;
            this.RgstrBtn.CheckedState.Parent = this.RgstrBtn;
            this.RgstrBtn.CustomImages.Parent = this.RgstrBtn;
            this.siticoneTransition1.SetDecoration(this.RgstrBtn, Siticone.UI.AnimatorNS.DecorationType.None);
            this.RgstrBtn.Enabled = false;
            this.RgstrBtn.FillColor = System.Drawing.Color.Red;
            this.RgstrBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RgstrBtn.ForeColor = System.Drawing.Color.White;
            this.RgstrBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.RgstrBtn.HoveredState.Parent = this.RgstrBtn;
            this.RgstrBtn.Location = new System.Drawing.Point(41, 310);
            this.RgstrBtn.Name = "RgstrBtn";
            this.RgstrBtn.ShadowDecoration.Parent = this.RgstrBtn;
            this.RgstrBtn.Size = new System.Drawing.Size(139, 27);
            this.RgstrBtn.TabIndex = 35;
            this.RgstrBtn.Text = "porcodio";
            this.RgstrBtn.Click += new System.EventHandler(this.RgstrBtn_Click);
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.status, Siticone.UI.AnimatorNS.DecorationType.None);
            this.status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.status.Location = new System.Drawing.Point(0, 356);
            this.status.Margin = new System.Windows.Forms.Padding(2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(366, 38);
            this.status.TabIndex = 38;
            this.status.Text = "Status: Awaiting login";
            this.status.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.siticoneTransition1.SetDecoration(this.panel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(360, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 450);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.siticoneTransition1.SetDecoration(this.panel2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(-9, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 488);
            this.panel2.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.siticoneTransition1.SetDecoration(this.panel3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(-6, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 133);
            this.panel3.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.siticoneTransition1.SetDecoration(this.panel4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(-9, -107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(414, 115);
            this.panel4.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.siticoneTransition1.SetDecoration(this.pictureBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(14, -128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 42);
            this.label3.TabIndex = 43;
            this.label3.Text = "Made by Zawe";
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton1.BorderColor = System.Drawing.Color.Red;
            this.siticoneRoundedButton1.BorderThickness = 1;
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.Red;
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(120, 163);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(139, 27);
            this.siticoneRoundedButton1.TabIndex = 44;
            this.siticoneRoundedButton1.Text = "Click here to bypass!";
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // siticoneRoundedButton2
            // 
            this.siticoneRoundedButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton2.BorderColor = System.Drawing.Color.Red;
            this.siticoneRoundedButton2.BorderThickness = 1;
            this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton2.FillColor = System.Drawing.Color.Red;
            this.siticoneRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Location = new System.Drawing.Point(120, 130);
            this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
            this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Size = new System.Drawing.Size(139, 27);
            this.siticoneRoundedButton2.TabIndex = 45;
            this.siticoneRoundedButton2.Text = "Unlock All";
            this.siticoneRoundedButton2.Click += new System.EventHandler(this.siticoneRoundedButton2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 394);
            this.Controls.Add(this.siticoneRoundedButton2);
            this.Controls.Add(this.siticoneRoundedButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.RgstrBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.pictureBox1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400002B RID: 43
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400002C RID: 44
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400002D RID: 45
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400002E RID: 46
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400002F RID: 47
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000032 RID: 50
		private global::Siticone.UI.WinForms.SiticoneRoundedButton LoginBtn;

		// Token: 0x04000033 RID: 51
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000034 RID: 52
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox key;

		// Token: 0x04000035 RID: 53
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox password;

		// Token: 0x04000036 RID: 54
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox username;

		// Token: 0x04000037 RID: 55
		private global::Siticone.UI.WinForms.SiticoneRoundedButton RgstrBtn;

		// Token: 0x04000038 RID: 56
		private global::Siticone.UI.WinForms.SiticoneLabel status;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private System.Windows.Forms.ImageList imageList1;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;
    }
}
