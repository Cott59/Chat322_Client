using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat322_Client
{
    partial class TCPClient
    {        
        // ip сервера
        public static IPAddress _ipAddress;
        // _outPort - порт сервера
        public static int _outPort = 3000;
        // _inPort - порт клиента
        public static int _inPort;
        //public static Socket _socket;
        
        public static string ip = "127.0.0.1";
        public static string _activeGroup = "234";
        public static int _idclient = 7;
        public static string _PersonName = "Nico";

        public static TcpClient myclient = null;
        public static NetworkStream stream {  get; private set; }
        public Thread sendThread {  get; private set; }
        public Thread receiveThread {  get; private set; }
        public TCPClient() { }

        //УСТАНОВКА ip АДРЕСА И ПОРТОВ ИЗ ФАЙЛА ПРИ ЗАПУСКЕ
        public void SetConfig()
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfo = directoryInfo.GetFiles();
            List<string> srtfile = new List<string>();
            foreach (FileInfo finfo in fileInfo)
            {
                if(finfo.Name == "Cfg.ini")
                {
                    srtfile.AddRange(File.ReadAllLines(finfo.FullName));
                }
            }
            _ipAddress = IPAddress.Parse(srtfile[0]);
            _outPort = int.Parse(srtfile[1]);
            _inPort = int.Parse(srtfile[2]);

        }

        public void StartClient()
        {
            try
            {
                SetConfig();
                myclient = new TcpClient(ip, _outPort);//TcpClient client = new TcpClient(ip, _outPort);
                stream = myclient.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }


        /// <summary>
        /// ОТПРАВКА СООБЩЕНИЯ
        /// </summary>
        /// <param name="ms"></param>
        public void mysendmes(string ms)
        {
            Task task = new Task(() => {
                byte[] data = Encoding.UTF8.GetBytes($"{ms} /{_activeGroup}-{_idclient}-{_PersonName}");
                stream.Write(data, 0, data.Length);
            });
            task.Start();
        }


        /// <summary>
        /// получение данных
        /// </summary>
        /// <param name="stream"></param>
        public string MyReceiveMessages()
        {

            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string response= "Ничего не пришло";
            bool check = true;
            try
            {
                while (check)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    response=Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    //var ff = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    //response = reader.ReadLine();
                    //if (response == null)break;
                    if (response != null) check = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return response;
        }

        public string MyReceiveMessagesJson()
        {

            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string response = "Ничего не пришло";
            bool check = true;
            try
            {
                while (check)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    //var ff = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    //response = reader.ReadLine();
                    //if (response == null)break;
                    if (response != null) check = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Console.WriteLine($"Ошибка при получении данных: {ex.Message}");
            }
            return response;
        }




        //ИЗВЛЕЧЕНИЕ ID УЧАСТНИКА ИЗ ВХОДЯЩЕГО СООБЩЕНИЯ
        public static int getClIdFromMes(string str)
        {
            //string[] splitstr = str.Split('-');
            //int i = Int32.Parse(splitstr[1]);
            int i = Int32.Parse(str);
            return i;
        }
        //ИЗВЛЕЧЕНИЕ сообщения УЧАСТНИКА ИЗ ВХОДЯЩЕГО СООБЩЕНИЯ
        public static string[] getCldataFromMes(string str)
        {
            string[] splitstr = str.Split('/', '-');
            
            return splitstr;
        }

    }
}

// Запуск потоков для отправки и приёма сообщений
//Thread sendThread = new Thread(() => MySendMessage(stream));
//Thread receiveThread = new Thread(() => MyReceiveMessages(stream));

//sendThread = new Thread(() => MySendMessage(stream));
//receiveThread = new Thread(() => MyReceiveMessages(stream));

//sendThread.Start();
//receiveThread.Start();

//sendThread.Join();
//receiveThread.Join();

// Закрытие соединения
//stream.Close();
//myclient.Close();




