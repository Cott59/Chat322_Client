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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            string regstr = $"reg-{tbox_Nickname_reg.Text}-{tbox_Password_reg.Text}";
            bool checkReg = TCPClient.RegistrationClient(regstr);
            if (checkReg==true)
            {
                MessageBox.Show("Вы зарегистрированы!!!", "Регистрация", MessageBoxButtons.OK);
                this.Close();
            }
            
        }
    }
}
