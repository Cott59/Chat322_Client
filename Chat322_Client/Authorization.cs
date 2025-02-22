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

        private void RegNewPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        public static void newAuthorization()
        {
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
        }
    }
}
