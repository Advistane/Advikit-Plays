using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advikit_Plays.Glimesh {
	class SocketResponse {
		public JValue JoinRef { get; set; }
		public JValue NormRef { get; set; }
		public JValue Topic { get; set; }
		public JValue Event { get; set; }
		public JObject Payload { get; set; }

		public bool isChatMessage;
		public string messageText;
		public string author;
		public SocketResponse(dynamic json) {
			this.JoinRef = json[0];
			this.NormRef = json[1];
			this.Topic = json[2];
			this.Event = json[3];
			this.Payload = json[4];

			if (Payload["result"] != null) {
				var chatMessage = Payload["result"]["data"]["chatMessage"];
				var messageText = chatMessage["message"].ToString();
				var author = chatMessage["user"]["username"].ToString();
				this.isChatMessage = true;
				this.messageText = messageText;
				this.author = author;
			}
		}
	}
}
