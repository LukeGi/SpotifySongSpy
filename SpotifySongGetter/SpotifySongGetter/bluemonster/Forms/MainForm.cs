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
				OnSongChanged();
			}
		}

		public event EventHandler SongChanged;

		protected void OnSongChanged()
		{
			OnSongChanged(new EventArgs());
		}

		protected void OnSongChanged(EventArgs e)
		{
			SongChanged?.Invoke(this, e);
		}

		public MainForm()
		{
			InitializeComponent();

			SongChanged += EventSongChanged;
			FormClosed += FormClosedEvent;

			TrayIcon.MouseClick += TrayIconClick;

			textBox1.KeyPress += TextBoxKeyPressed;

			SongName = null;
		}

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
			SongName = "Open Spotify Song Spy";
		}

		private void EventSongChanged(object sender, EventArgs e)
		{
			SaveSong();
		}

		private void SaveSong()
		{
			string FileName = Environment.CurrentDirectory + @"\spotifySong.txt";
			FileInfo FI = new FileInfo(FileName);
			string toWrite = "";
			switch (SongName)
			{
				case "Paused":
					toWrite += "Spotify is Paused";
					break;
				case "Spotify is not open":
				case "Open Spotify Song Spy":
					toWrite += SongName;
					break;
				default:
					toWrite += $"Current Song : {SongName}";
					break;
			}
			for (int i = 0; i < spaces; i++)
				toWrite += ' ';
			try
			{
				if (FI.IsReadOnly)
					FI.IsReadOnly = false;
				using (StreamWriter stream = FI.CreateText())
				{
					stream.Write(toWrite);
					stream.Close();
				}
				FI.IsReadOnly = true;
			}
			catch (Exception E)
			{
				MessageBox.Show(E.Message, "Error");
				MessageBox.Show(E.StackTrace, "Stack Trace");
			}
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

		private void TrayIconMenuClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnBegin_Click(object sender, EventArgs e)
		{
			this.Hide();
			short.TryParse(textBox1.Text, out spaces);
			if (Ticker.Enabled)
				SaveSong();
			else
				Ticker.Start();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TrayIconMenuOpen_Click(object sender, EventArgs e)
		{
			this.Show();
		}
	}
}