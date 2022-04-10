namespace Loader
{
	// Token: 0x0200000A RID: 10
	public partial class Info : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00006A32 File Offset: 0x00004C32
		protected override void Dispose(bool disposing)
		{
			/*
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);*/
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006A54 File Offset: 0x00004C54
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Loader.Info));
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.siticoneRoundedButton1 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel3.BackColor = global::System.Drawing.Color.Red;
			this.panel3.Location = new global::System.Drawing.Point(-10, -9);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(434, 16);
			this.panel3.TabIndex = 48;
			this.panel1.BackColor = global::System.Drawing.Color.Red;
			this.panel1.Location = new global::System.Drawing.Point(-10, 352);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(271, 39);
			this.panel1.TabIndex = 49;
			this.panel2.BackColor = global::System.Drawing.Color.Red;
			this.panel2.Location = new global::System.Drawing.Point(240, -6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(248, 386);
			this.panel2.TabIndex = 50;
			this.panel4.BackColor = global::System.Drawing.Color.Red;
			this.panel4.Location = new global::System.Drawing.Point(-42, -9);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(50, 389);
			this.panel4.TabIndex = 51;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(76, 72);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(95, 20);
			this.label6.TabIndex = 54;
			this.label6.Text = "Developer:";
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.Lime;
			this.label5.Location = new global::System.Drawing.Point(58, 101);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(135, 21);
			this.label5.TabIndex = 55;
			this.label5.Text = "$ Bronkz#0171";
			this.label5.Click += new global::System.EventHandler(this.label5_Click);
			this.siticoneRoundedButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton1.BorderColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton1.BorderThickness = 1;
			this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.FillColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton1.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Location = new global::System.Drawing.Point(161, 302);
			this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
			this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Size = new global::System.Drawing.Size(73, 44);
			this.siticoneRoundedButton1.TabIndex = 58;
			this.siticoneRoundedButton1.Text = "Main";
			this.siticoneRoundedButton1.Click += new global::System.EventHandler(this.siticoneRoundedButton1_Click);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(80, 139);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(91, 84);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 59;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(248, 360);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.siticoneRoundedButton1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel3);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Info";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Info";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Info_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000041 RID: 65
		//private global::System.ComponentModel.IContainer components;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000048 RID: 72
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
