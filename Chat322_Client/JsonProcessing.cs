using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Chat322_Client
{
    internal class JsonProcessing
    {
        public static void DeserilisJsonFile(string str)
        {
            if (str == null) { }
            var str1 = JsonConvert.DeserializeObject<Chat>(str);
            

        }







        public class Chat
        {
            [JsonProperty("messages")]
            public List<Message> messages { get; set; } = new List<Message>();
        }

        public class Message
        {
            [JsonProperty("id")]
            public int _Id { get; set; }

            [JsonProperty("name")]
            public string _Name { get; set; }

            [JsonProperty("message")]
            public string _Message { get; set; }
        }





    }








}
