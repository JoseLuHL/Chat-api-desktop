using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_api_desktop
{
    class Respuesta
    {
        public bool sent { get; set; }
        public string message { get; set; }
        public string id { get; set; }
        public string queueNumber { get; set; }

}
    public partial class Answer
    {
        [JsonProperty("instanceId")]
        public string InstanceId { get; set; }

        [JsonProperty("messages")]
        public List<Message> Messages { get; set; }
    }


    public partial class Message
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("senderName")]
        public string SenderName { get; set; }

        [JsonProperty("fromMe")]
        public bool FromMe { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("chatId")]
        public string ChatId { get; set; }

        [JsonProperty("messageNumber")]
        public long MessageNumber { get; set; }
    }
}
