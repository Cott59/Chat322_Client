using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat322_Client
{
    [Serializable]
    partial class ClientMessage
    {
        
        public string[] _Message { get; set; }
        public string _Font { get; set; }
        public string _Name { get; set; }
        public int _IdClient {  get; set; }

        public ClientMessage() { }
        public ClientMessage(string[] message, int id, string name, string font = "Arial")
        {
            _Message = message;
            _IdClient = id;
            _Name = name;
            _Font = font;
        }
    }
}
