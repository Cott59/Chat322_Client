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
            settingdgv();

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
                    string[] strs= TCPClient.getCldataFromMes(str);
                    //string str = tcp.MyReceiveMessagesJson();
                    //tbox_groupMessages.Text += $"{str}\r\n";
                    //tbox_groupMessages.Text += $"{strs[3]}\r\n";
                    //tbox_groupMessages.Text += $"{strs[0]}\r\n";
                    string[] strmess = getmes(strs[0]);
                    int id = TCPClient.getClIdFromMes(strs[2]);
                    ClientMessage clientMessage = new ClientMessage(strmess, id, strs[3]);
                    InputMessage(clientMessage);
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
        //===================================================================================================
        //настройка datagridview
        public void settingdgv()
        {
            dgv_groupMessages.RowHeadersVisible = false;
            dgv_groupMessages.MultiSelect = true;
            var column1 = new DataGridViewColumn();
            column1.Width = 100;
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.CellTemplate = new DataGridViewTextBoxCell();
            column1.Name = "другие";
            column1.ReadOnly = false;
            column1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            var column2 = new DataGridViewColumn();
            column2.Width = 100;
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.CellTemplate = new DataGridViewTextBoxCell();
            column2.Name = "мои";
            column2.ReadOnly = false;
            column2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            dgv_groupMessages.Columns.Add(column1);
            dgv_groupMessages.Columns.Add(column2);

            dgv_groupMessages.AllowUserToAddRows = false;
            dgv_groupMessages.DefaultCellStyle.SelectionBackColor = dgv_groupMessages.DefaultCellStyle.BackColor;
            dgv_groupMessages.DefaultCellStyle.SelectionForeColor = dgv_groupMessages.DefaultCellStyle.ForeColor;
            dgv_groupMessages.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//Разрешить перенос строк в ячейках
            dgv_groupMessages.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//Автонастройка высоты строк

        }

        public static DataGridViewRow row = new DataGridViewRow();
        public static bool check = true;

        public string[] getmes(string message)
        {
            string[] strmess = message.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return strmess;
        }



        private void InputMessage(ClientMessage clientMessage)
        {
            string name = TCPClient._PersonName;
            string d = tbox_outMessege.Text;


            if (clientMessage._IdClient == TCPClient._idclient)//ms.Num==2
            {
                dgv_groupMessages.Rows.Add();
                dgv_groupMessages.Columns[1].DefaultCellStyle.Font = new Font(clientMessage._Font, 5);

                dgv_groupMessages["другие", dgv_groupMessages.Rows.Count - 1].Value = "";//
                dgv_groupMessages["мои", dgv_groupMessages.Rows.Count - 1].Value = clientMessage._Name;//

                //string[] strmess = getmes(ms.Message);
                for (int i = 0; i < clientMessage._Message.Length; i++)
                {
                    dgv_groupMessages.Rows.Add();
                    dgv_groupMessages.Columns[1].DefaultCellStyle.Font = new Font(clientMessage._Font, 10);
                    dgv_groupMessages.RowTemplate.Height = 30;

                    dgv_groupMessages["другие", dgv_groupMessages.Rows.Count - 1].Value = "";
                    dgv_groupMessages["мои", dgv_groupMessages.Rows.Count - 1].Value = clientMessage._Message[i];
                }
            }
            else
            {
                dgv_groupMessages.Rows.Add();
                dgv_groupMessages.Columns[0].DefaultCellStyle.Font = new Font(clientMessage._Font, 5);

                dgv_groupMessages["другие", dgv_groupMessages.Rows.Count - 1].Value = clientMessage._Name;
                dgv_groupMessages["мои", dgv_groupMessages.Rows.Count - 1].Value = "";

                //string[] strmess = getmes(ms.Message);
                for (int i = 0; i < clientMessage._Message.Length; i++)
                {
                    dgv_groupMessages.Rows.Add();
                    dgv_groupMessages.Columns[0].DefaultCellStyle.Font = new Font(clientMessage._Font, 10);
                    dgv_groupMessages.RowTemplate.Height = 30;

                    dgv_groupMessages["другие", dgv_groupMessages.Rows.Count - 1].Value = clientMessage._Message[i];
                    dgv_groupMessages["мои", dgv_groupMessages.Rows.Count - 1].Value = "";
                }

            }

            if (dgv_groupMessages.Rows.Count > 0)//перемотка скролбара вниз
            {
                dgv_groupMessages.FirstDisplayedScrollingRowIndex = dgv_groupMessages.Rows.Count - 1;
            }

        }




























    }
}
