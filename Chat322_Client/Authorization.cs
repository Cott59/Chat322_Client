using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat322_Client
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private string index = "avt";

        private void RegNewPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        //public static void newAuthorization()
        //{
        //    Authorization authorization = new Authorization();
        //    authorization.ShowDialog();
        //}

        private void btn_Entrance_Click(object sender, EventArgs e)
        {
            string str = $"{index}-{tbox_Nickname.Text}-{tbox_Password.Text}";
            TCPClient tCPClient = new TCPClient();
            tCPClient.sendmesavtorization(str);
            if (TCPClient._PersonName != "")
            {
                Close();
            }

        }
    }
}
