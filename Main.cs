using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using DiscordRPC;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace niwarnneverdies
{
	public partial class Main : BunifuForm
	{

		private static readonly string HostsPath = Path.Combine(Environment.SystemDirectory, @"drivers\etc\hosts");

		private FiddlerService fiddlerService = new FiddlerService();

		public Main()
		{
			InitializeComponent();
			InitializeRichPresence();
		}

		public void InitializeRichPresence()
		{
			var client = new DiscordRpcClient("1215459037014138950");

			client.Initialize();
			client.SetPresence(new RichPresence()
			{
				Details = "on Niwarn Never Dies",
				Assets = new Assets()
				{
					LargeImageKey = "hsho"
				},
				Timestamps = Timestamps.FromTimeSpan(10),
				Buttons = new DiscordRPC.Button[]
				{
					new DiscordRPC.Button() { Label = "Discord", Url = "https://discord.gg/643QebXn9h" }
				}
			});
		}

		private void Creator_Click(object sender, System.EventArgs e)
		{
			Process.Start("https://linktr.ee/kunseru");
		}

		private void InitialiizeFiddlerCore()
		{
			fiddlerService.EnsureRootCertificate();
			fiddlerService.StartupFiddlerCore();
			mainNotifications.Show(this, "Proxy started, start Home Sweet Home: Online!", position: BunifuSnackbar.Positions.TopRight, type: BunifuSnackbar.MessageTypes.Information);
		}

		private void ProgressBarPerformAction()
		{
			int BufferlyProgressBarCurrentPercent = 0;
			int BufferlyProgressBarTargetPercent = 100;
			MainProgressBar.Value = BufferlyProgressBarCurrentPercent;

			System.Timers.Timer timer = new System.Timers.Timer(25);
			timer.Elapsed += (s, elapsed) =>
			{
				if (BufferlyProgressBarCurrentPercent >= BufferlyProgressBarTargetPercent)
				{
					timer.Stop();
					timer.Dispose();
					return;
				}

				BufferlyProgressBarCurrentPercent += 1;

				if (BufferlyProgressBarCurrentPercent > MainProgressBar.Maximum)
				{
					BufferlyProgressBarCurrentPercent = MainProgressBar.Maximum;
				}

				this.Invoke(
					(MethodInvoker)delegate
					{
						MainProgressBar.Value = BufferlyProgressBarCurrentPercent;
					}
				);
			};
			timer.Start();
		}

		private void PatchGameButton_Click(object sender, System.EventArgs e)
		{
			try
			{
				ProgressBarPerformAction();
				if (!File.Exists(HostsPath))
				{
					mainNotifications.Show(this, "Failed to Patch Game (E001)", position: BunifuSnackbar.Positions.TopRight, type: BunifuSnackbar.MessageTypes.Error);
					return;
				}
				string[] newEntries =
				{
					"157.90.245.67 api.homesweethomegame.com",
					"157.90.245.67 hshapi.homesweethomegame.com",
					"157.90.245.67 hshsapi.homesweethomegame.com",
					"157.90.245.67 quest-api.homesweethomegame.com"
				};

				var existingLines = File.ReadAllLines(HostsPath);
				var linesToAdd = newEntries.Where(entry => !existingLines.Contains(entry)).ToList();

				if (linesToAdd.Count == 0)
				{
					InitialiizeFiddlerCore();
					return;
				}

				File.AppendAllLines(HostsPath, linesToAdd);
				mainNotifications.Show(this, "Patched Game starting Proxy!", position: BunifuSnackbar.Positions.TopRight, type: BunifuSnackbar.MessageTypes.Success);
				InitialiizeFiddlerCore();
			}
			catch (Exception ex)
			{
				mainNotifications.Show(this, "Failed to Patch Game (E002)", position: BunifuSnackbar.Positions.TopRight, type: BunifuSnackbar.MessageTypes.Error);
				Clipboard.SetText(ex.Message);
			}
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			fiddlerService.StopCore();
			fiddlerService.ClearProxy();
			Application.Exit();
		}

		private void RestoreGameButton_Click(object sender, EventArgs e)
		{
			try
			{
				ProgressBarPerformAction();
				if (!File.Exists(HostsPath))
				{
					mainNotifications.Show(this, "Failed to Restore Game (E001)", position: BunifuSnackbar.Positions.TopRight, type: BunifuSnackbar.MessageTypes.Error);
					return;
				}

				string[] entriesToRemove =
				{
					"157.90.245.67 api.homesweethomegame.com",
					"157.90.245.67 hshapi.homesweethomegame.com",
					"157.90.245.67 hshsapi.homesweethomegame.com",
					"157.90.245.67 quest-api.homesweethomegame.com"
				};

				var existingLines = File.ReadAllLines(HostsPath);
				var linesToKeep = existingLines.Where(line => !entriesToRemove.Contains(line)).ToList();

				if (linesToKeep.Count == existingLines.Length)
				{
					mainNotifications.Show(this, "No changes needed. Game already restored.", position: BunifuSnackbar.Positions.TopRight, type: BunifuSnackbar.MessageTypes.Information);
					return;
				}

				File.WriteAllLines(HostsPath, linesToKeep);
				mainNotifications.Show(this, "Restored Game patches!", position: BunifuSnackbar.Positions.TopRight, type: BunifuSnackbar.MessageTypes.Success);
			}
			catch (Exception ex)
			{
				mainNotifications.Show(this, "Failed to Restore Game (E002)", position: BunifuSnackbar.Positions.TopRight, type: BunifuSnackbar.MessageTypes.Error);
				Clipboard.SetText(ex.Message);
			}
		}

		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			fiddlerService.StopCore();
			fiddlerService.ClearProxy();
		}

		private void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			fiddlerService.StopCore();
			fiddlerService.ClearProxy();
		}
	}
}
