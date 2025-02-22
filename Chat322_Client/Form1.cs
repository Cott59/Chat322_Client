using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat322_Client
{
    public partial class Form1 : Form
    {
        private Settings settings;
        public static string mess;
        public static string message;
        

        public Form1()
        {
            InitializeComponent();
            TCPClient client = new TCPClient();
            client.StartClient();
            lb_activeGroup.Text = TCPClient._activeGroup;
            SetMessage();
            
            //Authorization.newAuthorization();
            //tbIniFile.Text = getParams("Cfg.ini");
            //tbIniFile.Text += mess;
            //TCPClient.SetConfig();
            

        }
        private string getParams(string _path)
        {
            string result = string.Empty;
            var _lst = FSWork.ReadIniFile
                (new List<string>() { "ip", "outPort", "inPort" }, _path);
            Settings settings = new Settings(_lst[0], _lst[1], _lst[2]);
            this.settings = settings;
            result = settings.ToString();
            return result;
        }

        public void SetMessage()
        {
            Task task = new Task(() =>
            {
                
                while (true)
                {
                    TCPClient tcp = new TCPClient();
                    string str = tcp.MyReceiveMessages();
                    tbox_groupMessages.Text += $"{str}\r\n";
                }
            });
            task.Start();

        }

        public void settextalignRight() { tbox_groupMessages.TextAlign = HorizontalAlignment.Right; }
        public void settextalignLeft() { tbox_groupMessages.TextAlign = HorizontalAlignment.Left; }


        //КНОПКА "ОТПРАВИТЬ" СООБЩЕНИЕ
        private void btn_GetMessage_Click(object sender, EventArgs e)
        {
            TCPClient tcp = new TCPClient();
            tcp.mysendmes(tbox_outMessege.Text);
            tbox_outMessege.Text = string.Empty;

            
        }


     





        

        /// <summary>
        /// НАСТРОЙКА ОТПРАВЛЯЕМОГО ТЕКСТА 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TextSetting_Click(object sender, EventArgs e)
        {
            TextSettings textSettings = new TextSettings();
            textSettings.ShowDialog();
        }
        //ЗАКРЫТИЕ СОЕДИНЕНИЯ ПРИ ЗАКРЫТИИ ФОРМЫ(ОКНА)
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TCPClient.stream.Close();
            TCPClient.myclient.Close();
        }
        private void NetSettings_Click(object sender, EventArgs e)
        {
            NetSettings ns = new NetSettings();
            ns.ShowDialog();
        }
    }
}
