namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00003B7B File Offset: 0x00001D7B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003BA0 File Offset: 0x00001DA0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::KeyAuth.Main));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.sendmsg = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.siticoneRoundedButton2 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton3 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.panel6 = new global::System.Windows.Forms.Panel();
			this.panel7 = new global::System.Windows.Forms.Panel();
			this.siticoneRoundedButton1 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton4 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(552, 1);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(501, 1);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Red;
			this.label2.Location = new global::System.Drawing.Point(10, 11);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(128, 19);
			this.label2.TabIndex = 27;
			this.label2.Text = "VulcanShop | Main";
			this.sendmsg.BackColor = global::System.Drawing.Color.Transparent;
			this.sendmsg.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("sendmsg.BackgroundImage");
			this.sendmsg.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.sendmsg.BorderColor = global::System.Drawing.Color.Transparent;
			this.sendmsg.BorderThickness = 1;
			this.sendmsg.CheckedState.Parent = this.sendmsg;
			this.sendmsg.CustomImages.Parent = this.sendmsg;
			this.siticoneTransition1.SetDecoration(this.sendmsg, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.sendmsg.FillColor = global::System.Drawing.Color.Transparent;
			this.sendmsg.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.sendmsg.ForeColor = global::System.Drawing.Color.White;
			this.sendmsg.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.sendmsg.HoveredState.Parent = this.sendmsg;
			this.sendmsg.Location = new global::System.Drawing.Point(465, 1);
			this.sendmsg.Name = "sendmsg";
			this.sendmsg.ShadowDecoration.Parent = this.sendmsg;
			this.sendmsg.Size = new global::System.Drawing.Size(40, 32);
			this.sendmsg.TabIndex = 42;
			this.sendmsg.Click += new global::System.EventHandler(this.sendmsg_Click_1);
			this.panel4.BackColor = global::System.Drawing.Color.Red;
			this.siticoneTransition1.SetDecoration(this.panel4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel4.Location = new global::System.Drawing.Point(-42, -6);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(47, 382);
			this.panel4.TabIndex = 44;
			this.panel1.BackColor = global::System.Drawing.Color.Red;
			this.siticoneTransition1.SetDecoration(this.panel1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel1.Location = new global::System.Drawing.Point(590, -13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(257, 374);
			this.panel1.TabIndex = 45;
			this.panel2.BackColor = global::System.Drawing.Color.Red;
			this.siticoneTransition1.SetDecoration(this.panel2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel2.Location = new global::System.Drawing.Point(-5, 313);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(849, 36);
			this.panel2.TabIndex = 46;
			this.panel3.BackColor = global::System.Drawing.Color.Red;
			this.siticoneTransition1.SetDecoration(this.panel3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel3.Location = new global::System.Drawing.Point(-12, -94);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(832, 102);
			this.panel3.TabIndex = 47;
			this.siticoneTransition1.SetDecoration(this.pictureBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(446, 174);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(91, 84);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 48;
			this.pictureBox1.TabStop = false;
			this.label3.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(451, 47);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(86, 25);
			this.label3.TabIndex = 49;
			this.label3.Text = "Status:";
			this.label4.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.Lime;
			this.label4.Location = new global::System.Drawing.Point(451, 72);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(80, 25);
			this.label4.TabIndex = 50;
			this.label4.Text = "Online";
			this.panel5.BackColor = global::System.Drawing.Color.Red;
			this.siticoneTransition1.SetDecoration(this.panel5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel5.ForeColor = global::System.Drawing.Color.Red;
			this.panel5.Location = new global::System.Drawing.Point(407, 108);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(175, 10);
			this.panel5.TabIndex = 51;
			this.label5.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.Red;
			this.label5.Location = new global::System.Drawing.Point(427, 146);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(135, 20);
			this.label5.TabIndex = 52;
			this.label5.Text = "NezKaum#6666";
			this.label6.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label6, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(451, 121);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(86, 25);
			this.label6.TabIndex = 53;
			this.label6.Text = "Owner:";
			this.label7.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.siticoneTransition1.SetDecoration(this.label7, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label7.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(-2, 47);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(233, 274);
			this.label7.TabIndex = 54;
			this.label7.Text = " \r\n  Instruction | VulcanShop\r\n\r\n\r\n\r\n  1. Open Warzone\r\n\r\n  2. Press Unlock All\r\n\r\n  3. Once Fully Injected ";
			this.siticoneRoundedButton2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton2.BorderColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton2.BorderThickness = 1;
			this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton2.FillColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton2.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton2.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Location = new global::System.Drawing.Point(237, 47);
			this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
			this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Size = new global::System.Drawing.Size(86, 43);
			this.siticoneRoundedButton2.TabIndex = 55;
			this.siticoneRoundedButton2.Text = "Unlock All";
			this.siticoneRoundedButton2.Click += new global::System.EventHandler(this.siticoneRoundedButton2_Click);
			this.siticoneRoundedButton3.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton3.BorderColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton3.BorderThickness = 1;
			this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
			this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton3.FillColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton3.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton3.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton3.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton3.HoveredState.Parent = this.siticoneRoundedButton3;
			this.siticoneRoundedButton3.Location = new global::System.Drawing.Point(237, 146);
			this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
			this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
			this.siticoneRoundedButton3.Size = new global::System.Drawing.Size(86, 43);
			this.siticoneRoundedButton3.TabIndex = 56;
			this.siticoneRoundedButton3.Text = "Cleaner COD";
			this.siticoneRoundedButton3.Click += new global::System.EventHandler(this.siticoneRoundedButton3_Click);
			this.panel6.BackColor = global::System.Drawing.Color.Red;
			this.siticoneTransition1.SetDecoration(this.panel6, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel6.Location = new global::System.Drawing.Point(223, 47);
			this.panel6.Name = "panel6";
			this.panel6.Size = new global::System.Drawing.Size(11, 328);
			this.panel6.TabIndex = 47;
			this.panel7.BackColor = global::System.Drawing.Color.Red;
			this.siticoneTransition1.SetDecoration(this.panel7, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel7.Location = new global::System.Drawing.Point(-12, 47);
			this.panel7.Name = "panel7";
			this.panel7.Size = new global::System.Drawing.Size(246, 10);
			this.panel7.TabIndex = 48;
			this.siticoneRoundedButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton1.BorderColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton1.BorderThickness = 1;
			this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton1.FillColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton1.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Location = new global::System.Drawing.Point(237, 264);
			this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
			this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Size = new global::System.Drawing.Size(86, 43);
			this.siticoneRoundedButton1.TabIndex = 57;
			this.siticoneRoundedButton1.Text = "Information";
			this.siticoneRoundedButton1.Click += new global::System.EventHandler(this.siticoneRoundedButton1_Click);
			this.siticoneRoundedButton4.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton4.BorderColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton4.BorderThickness = 1;
			this.siticoneRoundedButton4.CheckedState.Parent = this.siticoneRoundedButton4;
			this.siticoneRoundedButton4.CustomImages.Parent = this.siticoneRoundedButton4;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton4, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneRoundedButton4.FillColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton4.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton4.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton4.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton4.HoveredState.Parent = this.siticoneRoundedButton4;
			this.siticoneRoundedButton4.Location = new global::System.Drawing.Point(237, 96);
			this.siticoneRoundedButton4.Name = "siticoneRoundedButton4";
			this.siticoneRoundedButton4.ShadowDecoration.Parent = this.siticoneRoundedButton4;
			this.siticoneRoundedButton4.Size = new global::System.Drawing.Size(86, 43);
			this.siticoneRoundedButton4.TabIndex = 58;
			this.siticoneRoundedButton4.Text = "CamoSwap";
			this.siticoneRoundedButton4.Click += new global::System.EventHandler(this.siticoneRoundedButton4_Click);
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(596, 321);
			base.Controls.Add(this.siticoneRoundedButton1);
			base.Controls.Add(this.panel6);
			base.Controls.Add(this.panel7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			base.Controls.Add(this.siticoneRoundedButton2);
			base.Controls.Add(this.siticoneRoundedButton3);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.sendmsg);
			base.Controls.Add(this.siticoneRoundedButton4);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Main_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000F RID: 15
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000010 RID: 16
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000011 RID: 17
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000012 RID: 18
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000013 RID: 19
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000016 RID: 22
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000017 RID: 23
		private global::Siticone.UI.WinForms.SiticoneRoundedButton sendmsg;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x0400001D RID: 29
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton3;

		// Token: 0x0400001E RID: 30
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Panel panel6;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Panel panel7;

		// Token: 0x04000028 RID: 40
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;

		// Token: 0x04000029 RID: 41
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton4;
	}
}
