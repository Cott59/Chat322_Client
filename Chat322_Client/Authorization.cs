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

       

        private void btn_Entrance_Click(object sender, EventArgs e)
        {
            string str = $"{index}-{tbox_Nickname.Text}-{tbox_Password.Text}";
            string df = TCPClient.AuthorizationClient(str);
            if (df == "avt-Проверьте верность введённых данных или зарегистрируйтесь!")
            {
                MessageBox.Show(df, "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                string[] data = TCPClient.getCldataFromMes(df);
                TCPClient._idclient = Int32.Parse(data[1]);
                TCPClient._PersonName = data[2];
                this.Close();
            }


        }
    }
}
