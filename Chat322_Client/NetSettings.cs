using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat322_Client
{
    public partial class NetSettings : Form
    {
        public NetSettings()
        {
            InitializeComponent();
            SetConfig();
        }

        //КНОПКА - ОК 
        //ПРИМЕНЕНИЕ ВВЕДЁННЫХ ПАРАМЕТРОВ К ТСР СОЕДИНЕНИЮ 
        private void btn_apply_Click(object sender, EventArgs e)
        {
            TCPClient._ipAddress = IPAddress.Parse(tbox_ipaddress.Text);
            TCPClient._inPort = Int32.Parse(tbox_inport.Text);
            TCPClient._outPort = Int32.Parse(tbox_outport.Text);
            TCPClient._idclient = Int32.Parse(tbox_idPerson.Text);
            TCPClient._activeGroup = tbox_NameGroup.Text;
            TCPClient._PersonName = tbox_NikName.Text;
            this.Close();
        }

        private void SetConfig()
        {
            tbox_ipaddress.Text = TCPClient._ipAddress.ToString();
            tbox_inport.Text = TCPClient._inPort.ToString();
            tbox_outport.Text = TCPClient._outPort.ToString();
            tbox_NameGroup.Text = TCPClient._activeGroup;
            tbox_idPerson.Text = TCPClient._idclient.ToString();
            tbox_NikName.Text = TCPClient._PersonName;
        }
    }
}
