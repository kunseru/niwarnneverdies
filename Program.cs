using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace niwarnneverdies
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			if (!IsRunningAsAdmin())
			{
				TryRunAsAdmin();
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}

		static bool IsRunningAsAdmin()
		{
			using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
			{
				WindowsPrincipal principal = new WindowsPrincipal(identity);
				return principal.IsInRole(WindowsBuiltInRole.Administrator);
			}
		}

		static void TryRunAsAdmin()
		{
			try
			{
				ProcessStartInfo proc = new ProcessStartInfo
				{
					UseShellExecute = true,
					WorkingDirectory = Environment.CurrentDirectory,
					FileName = Application.ExecutablePath,
					Verb = "runas"
				};

				Process.Start(proc);
			}
			catch
			{
				MessageBox.Show("This application requires administrative privileges.\nPlease restart as Administrator.",
					"Admin Rights Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			Application.Exit();
		}
	}
}
