using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;

namespace bluemonster.Forms
{
	public partial class MainForm : Form
	{
		#region Variables
		Process p;

		short spaces = 15;

		public string SongName
		{
			get { return TrayIcon.BalloonTipText; }
			set
			{
				TrayIcon.BalloonTipText =
					value == "" ||
					value == null ?
					"Spotify is not open" :
					value;
				SaveFile("spotifySong.txt", GenerateFileText());
			}
		}
		#endregion

		#region Constructor
		public MainForm()
		{
			InitializeComponent();

			FormClosed += FormClosedEvent;

			TrayIcon.MouseClick += TrayIconClick;

			textBox1.KeyPress += TextBoxKeyPressed;

			SongName = "Spotify Song Spy is being Initialized";

			InitializeStoragePath(Environment.SpecialFolder.CommonApplicationData);
		}
		#endregion

		#region Event Handlers
		private void TextBoxKeyPressed(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
				case '\n':
				case '\b':
				case '\r':
					break;
				default:
					e.Handled = true;
					break;
			}
		}

		private void FormClosedEvent(object sender, FormClosedEventArgs e)
		{
			TrayIcon.Visible = false;
			SongName = "Open Spotify Song Spy";
		}

		private void TrayIconClick(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
				case MouseButtons.Left:
					TrayIcon.ShowBalloonTip(10);
					break;
			}
		}

		private void SpotifyExited(object sender, EventArgs e)
		{
			p = null;
			if (MessageBox.Show("Would you like to close Spotify Song Getter?", "Spotify Closed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{ this.Close(); return; }
			if (!Ticker.Enabled) Ticker.Start();
		}

		private void TickerTick(object sender, EventArgs e)
		{
			CheckProcessInfo();
		}

		private void TrayIconMenuClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnBegin_Click(object sender, EventArgs e)
		{
			this.Hide();
			short.TryParse(textBox1.Text, out spaces);
			if (Ticker.Enabled)
				SaveFile("spotifySong.txt", GenerateFileText());
			else
			{
				CheckProcessInfo();
				Ticker.Start();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TrayIconMenuOpen_Click(object sender, EventArgs e)
		{
			this.Show();
		}
		#endregion

		#region My Methods
		private void CheckProcessInfo()
		{
			p = Process.GetProcessesByName("Spotify").FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));
			switch (p)
			{
				case null:
					if (SongName != "Spotify is not open")
						SongName = null;
					break;
				default:
					switch (p.MainWindowTitle)
					{
						case "Spotify":
							if (SongName != "Paused")
								SongName = "Paused";
							break;
						default:
							if (SongName != p.MainWindowTitle)
								SongName = p.MainWindowTitle;
							break;
					}
					break;
			}
		}

		private string GenerateFileText()
		{
			string str = "";
			switch (SongName)
			{
				case "Paused":
					str += "Spotify is Paused";
					break;
				case "Find Out More":
					str += "Ads are playing";
					break;
				case "Spotify is not open":
				case "Open Spotify Song Spy":
				case "Spotify Song Spy is being Initialized":
					str += SongName;
					break;
				default:
					str += $"Current Song : {SongName}";
					break;
			}
			for (int i = 0; i < spaces; i++)
				str += ' ';
			return str;
		} 
		#endregion

		#region Sharidan's Snippets

		private string mvarStoragePath = "";
		private string mvarApplicationFolder = "Spotify Song Spy";

		private void InitializeStoragePath()
		{
			InitializeStoragePath(Environment.SpecialFolder.CommonApplicationData);
		}

		private void InitializeStoragePath(Environment.SpecialFolder specialFolder)
		{
			string Path = FixPath(Environment.GetFolderPath(specialFolder));
			Path = FixPath(Path + mvarApplicationFolder);
			if (!Directory.Exists(Path))
				try
				{
					Directory.CreateDirectory(Path);
				}
				catch { }
			mvarStoragePath = Path;
		}

		private string FixPath(string Path)
		{
			if (Path[Path.Length - 1] != '\\')
				return Path + "\\";
			return Path;
		}

		private void SaveFile(string FileName, string TextToSave)
		{
			if (mvarStoragePath.Length > 0)
			{
				if (!Directory.Exists(mvarStoragePath))
					if (!Directory.Exists(mvarStoragePath))
						try
						{
							Directory.CreateDirectory(mvarStoragePath);
						}
						catch { }
				if (File.Exists(mvarStoragePath + FileName))
					try
					{
						File.Delete(mvarStoragePath + FileName);
					}
					catch { }
				if (!File.Exists(mvarStoragePath + FileName))
					try
					{
						File.WriteAllText(mvarStoragePath + FileName, TextToSave);
					}
					catch { }
			}
		} 
		#endregion
	}
}