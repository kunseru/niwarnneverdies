using Fiddler;
using Microsoft.Win32;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace niwarnneverdies
{
	public class FiddlerService
	{

		private readonly string assemblyDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

		public void EnsureRootCertificate()
		{
			try
			{
				BCCertMaker.BCCertMaker certProvider = new BCCertMaker.BCCertMaker();
				CertMaker.oCertProvider = certProvider;

				string rootCertificatePath = Path.Combine(assemblyDirectory, "..", "..", "RootCertificate.p12");
				string rootCertificatePassword = "S0m3T0pS3cr3tP4ssw0rd";
				if (!File.Exists(rootCertificatePath))
				{
					certProvider.CreateRootCertificate();
					certProvider.WriteRootCertificateAndPrivateKeyToPkcs12File(rootCertificatePath, rootCertificatePassword);
				}
				else
				{
					certProvider.ReadRootCertificateAndPrivateKeyFromPkcs12File(rootCertificatePath, rootCertificatePassword);
				}

				if (!CertMaker.rootCertIsTrusted())
				{
					CertMaker.trustRootCert();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Unlocker Error: EnsureRootCertificate", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public bool IsRunning()
		{
			return FiddlerApplication.IsStarted();
		}

		public void StartupFiddlerCore()
		{
			FiddlerCoreStartupSettings startupSettings =
				new FiddlerCoreStartupSettingsBuilder()
					.RegisterAsSystemProxy()
					.DecryptSSL()
					.MonitorAllConnections()
					.Build();

			FiddlerApplication.BeforeRequest += (session) =>
			{
				if (session.oRequest["User-Agent"].Contains("HSHO") || session.hostname.Contains("homesweethome"))
				{
					session.bypassGateway = false;
				}
				else
				{
					session.bypassGateway = true;
				}
			};

			FiddlerApplication.OnValidateServerCertificate += (sender, ea) =>
			{
				if (ea.Session.hostname.Contains("homesweethome"))
				{
					if (ea.CertificatePolicyErrors != System.Net.Security.SslPolicyErrors.None)
					{
						ea.ValidityState = CertificateValidity.ForceValid;
					}
				}
			};

			FiddlerApplication.Startup(startupSettings);
		}

		public void StopCore()
		{
			ClearProxy();

			if (FiddlerApplication.IsStarted())
			{
				FiddlerApplication.Shutdown();
			}
		}

		public void ClearProxy()
		{
			const string userRoot = "HKEY_CURRENT_USER";
			const string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
			const string keyName = userRoot + "\\" + subkey;

			int proxyEnable = (int)Registry.GetValue(keyName, "ProxyEnable", 0);

			if (proxyEnable == 1)
			{
				Registry.SetValue(keyName, "ProxyEnable", 0, RegistryValueKind.DWord);
			}
		}
	}
}
