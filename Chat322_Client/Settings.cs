using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Chat322_Client
{
    internal class Settings
    {
        private IPAddress _address;
        private int _outPort;
        private int _inPort;
        public Settings(string _ip, string _outPort, string _inPort)
        {
            if (!IPAddress.TryParse(_ip, out _address)) 
            { 
                _address = IPAddress.Parse("127.0.0.1"); 
            }
            if (int.TryParse(_outPort, out this._outPort))
            {
                if (this._outPort < 0 || this._outPort > 65535)
                {
                    this._outPort = 3000;
                }
            }
            else { this._outPort = 3000; }

            if (int.TryParse(_inPort, out this._inPort))
            {
                if (this._inPort < 0 || this._inPort > 65535)
                {
                    this._inPort = 3001;
                }
            }
            else { this._inPort = 3001; }
        }
        public override string ToString() 
        {
            return $"ip = {_address} outPort = {_outPort} inPort = {_inPort}";
        }
    }
}
