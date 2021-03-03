using Advikit_Plays.Glimesh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Advikit_Plays.Games {
	class Peggle : Controller.Controller {
		private ChatWebsocket cws;
		Dictionary<string, Action> chatCommands;
		private MainForm form;

		public Peggle(ChatWebsocket cws, MainForm form) {
			this.cws = cws;
			this.form = form;
			if (FindTarget("popcapgame1")) { //Process name or window title
				chatCommands = new Dictionary<string, Action>
				{
					{ "left", () => MoveLeft() }, // Add chat command "left" to call the MoveLeft() function defined below
					{ "light left", () => MoveLittleLeft() },

					{ "right", () => MoveRight() },
					{ "light right", () => MoveLittleRight() },

					{ "up", () => MoveUp() },
					{ "down", () => MoveDown() },

					{ "shoot", () => Shoot() }
				};

				this.cws = cws;
				log("Loaded commands: " + String.Join(", ", chatCommands.Keys.ToArray()));
				log("Chat commands are active.");
				this.cws.NewMessage += HandleMessage;
			}
		}

		public void MoveLittleLeft() {
			MoveMouse(-10, 0, true);
		}

		public void MoveLeft() {
			MoveMouse(-50, 0, true);
		}

		public void MoveLittleRight() {
			MoveMouse(10, 0, true);
		}

		public void MoveRight() {
			MoveMouse(50, 0, true);
		}

		public void Shoot() {
			LeftClick();
		}

		public void MoveUp() {
			MoveMouse(0, 30, true);
		}

		public void MoveDown() {
			MoveMouse(0, -30, true);
		}

		public void HandleMessage(object sender, SocketResponse ex) {
			if (ex.isChatMessage && chatCommands.ContainsKey(ex.messageText.ToLower())) {
				chatCommands[ex.messageText.ToLower()].Invoke();
			}
		}

		protected void log(string msg) {
			form.Invoke((MethodInvoker)delegate () {
				form.gameConsole.AppendText("----------------" + DateTime.Now.ToString("h:mm:ss tt") + "---------------" + Environment.NewLine + msg + Environment.NewLine);
				form.gameConsole.SelectionStart = form.gameConsole.Text.Length;
				form.gameConsole.ScrollToCaret();
			});
		}
	}
}
