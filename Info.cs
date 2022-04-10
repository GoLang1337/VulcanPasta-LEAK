using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using KeyAuth;
using Siticone.UI.WinForms;

namespace Loader
{
	// Token: 0x0200000A RID: 10
	public partial class Info : Form
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00006A0E File Offset: 0x00004C0E
		public Info()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006A1C File Offset: 0x00004C1C
		private void Info_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006A1E File Offset: 0x00004C1E
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006A20 File Offset: 0x00004C20
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			new Main().Show();
			base.Hide();
		}
	}
}
