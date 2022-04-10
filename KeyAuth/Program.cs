using System;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x0600003F RID: 63 RVA: 0x0000698F File Offset: 0x00004B8F
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
