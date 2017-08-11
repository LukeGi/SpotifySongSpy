namespace bluemonster.Forms
{
	partial class OpeningForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpeningForm));
			this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.TrayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TrayIconMenuClose = new System.Windows.Forms.ToolStripMenuItem();
			this.Ticker = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBegin = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.TrayIconMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.TrayIconMenu.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TrayIcon
			// 
			this.TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.TrayIcon.BalloonTipTitle = "Spotify Song Spy";
			this.TrayIcon.ContextMenuStrip = this.TrayIconMenu;
			this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
			this.TrayIcon.Text = "Spotify Song Spy";
			this.TrayIcon.Visible = true;
			// 
			// TrayIconMenu
			// 
			this.TrayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayIconMenuClose,
            this.TrayIconMenuOpen});
			this.TrayIconMenu.Name = "TrayIconMenu";
			this.TrayIconMenu.Size = new System.Drawing.Size(218, 48);
			this.TrayIconMenu.Text = "Options";
			// 
			// TrayIconMenuClose
			// 
			this.TrayIconMenuClose.CheckOnClick = true;
			this.TrayIconMenuClose.Name = "TrayIconMenuClose";
			this.TrayIconMenuClose.Size = new System.Drawing.Size(217, 22);
			this.TrayIconMenuClose.Text = "Close";
			this.TrayIconMenuClose.Click += new System.EventHandler(this.TrayIconMenuClose_Click);
			// 
			// Ticker
			// 
			this.Ticker.Tick += new System.EventHandler(this.TickerTick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.tableLayoutPanel1.SetColumnSpan(this.label1, 6);
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(584, 60);
			this.label1.TabIndex = 1;
			this.label1.Text = "Spotify Song Spy";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 2);
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.DodgerBlue;
			this.textBox1.Location = new System.Drawing.Point(388, 75);
			this.textBox1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.textBox1.MaxLength = 3;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(196, 62);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "10";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnBegin, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnClose, 3, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 361);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel1.SetColumnSpan(this.label2, 4);
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 75);
			this.label2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(388, 62);
			this.label2.TabIndex = 3;
			this.label2.Text = "Enter Number of Spaces:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnBegin
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.btnBegin, 3);
			this.btnBegin.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBegin.Location = new System.Drawing.Point(3, 308);
			this.btnBegin.Name = "btnBegin";
			this.btnBegin.Size = new System.Drawing.Size(285, 50);
			this.btnBegin.TabIndex = 4;
			this.btnBegin.Text = "Run";
			this.btnBegin.UseVisualStyleBackColor = true;
			this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
			// 
			// btnClose
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.btnClose, 3);
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(294, 308);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(287, 50);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Exit";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// TrayIconMenuOpen
			// 
			this.TrayIconMenuOpen.Name = "TrayIconMenuOpen";
			this.TrayIconMenuOpen.Size = new System.Drawing.Size(217, 22);
			this.TrayIconMenuOpen.Text = "Change Number Of Spaces";
			this.TrayIconMenuOpen.Click += new System.EventHandler(this.TrayIconMenuOpen_Click);
			// 
			// OpeningForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "OpeningForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Spotify Song Spy";
			this.TrayIconMenu.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon TrayIcon;
		private System.Windows.Forms.Timer Ticker;
		private System.Windows.Forms.ContextMenuStrip TrayIconMenu;
		private System.Windows.Forms.ToolStripMenuItem TrayIconMenuClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBegin;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ToolStripMenuItem TrayIconMenuOpen;
	}
}

