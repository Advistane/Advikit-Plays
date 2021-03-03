using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Websocket.Client;

namespace Advikit_Plays.Glimesh {
	class ChatWebsocket {
		public event EventHandler<SocketResponse> NewMessage;
		private WebsocketClient ws;
		private CancellationToken cancelHeartbeat;

		public async Task Connect() {
			var url = new Uri("wss://glimesh.tv/api/socket/websocket?vsn=2.0.0&client_id=" + Properties.Settings.Default.client_id);
			this.ws = new WebsocketClient(url);
			this.ws.DisconnectionHappened.Subscribe(msg =>
			{
				OnDisconnect(msg);

			});
			this.ws.MessageReceived.Subscribe(msg => {
				OnChatMessage(msg);
			});
			await this.ws.Start();
			this.ws.Send("[\"1\", \"1\", \"__absinthe__:control\", \"phx_join\", {}]");
			this.ws.Send("[\"1\", \"1\", \"__absinthe__:control\", \"doc\", { \"query\": \"subscription{ chatMessage(channelId: " + Properties.Settings.Default.channel_id.ToString() + ") { user { username avatar } message } }\", \"variables\": {}}]");
			this.cancelHeartbeat = new CancellationToken();
			Heartbeat();

		}

		public async Task Heartbeat() {
			while (true) {
				await this.ws.SendInstant("[\"1\", \"1\", \"phoenix\", \"heartbeat\", {}]");
				await Task.Delay(30000, this.cancelHeartbeat);
			}
		}

		public bool GetStatus() {
			return this.ws.IsRunning;
		}

		protected virtual void OnChatMessage(ResponseMessage rm) {
			dynamic parsed = JsonConvert.DeserializeObject(rm.Text);
			Console.WriteLine(rm);

			SocketResponse cm = new SocketResponse(parsed);
			this.NewMessage?.Invoke(this, cm);
		}

		private void OnDisconnect(DisconnectionInfo info) {
			Console.WriteLine(info.Exception);
		}
	}
}
