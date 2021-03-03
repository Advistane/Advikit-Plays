using Advikit_Plays.Glimesh;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Advikit_Plays {
	public partial class MainForm : Form {
		private ChatWebsocket cws;
		private Dictionary<string, Type> availableGames = new Dictionary<string, Type>();
		dynamic game;
		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			clientId.Text = Properties.Settings.Default.client_id;
			channelId.Value = Properties.Settings.Default.channel_id;

			var types = from t in Assembly.GetExecutingAssembly().GetTypes()
						   where t.IsClass && t.Namespace == "Advikit_Plays.Games"
						   select t;

			foreach (Type t in types) {
				if (t.Namespace == "Advikit_Plays.Games") {
					availableGames[t.Name] = t;
					gamesList.Items.Add(t.Name);
				}
			}
		}

		private async void chatConnectionButton_Click(object sender, EventArgs e) {
			if (String.IsNullOrEmpty(Properties.Settings.Default.client_id)) {
				MessageBox.Show("Please set your client ID in the settings tab");
				return;
			}
			cws = new ChatWebsocket();
			cws.NewMessage += LogResponse;
			await cws.Connect();
			if (cws.GetStatus()) {
				chatConnectionButton.Text = "Connected";
			} else {
				chatConnectionButton.Text = "Error connecting";
			}
		}

		private void clientIdVisible_Click(object sender, EventArgs e) {
			clientId.UseSystemPasswordChar = !clientId.UseSystemPasswordChar;
		}

		private void clientId_TextChanged(object sender, EventArgs e) {
			Properties.Settings.Default.client_id = clientId.Text;
			Properties.Settings.Default.Save();
		}

		void LogResponse(object sender, SocketResponse ex) {
			Log(ex.Payload.ToString());
		}

		private void Log(string toLog) {
			consoleLog.Invoke((MethodInvoker)delegate () {
				consoleLog.AppendText("----------------" + DateTime.Now.ToString("h:mm:ss tt") + "---------------" + Environment.NewLine + toLog + Environment.NewLine);
				consoleLog.SelectionStart = consoleLog.Text.Length;
				consoleLog.ScrollToCaret();
			});
		}

		private void channelId_ValueChanged(object sender, EventArgs e) {
			Properties.Settings.Default.channel_id = (int)channelId.Value;
			Properties.Settings.Default.Save();
		}

		private void activateGameButton_Click(object sender, EventArgs e) {

		}

		private void activateGameButton_Click_1(object sender, EventArgs e) {
			Console.WriteLine(gamesList.SelectedItem.ToString());
			try {
				this.game = Activator.CreateInstance(availableGames[gamesList.SelectedItem.ToString()], this.cws, this);
			} catch (Exception gg) {
				MessageBox.Show("Error starting game module");
				Console.WriteLine(gg.Message);
			}
		}

	}
}
