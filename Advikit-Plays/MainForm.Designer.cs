
namespace Advikit_Plays {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.chatTab = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.consoleLog = new System.Windows.Forms.RichTextBox();
			this.chatConnectionButton = new System.Windows.Forms.Button();
			this.gamesTab = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gameConsole = new System.Windows.Forms.RichTextBox();
			this.activateGameButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.gamesList = new System.Windows.Forms.ComboBox();
			this.settingsTab = new System.Windows.Forms.TabPage();
			this.channelId = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.clientIdVisible = new System.Windows.Forms.Button();
			this.clientId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.chatTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gamesTab.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.settingsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.channelId)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.chatTab);
			this.tabControl1.Controls.Add(this.gamesTab);
			this.tabControl1.Controls.Add(this.settingsTab);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(730, 237);
			this.tabControl1.TabIndex = 0;
			// 
			// chatTab
			// 
			this.chatTab.Controls.Add(this.groupBox1);
			this.chatTab.Controls.Add(this.chatConnectionButton);
			this.chatTab.Location = new System.Drawing.Point(4, 22);
			this.chatTab.Name = "chatTab";
			this.chatTab.Padding = new System.Windows.Forms.Padding(3);
			this.chatTab.Size = new System.Drawing.Size(722, 211);
			this.chatTab.TabIndex = 0;
			this.chatTab.Text = "Chat";
			this.chatTab.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.consoleLog);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 47);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(716, 161);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Console Log";
			// 
			// consoleLog
			// 
			this.consoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.consoleLog.Location = new System.Drawing.Point(3, 16);
			this.consoleLog.Name = "consoleLog";
			this.consoleLog.ReadOnly = true;
			this.consoleLog.Size = new System.Drawing.Size(710, 142);
			this.consoleLog.TabIndex = 0;
			this.consoleLog.Text = "";
			// 
			// chatConnectionButton
			// 
			this.chatConnectionButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.chatConnectionButton.Location = new System.Drawing.Point(3, 3);
			this.chatConnectionButton.Name = "chatConnectionButton";
			this.chatConnectionButton.Size = new System.Drawing.Size(716, 44);
			this.chatConnectionButton.TabIndex = 0;
			this.chatConnectionButton.Text = "Connect to Chat";
			this.chatConnectionButton.UseVisualStyleBackColor = true;
			this.chatConnectionButton.Click += new System.EventHandler(this.chatConnectionButton_Click);
			// 
			// gamesTab
			// 
			this.gamesTab.Controls.Add(this.groupBox2);
			this.gamesTab.Controls.Add(this.activateGameButton);
			this.gamesTab.Controls.Add(this.label3);
			this.gamesTab.Controls.Add(this.gamesList);
			this.gamesTab.Location = new System.Drawing.Point(4, 22);
			this.gamesTab.Name = "gamesTab";
			this.gamesTab.Padding = new System.Windows.Forms.Padding(3);
			this.gamesTab.Size = new System.Drawing.Size(722, 211);
			this.gamesTab.TabIndex = 1;
			this.gamesTab.Text = "Games";
			this.gamesTab.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.gameConsole);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox2.Location = new System.Drawing.Point(3, 33);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(716, 175);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Game Log";
			// 
			// gameConsole
			// 
			this.gameConsole.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gameConsole.Location = new System.Drawing.Point(3, 16);
			this.gameConsole.Name = "gameConsole";
			this.gameConsole.Size = new System.Drawing.Size(710, 156);
			this.gameConsole.TabIndex = 0;
			this.gameConsole.Text = "";
			// 
			// activateGameButton
			// 
			this.activateGameButton.Location = new System.Drawing.Point(477, 4);
			this.activateGameButton.Name = "activateGameButton";
			this.activateGameButton.Size = new System.Drawing.Size(237, 23);
			this.activateGameButton.TabIndex = 2;
			this.activateGameButton.Text = "Activate";
			this.activateGameButton.UseVisualStyleBackColor = true;
			this.activateGameButton.Click += new System.EventHandler(this.activateGameButton_Click_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Game:";
			// 
			// gamesList
			// 
			this.gamesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.gamesList.FormattingEnabled = true;
			this.gamesList.Location = new System.Drawing.Point(52, 6);
			this.gamesList.Name = "gamesList";
			this.gamesList.Size = new System.Drawing.Size(419, 21);
			this.gamesList.TabIndex = 0;
			// 
			// settingsTab
			// 
			this.settingsTab.Controls.Add(this.channelId);
			this.settingsTab.Controls.Add(this.label2);
			this.settingsTab.Controls.Add(this.clientIdVisible);
			this.settingsTab.Controls.Add(this.clientId);
			this.settingsTab.Controls.Add(this.label1);
			this.settingsTab.Location = new System.Drawing.Point(4, 22);
			this.settingsTab.Name = "settingsTab";
			this.settingsTab.Size = new System.Drawing.Size(722, 211);
			this.settingsTab.TabIndex = 2;
			this.settingsTab.Text = "Settings";
			this.settingsTab.UseVisualStyleBackColor = true;
			// 
			// channelId
			// 
			this.channelId.Location = new System.Drawing.Point(76, 29);
			this.channelId.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.channelId.Name = "channelId";
			this.channelId.Size = new System.Drawing.Size(120, 20);
			this.channelId.TabIndex = 4;
			this.channelId.ValueChanged += new System.EventHandler(this.channelId_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Channel ID:";
			// 
			// clientIdVisible
			// 
			this.clientIdVisible.Location = new System.Drawing.Point(574, 4);
			this.clientIdVisible.Name = "clientIdVisible";
			this.clientIdVisible.Size = new System.Drawing.Size(140, 23);
			this.clientIdVisible.TabIndex = 2;
			this.clientIdVisible.Text = "Show/Hide";
			this.clientIdVisible.UseVisualStyleBackColor = true;
			this.clientIdVisible.Click += new System.EventHandler(this.clientIdVisible_Click);
			// 
			// clientId
			// 
			this.clientId.Location = new System.Drawing.Point(76, 6);
			this.clientId.Name = "clientId";
			this.clientId.Size = new System.Drawing.Size(492, 20);
			this.clientId.TabIndex = 1;
			this.clientId.UseSystemPasswordChar = true;
			this.clientId.TextChanged += new System.EventHandler(this.clientId_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Client ID:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 237);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Advikit Plays";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.chatTab.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.gamesTab.ResumeLayout(false);
			this.gamesTab.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.settingsTab.ResumeLayout(false);
			this.settingsTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.channelId)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage chatTab;
		private System.Windows.Forms.TabPage gamesTab;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox consoleLog;
		private System.Windows.Forms.Button chatConnectionButton;
		private System.Windows.Forms.TabPage settingsTab;
		private System.Windows.Forms.Button clientIdVisible;
		private System.Windows.Forms.TextBox clientId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown channelId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button activateGameButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox gamesList;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.RichTextBox gameConsole;
	}
}

