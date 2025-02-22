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
        private string _Color {  get; set; }
        private string _Message { get; set; }
        private string _Font { get; set; }
        private string _TypeFont { get; set; }

        public ClientMessage() { }
        public ClientMessage( string color, string font, string typefont, string message)
        {
            _Color = color;
            _Message = message;
            _Font = font;
            _TypeFont = typefont;
                      
        }


    }
}
